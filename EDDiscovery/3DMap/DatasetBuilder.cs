﻿using EDDiscovery;
using EDDiscovery.DB;
using EDDiscovery2.DB;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Diagnostics;
using EDDiscovery2.Trilateration;
using OpenTK;
using System.Resources;
using EDDiscovery.Properties;
using EDDiscovery.EDSM;

namespace EDDiscovery2._3DMap
{
    public class DatasetBuilder
    {
        private List<IData3DSet> _datasets;
        private static Dictionary<string, TexturedQuadData> _cachedTextures = new Dictionary<string, TexturedQuadData>();

        public EDDConfig.MapColoursClass MapColours { get; set; } = EDDConfig.Instance.MapColours;

        public Vector2 MinGridPos { get; set; } = new Vector2(-50000.0f, -20000.0f);
        public Vector2 MaxGridPos { get; set; } = new Vector2(50000.0f, 80000.0f);

        int gridunitSize = 1000;

        public DatasetBuilder()
        {
            _datasets = new List<IData3DSet>();
        }

        public List<IData3DSet> BuildMaps(ref List<FGEImage> images)
        {
            AddMapImages(ref images);
            return _datasets;
        }

        public List<IData3DSet> BuildVisitedSystems(bool drawlines, ISystem centersystem, List<VisitedSystemsClass> VisitedSystems,
                                                     List<SystemClass> refsys, List<SystemClass> planned)
        {
            AddVisitedSystemsInformation(drawlines, VisitedSystems);
            AddRoutePlannerInfoToDataset(planned);
            AddTrilaterationInfoToDataset(centersystem, refsys);
            return _datasets;
        }

        public List<IData3DSet> BuildSelected(ISystem centresystem, ISystem selectedsystem)
        {
            AddSelectedSystemToDataset(selectedsystem);
            AddCenterPointToDataset(centresystem);
            return _datasets;
        }

        private void AddMapImages(ref List<FGEImage> Images)
        {
            if (Images != null && Images.Count != 0)
            {
                var datasetMapImg = Data3DSetClass<TexturedQuadData>.Create("mapimage", Color.White, 1.0f);
                foreach (var img in Images)
                {
                    if (_cachedTextures.ContainsKey(img.FileName))
                    {
                        datasetMapImg.Add(_cachedTextures[img.FileName]);
                    }
                    else
                    {
                        var texture = TexturedQuadData.FromFGEImage(img);
                        _cachedTextures[img.FileName] = texture;
                        datasetMapImg.Add(texture);
                    }
                }
                _datasets.Add(datasetMapImg);
            }
        }

        private Bitmap DrawGridBitmap(Bitmap text_bmp, float x, float z, Font fnt, int px, int py)
        {
            using (Graphics g = Graphics.FromImage(text_bmp))
            {
                //using (Brush br = new SolidBrush(Color.Yellow))
                // g.FillRectangle(br, 0, 0, text_bmp.Width, text_bmp.Height);

                using (Brush br = new SolidBrush(MapColours.CoarseGridLines))
                    g.DrawString(x.ToString("0") + "," + z.ToString("0"), fnt, br, new Point(px, py));
            }

            return text_bmp;
        }

        public List<IData3DSet> AddStarBookmarks(Bitmap mapstar, Bitmap mapregion, Bitmap maptarget, double widthly, double heightly, bool vert)
        {
            var datasetbks = Data3DSetClass<TexturedQuadData>.Create("bkmrs", Color.White, 1f);
            widthly /= 2;

            long bookmarktarget = TargetClass.GetTargetBookmark();

            foreach (BookmarkClass bc in BookmarkClass.bookmarks)
            {
                TexturedQuadData newtexture;

                Bitmap touse = (bc.id == bookmarktarget) ? maptarget : ((bc.isRegion) ? mapregion : mapstar);

                if (vert)
                {
                    newtexture = TexturedQuadData.FromBitmapVert(touse,
                                             new PointF((float)(bc.x - widthly), (float)(bc.y + heightly)),
                                                new PointF((float)(bc.x + widthly), (float)(bc.y + heightly)),
                                             new PointF((float)(bc.x - widthly), (float)bc.y),
                                                new PointF((float)(bc.x + widthly), (float)bc.y),
                                             (float)bc.z);
                }
                else
                {
                    newtexture = TexturedQuadData.FromBitmapHorz(touse,
                                              new PointF((float)(bc.x - widthly), (float)(bc.z + heightly)),
                                                 new PointF((float)(bc.x + widthly), (float)(bc.z + heightly)),
                                              new PointF((float)(bc.x - widthly), (float)bc.z),
                                                 new PointF((float)(bc.x + widthly), (float)bc.z),
                                              (float)bc.y);
                }

                datasetbks.Add(newtexture);
            }

            _datasets.Add(datasetbks);

            return _datasets;
        }

        public List<IData3DSet> AddNotedBookmarks(Bitmap map, Bitmap maptarget, double widthly, double heightly, bool vert, List<VisitedSystemsClass> VisitedSystems)
        {
            var datasetbks = Data3DSetClass<TexturedQuadData>.Create("bkmrs", Color.White, 1f);
            widthly /= 2;

            long bookmarknoted = TargetClass.GetTargetNotedSystem();

            if (VisitedSystems != null)
            {
                foreach (VisitedSystemsClass vs in VisitedSystems)
                {
                    SystemNoteClass notecs = SystemNoteClass.GetSystemNoteClass(vs.Name);

                    if (notecs != null)         // if we have a note..
                    {
                        string note = notecs.Note.Trim();

                        if (note.Length > 0)
                        {
                            double x = (vs.HasTravelCoordinates) ? vs.X : vs.curSystem.x;
                            double y = (vs.HasTravelCoordinates) ? vs.Y : vs.curSystem.y;
                            double z = (vs.HasTravelCoordinates) ? vs.Z : vs.curSystem.z;

                            TexturedQuadData newtexture;

                            if (vert)
                            {
                                newtexture = TexturedQuadData.FromBitmapVert((notecs.id == bookmarknoted) ? maptarget : map,
                                                            new PointF((float)(x - widthly), (float)(y + heightly)),
                                                            new PointF((float)(x + widthly), (float)(y + heightly)),
                                                            new PointF((float)(x - widthly), (float)y),
                                                            new PointF((float)(x + widthly), (float)y),
                                                            (float)z);
                            }
                            else
                            {
                                newtexture = TexturedQuadData.FromBitmapHorz((notecs.id == bookmarknoted) ? maptarget : map,
                                                                            new PointF((float)(x - widthly), (float)(z + heightly)),
                                                                            new PointF((float)(x + widthly), (float)(z + heightly)),
                                                                            new PointF((float)(x - widthly), (float)z),
                                                                            new PointF((float)(x + widthly), (float)z),
                                                                            (float)y);
                            }

                            datasetbks.Add(newtexture);
                        }
                    }
                }
            }

            _datasets.Add(datasetbks);

            return _datasets;
        }

        public List<IData3DSet> AddGalMapObjectsToDataset(Bitmap target, double widthly, double heightly, bool vert , int selected)
        {
            var datasetbks = Data3DSetClass<TexturedQuadData>.Create("galobj", Color.White, 1f);
            widthly /= 2;
            heightly /= 2;

            if (EDDiscoveryForm.galacticMapping != null )
            {
                long gmotarget = TargetClass.GetTargetGMO();

                string fontname = "MS Sans Serif";                  // calculate once for bitmap 
                Font fnt = new Font(fontname, 16F);

                int textwidth = 0, textheight = 0;
                Bitmap text_bmp = new Bitmap(500, 30);
                using (Graphics g = Graphics.FromImage(text_bmp))
                {
                    SizeF sz = g.MeasureString("Athaip Wisteria Nebula Here", fnt);
                    textwidth = (int)sz.Width + 4;
                    textheight = (int)sz.Height + 4;
                }

                foreach ( GalacticMapObject gmo in EDDiscoveryForm.galacticMapping.galacticMapObjects)
                {
                    PointData pd = (gmo.points.Count>0) ? gmo.points[0] : null;     // lets be paranoid
                    Bitmap touse = gmo.galMapType.Image;                        // under our control, so must have it

                    if (touse != null && pd != null && gmo.galMapType.Enabled )     // if it has an image (may not) and has a co-ord, may not.. 
                    {
                        Debug.Assert(touse != null);

                        TexturedQuadData newtexture;

                        if (vert)
                        {
                            newtexture = TexturedQuadData.FromBitmapVert(touse,
                                                     new PointF((float)(pd.x - widthly), (float)(pd.y + heightly)),
                                                        new PointF((float)(pd.x + widthly), (float)(pd.y + heightly)),
                                                     new PointF((float)(pd.x - widthly), (float)(pd.y - heightly)),
                                                        new PointF((float)(pd.x + widthly), (float)(pd.y - heightly)),
                                                     (float)pd.z);
                        }
                        else
                        {
                            newtexture = TexturedQuadData.FromBitmapHorz(touse,
                                                      new PointF((float)(pd.x - widthly), (float)(pd.z + heightly)),
                                                         new PointF((float)(pd.x + widthly), (float)(pd.z + heightly)),
                                                      new PointF((float)(pd.x - widthly), (float)(pd.z-heightly)),
                                                         new PointF((float)(pd.x + widthly), (float)(pd.z-heightly)),
                                                      (float)pd.y);
                        }

                        datasetbks.Add(newtexture);

                        Bitmap map = DrawStringCentered(gmo.name, fnt, textwidth, textheight, Color.Orange);

                        if (vert)
                        {
                            double wd = widthly / 5 * gmo.name.Length;

                            newtexture = TexturedQuadData.FromBitmapVert(map,
                                                     new PointF((float)(pd.x - wd), (float)(pd.y - heightly - widthly)),
                                                        new PointF((float)(pd.x + wd), (float)(pd.y - heightly- widthly)),
                                                     new PointF((float)(pd.x - wd), (float)(pd.y - heightly)),
                                                        new PointF((float)(pd.x + wd), (float)(pd.y - heightly)),
                                                     (float)pd.z);
                        }
                        else
                        {
                            newtexture = TexturedQuadData.FromBitmapHorz(map,
                                                      new PointF((float)(pd.x - widthly), (float)(pd.z - heightly)),
                                                         new PointF((float)(pd.x + widthly), (float)(pd.z - heightly)),
                                                      new PointF((float)(pd.x - widthly), (float)(pd.z - heightly - 50)),
                                                         new PointF((float)(pd.x + widthly), (float)(pd.z - heightly -50)),
                                                      (float)pd.y);
                        }

                        datasetbks.Add(newtexture);

                        if ( gmo.id == gmotarget )
                        {
                            if (vert)
                            {
                                newtexture = TexturedQuadData.FromBitmapVert(target,
                                                         new PointF((float)(pd.x - widthly/2), (float)(pd.y + heightly+heightly/2)),
                                                            new PointF((float)(pd.x + widthly/2), (float)(pd.y + heightly+heightly/2)),
                                                         new PointF((float)(pd.x - widthly/2), (float)(pd.y + heightly)),
                                                            new PointF((float)(pd.x + widthly/2), (float)(pd.y + heightly)),
                                                         (float)pd.z);
                            }
                            else
                            {
                                newtexture = TexturedQuadData.FromBitmapHorz(target,
                                                          new PointF((float)(pd.x - widthly/2), (float)(pd.z + heightly+heightly/2)),
                                                             new PointF((float)(pd.x + widthly/2), (float)(pd.z + heightly+heightly/2)),
                                                          new PointF((float)(pd.x - widthly/2), (float)(pd.z + heightly)),
                                                             new PointF((float)(pd.x + widthly/2), (float)(pd.z + heightly)),
                                                          (float)pd.y);
                            }

                            datasetbks.Add(newtexture);
                        }
                    }
                }
            }

            _datasets.Add(datasetbks);

            return _datasets;
        }

        public List<IData3DSet> AddGridCoords()
        {
            string fontname = "MS Sans Serif";
            {
                Font fnt = new Font(fontname, 20F);

                int bitmapwidth, bitmapheight;
                Bitmap text_bmp = new Bitmap(300, 30);
                using (Graphics g = Graphics.FromImage(text_bmp))
                {
                    SizeF sz = g.MeasureString("-99999,-99999", fnt);
                    bitmapwidth = (int)sz.Width + 4;
                    bitmapheight = (int)sz.Height + 4;
                }
                var datasetMapImgLOD1 = Data3DSetClass<TexturedQuadData>.Create("text bitmap LOD1", Color.White, 1.0f);
                var datasetMapImgLOD2 = Data3DSetClass<TexturedQuadData>.Create("text bitmap LOD2", Color.FromArgb(128, Color.White), 1.0f);

                int textheightly = 50;
                int textwidthly = textheightly * bitmapwidth / bitmapheight;

                int gridwideLOD1 = (int)Math.Floor((MaxGridPos.X - MinGridPos.X) / gridunitSize + 1);
                int gridhighLOD1 = (int)Math.Floor((MaxGridPos.Y - MinGridPos.Y) / gridunitSize + 1);
                int gridwideLOD2 = (int)Math.Floor((MaxGridPos.X - MinGridPos.X) / (gridunitSize * 10) + 1);
                int gridhighLOD2 = (int)Math.Floor((MaxGridPos.Y - MinGridPos.Y) / (gridunitSize * 10) + 1);
                int texwide = 1024 / bitmapwidth;
                int texhigh = 1024 / bitmapheight;
                int numtexLOD1 = (int)Math.Ceiling((gridwideLOD1 * gridhighLOD1) * 1.0 / (texwide * texhigh));
                int numtexLOD2 = (int)Math.Ceiling((gridwideLOD2 * gridhighLOD2) * 1.0 / (texwide * texhigh));

                List<TexturedQuadData> basetexturesLOD1 = Enumerable.Range(0, numtexLOD1).Select(i => new TexturedQuadData(null, null, new Bitmap(1024, 1024))).ToList();
                List<TexturedQuadData> basetexturesLOD2 = Enumerable.Range(0, numtexLOD2).Select(i => new TexturedQuadData(null, null, new Bitmap(1024, 1024))).ToList();

                for (float x = MinGridPos.X; x < MaxGridPos.X; x += gridunitSize)
                {
                    for (float z = MinGridPos.Y; z <= MaxGridPos.Y; z += gridunitSize)
                    {
                        int num = (int)(Math.Floor((x - MinGridPos.X) / gridunitSize) * gridwideLOD1 + Math.Floor((z - MinGridPos.Y) / gridunitSize));
                        int tex_x = (num % texwide) * bitmapwidth;
                        int tex_y = ((num / texwide) % texhigh) * bitmapheight;
                        int tex_n = num / (texwide * texhigh);

                        DrawGridBitmap(basetexturesLOD1[tex_n].Texture, x, z, fnt, tex_x, tex_y);
                        datasetMapImgLOD1.Add(basetexturesLOD1[tex_n].CreateSubTexture(
                            new Point((int)x, (int)z), new Point((int)x + textwidthly, (int)z),
                            new Point((int)x, (int)z + textheightly), new Point((int)x + textwidthly, (int)z + textheightly),
                            new Point(tex_x, tex_y + bitmapheight), new Point(tex_x + bitmapwidth, tex_y + bitmapheight),
                            new Point(tex_x, tex_y), new Point(tex_x + bitmapwidth, tex_y)));
                    }
                }

                for (float x = MinGridPos.X; x < MaxGridPos.X; x += gridunitSize * 10)
                {
                    for (float z = MinGridPos.Y; z <= MaxGridPos.Y; z += gridunitSize * 10)
                    {
                        int num = (int)(Math.Floor((x - MinGridPos.X) / (gridunitSize * 10)) * gridwideLOD2 + Math.Floor((z - MinGridPos.Y) / (gridunitSize * 10)));
                        int tex_x = (num % texwide) * bitmapwidth;
                        int tex_y = ((num / texwide) % texhigh) * bitmapheight;
                        int tex_n = num / (texwide * texhigh);

                        DrawGridBitmap(basetexturesLOD2[tex_n].Texture, x, z, fnt, tex_x, tex_y);
                        datasetMapImgLOD2.Add(basetexturesLOD2[tex_n].CreateSubTexture(
                            new Point((int)x, (int)z), new Point((int)x + textwidthly * 10, (int)z),
                            new Point((int)x, (int)z + textheightly * 10), new Point((int)x + textwidthly * 10, (int)z + textheightly * 10),
                            new Point(tex_x, tex_y + bitmapheight), new Point(tex_x + bitmapwidth, tex_y + bitmapheight),
                            new Point(tex_x, tex_y), new Point(tex_x + bitmapwidth, tex_y)));
                    }
                }

                _datasets.Add(datasetMapImgLOD1);
                _datasets.Add(datasetMapImgLOD2);
            }

            return _datasets;
        }

        public List<IData3DSet> AddFineGridLines()
        {
            int smallUnitSize = gridunitSize / 10;
            var smalldatasetGrid = Data3DSetClass<LineData>.Create("gridLOD0", MapColours.FineGridLines, 0.6f);

            for (float x = MinGridPos.X; x <= MaxGridPos.X; x += smallUnitSize)
            {
                smalldatasetGrid.Add(new LineData(x, 0, MinGridPos.Y, x, 0, MaxGridPos.Y));
            }

            for (float z = MinGridPos.Y; z <= MaxGridPos.Y; z += smallUnitSize)
            {
                smalldatasetGrid.Add(new LineData(MinGridPos.X, 0, z, MaxGridPos.X, 0, z));
            }

            _datasets.Add(smalldatasetGrid);
            return _datasets;
        }

        public List<IData3DSet> AddCoarseGridLines()
        {
            var datasetGridLOD1 = Data3DSetClass<LineData>.Create("gridLOD1", MapColours.CoarseGridLines, 0.6f);

            for (float x = MinGridPos.X; x <= MaxGridPos.X; x += gridunitSize)
            {
                datasetGridLOD1.Add(new LineData(x, 0, MinGridPos.Y, x, 0, MaxGridPos.Y));
            }

            for (float z = MinGridPos.Y; z <= MaxGridPos.Y; z += gridunitSize)
            {
                datasetGridLOD1.Add(new LineData(MinGridPos.X, 0, z, MaxGridPos.X, 0, z));
            }

            _datasets.Add(datasetGridLOD1);

            var datasetGridLOD2 = Data3DSetClass<LineData>.Create("gridLOD2", MapColours.CoarseGridLines, 0.6f);

            for (float x = MinGridPos.X; x <= MaxGridPos.X; x += gridunitSize * 10)
            {
                datasetGridLOD2.Add(new LineData(x, 0, MinGridPos.Y, x, 0, MaxGridPos.Y));
            }

            for (float z = MinGridPos.Y; z <= MaxGridPos.Y; z += gridunitSize * 10)
            {
                datasetGridLOD2.Add(new LineData(MinGridPos.X, 0, z, MaxGridPos.X, 0, z));
            }

            _datasets.Add(datasetGridLOD2);
            return _datasets;
        }

        public void UpdateGridZoom(ref List<IData3DSet> _datasets, double zoom)
        {
            double LOD1fade = Math.Max(Math.Min((zoom / 0.1 - 1.0) / 5.0, 1.0), 0.5);

            var gridLOD1 = _datasets.SingleOrDefault(s => s.Name == "gridLOD1");
            if (gridLOD1 != null)
            {
                var colour = MapColours.CoarseGridLines;
                //Console.WriteLine("LOD1 fade"+ LOD1fade);
                colour = Color.FromArgb((int)(colour.R * LOD1fade), (int)(colour.G * LOD1fade), (int)(colour.B * LOD1fade));
                var newgrid = Data3DSetClass<LineData>.Create("gridLOD1", colour, 0.6f);

                foreach (var line in ((Data3DSetClass<LineData>)gridLOD1).Primatives)
                {
                    newgrid.Add(line);
                }

                int index = _datasets.IndexOf(gridLOD1);
                _datasets.Remove(gridLOD1);
                ((IDisposable)gridLOD1).Dispose();
                _datasets.Insert(index, newgrid);
            }
        }

        public void UpdateGridCoordZoom(ref List<IData3DSet> _datasets, double zoom)
        {
            double LOD2fade = Math.Max(Math.Min((0.2 / zoom - 1.0) / 2.0, 1.0), 0.0);

            var gridLOD2 = _datasets.SingleOrDefault(s => s.Name == "text bitmap LOD2");
            if (gridLOD2 != null)
            {
                //Console.WriteLine("LOD2 fade" + LOD2fade);
                var newgrid = Data3DSetClass<TexturedQuadData>.Create("text bitmap LOD2", Color.FromArgb((int)(255 * LOD2fade), Color.White), 1.0f);
                foreach (var tex in ((Data3DSetClass<TexturedQuadData>)gridLOD2).Primatives)
                {
                    newgrid.Add(tex);
                }

                _datasets.Remove(gridLOD2);
                _datasets.Add(newgrid);
            }
        }

        private void AddVisitedSystemsInformation( bool DrawLines , List<VisitedSystemsClass> VisitedSystems )
        {
            if (VisitedSystems != null && VisitedSystems.Any())
            {
                VisitedSystemsClass.SetLastKnownSystemPosition(VisitedSystems);

                // For some reason I am unable to fathom this errors during the session after DBUpgrade8
                // colours just resolves to an object reference not set error, but after a restart it works fine
                // Not going to waste any more time, a one time restart is hardly the worst workaround in the world...
                IEnumerable<IGrouping<int, VisitedSystemsClass>> colours =
                    from VisitedSystemsClass sysPos in VisitedSystems 
                    group sysPos by sysPos.MapColour;

                if (colours!=null)
                {
                    foreach (IGrouping<int, VisitedSystemsClass> colour in colours)
                    {
                        if (DrawLines)
                        {
                            var datasetl = Data3DSetClass<LineData>.Create("visitedstars" + colour.Key.ToString(), Color.FromArgb(colour.Key), 2.0f);
                            foreach (VisitedSystemsClass sp in colour)
                            {
                                if (sp.curSystem != null && sp.curSystem.HasCoordinate && sp.lastKnownSystem != null && sp.lastKnownSystem.HasCoordinate)
                                {
                                    datasetl.Add(new LineData(sp.curSystem.x, sp.curSystem.y, sp.curSystem.z,
                                        sp.lastKnownSystem.x, sp.lastKnownSystem.y, sp.lastKnownSystem.z));

                                }
                            }
                            _datasets.Add(datasetl);
                        }
                        else
                        {
                            var datasetvs = Data3DSetClass<PointData>.Create("visitedstars" + colour.Key.ToString(), Color.FromArgb(colour.Key), 2.0f);
                            foreach (VisitedSystemsClass sp in colour)
                            {
                                if ( sp.curSystem != null && sp.curSystem.HasCoordinate)
                                {
                                    datasetvs.Add(new PointData(sp.curSystem.x, sp.curSystem.y, sp.curSystem.z));
                                }
                            }
                            _datasets.Add(datasetvs);
                        }

                    }
                }
            }
        }


        // Planned change: Centered system will be marked but won't be "center" of the galaxy
        // dataset anymore. The origin will stay at Sol.
        private void AddCenterPointToDataset(ISystem CenterSystem)
    {
            var dataset = Data3DSetClass<PointData>.Create("Center", MapColours.CentredSystem, 5.0f);

            //GL.Enable(EnableCap.ProgramPointSize);
            dataset.Add(new PointData(CenterSystem.x, CenterSystem.y, CenterSystem.z));
            _datasets.Add(dataset);
        }

        private void AddSelectedSystemToDataset(ISystem SelectedSystem)
    {
            if (SelectedSystem != null)
            {
                var dataset = Data3DSetClass<PointData>.Create("Selected", MapColours.SelectedSystem, 8.0f);

                //GL.Enable(EnableCap.ProgramPointSize);
                dataset.Add(new PointData(SelectedSystem.x, SelectedSystem.y, SelectedSystem.z));
                _datasets.Add(dataset);
            }
        }

        public List<IData3DSet> AddPOIsToDataset()
        {
            var dataset = Data3DSetClass<PointData>.Create("Interest", MapColours.POISystem, 10.0f);
            AddSystem("sol", dataset);
            AddSystem("sagittarius a*", dataset);
            AddSystem("CEECKIA ZQ-L C24-0", dataset);
            AddSystem("Beagle Point", dataset);
            _datasets.Add(dataset);
            return _datasets;
        }

        private void AddTrilaterationInfoToDataset(ISystem CenterSystem, List<SystemClass> ReferenceSystems)
        {
            if (ReferenceSystems != null && ReferenceSystems.Any())
            {
                var referenceLines = Data3DSetClass<LineData>.Create("CurrentReference", MapColours.TrilatCurrentReference, 5.0f);
                foreach (var refSystem in ReferenceSystems)
                {
                    referenceLines.Add(new LineData(CenterSystem.x, CenterSystem.y, CenterSystem.z, refSystem.x, refSystem.y, refSystem.z));
                }

                _datasets.Add(referenceLines);

                var lineSet = Data3DSetClass<LineData>.Create("SuggestedReference", MapColours.TrilatSuggestedReference, 5.0f);


                Stopwatch sw = new Stopwatch();
                sw.Start();
                SuggestedReferences references = new SuggestedReferences(CenterSystem.x, CenterSystem.y, CenterSystem.z);

                for (int ii = 0; ii < 16; ii++)
                {
                    var rsys = references.GetCandidate();
                    if (rsys == null) break;
                    var system = rsys.System;
                    references.AddReferenceStar(system);
                    if (ReferenceSystems != null && ReferenceSystems.Any(s => s.name == system.name)) continue;
                    System.Diagnostics.Trace.WriteLine(string.Format("{0} Dist: {1} x:{2} y:{3} z:{4}", system.name, rsys.Distance.ToString("0.00"), system.x, system.y, system.z));
                    lineSet.Add(new LineData(CenterSystem.x, CenterSystem.y, CenterSystem.z, system.x, system.y, system.z));
                }
                sw.Stop();
                System.Diagnostics.Trace.WriteLine("Reference stars time " + sw.Elapsed.TotalSeconds.ToString("0.000s"));
                _datasets.Add(lineSet);
            }
        }

        private void AddRoutePlannerInfoToDataset(List<SystemClass> PlannedRoute)
        {
            if (PlannedRoute != null && PlannedRoute.Any())
            {
                var routeLines = Data3DSetClass<LineData>.Create("PlannedRoute", MapColours.PlannedRoute, 25.0f);
                ISystem prevSystem = PlannedRoute.First();
                foreach (ISystem point in PlannedRoute.Skip(1))
                {
                    routeLines.Add(new LineData(prevSystem.x, prevSystem.y, prevSystem.z, point.x, point.y, point.z));
                    prevSystem = point;
                }
                _datasets.Add(routeLines);
            }
        }

        private void AddSystem(string systemName, Data3DSetClass<PointData> dataset)
        {
            SystemClass system = SystemClass.GetSystem(systemName);

            if (system != null && system.HasCoordinate)
            {
                dataset.Add(new PointData(system.x, system.y, system.z));
            }
        }

        static public Bitmap DrawString(string str, Font fnt, int w, int h, Color textcolour)
        {
            Bitmap text_bmp = new Bitmap(w, h);
            using (Graphics g = Graphics.FromImage(text_bmp))
            {
                using (Brush br = new SolidBrush(textcolour))
                    g.DrawString(str, fnt, br, new Point(0, 0));
            }

            return text_bmp;
        }

        static public Bitmap DrawStringCentered(string str, Font fnt, int w, int h, Color textcolour)
        {
            StringFormat fmt = new StringFormat();
            fmt.Alignment = StringAlignment.Center;

            Bitmap text_bmp = new Bitmap(w, h);
            using (Graphics g = Graphics.FromImage(text_bmp))
            {
                using (Brush br = new SolidBrush(textcolour))
                    g.DrawString(str, fnt, br, new RectangleF(0, 0,text_bmp.Size.Width,text_bmp.Size.Height),fmt);
            }

            return text_bmp;
        }

    }
}
