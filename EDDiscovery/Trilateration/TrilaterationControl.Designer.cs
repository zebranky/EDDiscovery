/*
 * Copyright © 2015 - 2017 EDDiscovery development team
 *
 * Licensed under the Apache License, Version 2.0 (the "License"); you may not use this
 * file except in compliance with the License. You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing, software distributed under
 * the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF
 * ANY KIND, either express or implied. See the License for the specific language
 * governing permissions and limitations under the License.
 * 
 * EDDiscovery is not affiliated with Frontier Developments plc.
 */
using ExtendedControls;

namespace EDDiscovery
{
    partial class TrilaterationControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.trilatContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToWantedSystemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewOnEDSMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelTargetSystem = new System.Windows.Forms.Label();
            this.labelCoordinates = new System.Windows.Forms.Label();
            this.labelCoordinateX = new System.Windows.Forms.Label();
            this.labelCoordinateY = new System.Windows.Forms.Label();
            this.labelCoordinateZ = new System.Windows.Forms.Label();
            this.wantedContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeFromWantedSystemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewOnEDSMToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAllWithKnownPositionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAllLocalSystemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAllEDSMSystemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_controls = new System.Windows.Forms.Panel();
            this.textBox_status = new ExtendedControls.TextBoxBorder();
            this.labelstpos = new System.Windows.Forms.Label();
            this.textBoxSystemName = new ExtendedControls.TextBoxBorder();
            this.textBoxCoordinateX = new ExtendedControls.TextBoxBorder();
            this.textBoxCoordinateY = new ExtendedControls.TextBoxBorder();
            this.textBoxCoordinateZ = new ExtendedControls.TextBoxBorder();
            this.splitContainerCustom1 = new ExtendedControls.SplitContainerCustom();
            this.splitContainerCustom2 = new ExtendedControls.SplitContainerCustom();
            this.dataViewScroller_Distances = new ExtendedControls.DataViewScrollerPanel();
            this.vScrollBarCustom1 = new ExtendedControls.VScrollBarCustom();
            this.dataGridViewDistances = new System.Windows.Forms.DataGridView();
            this.ColumnSystem = new ExtendedControls.AutoCompleteDGVColumn();
            this.ColumnDistance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCalculated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.richTextBox_History = new ExtendedControls.RichTextBoxScroll();
            this.dataViewScroller_Wanted = new ExtendedControls.DataViewScrollerPanel();
            this.vScrollBarCustom2 = new ExtendedControls.VScrollBarCustom();
            this.dataGridViewClosestSystems = new System.Windows.Forms.DataGridView();
            this.Source = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnClosestSystemsSystem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.trilatContextMenu.SuspendLayout();
            this.wantedContextMenu.SuspendLayout();
            this.panel_controls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerCustom1)).BeginInit();
            this.splitContainerCustom1.Panel1.SuspendLayout();
            this.splitContainerCustom1.Panel2.SuspendLayout();
            this.splitContainerCustom1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerCustom2)).BeginInit();
            this.splitContainerCustom2.Panel1.SuspendLayout();
            this.splitContainerCustom2.Panel2.SuspendLayout();
            this.splitContainerCustom2.SuspendLayout();
            this.dataViewScroller_Distances.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDistances)).BeginInit();
            this.dataViewScroller_Wanted.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClosestSystems)).BeginInit();
            this.SuspendLayout();
            // 
            // trilatContextMenu
            // 
            this.trilatContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToWantedSystemsToolStripMenuItem,
            this.viewOnEDSMToolStripMenuItem,
            this.pasteToolStripMenuItem});
            this.trilatContextMenu.Name = "trilatContextMenu";
            this.trilatContextMenu.Size = new System.Drawing.Size(198, 70);
            // 
            // addToWantedSystemsToolStripMenuItem
            // 
            this.addToWantedSystemsToolStripMenuItem.Name = "addToWantedSystemsToolStripMenuItem";
            this.addToWantedSystemsToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.addToWantedSystemsToolStripMenuItem.Text = "Add to wanted systems";
            this.addToWantedSystemsToolStripMenuItem.Click += new System.EventHandler(this.addToWantedSystemsToolStripMenuItem_Click);
            // 
            // viewOnEDSMToolStripMenuItem
            // 
            this.viewOnEDSMToolStripMenuItem.Name = "viewOnEDSMToolStripMenuItem";
            this.viewOnEDSMToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.viewOnEDSMToolStripMenuItem.Text = "View on EDSM";
            this.viewOnEDSMToolStripMenuItem.Click += new System.EventHandler(this.viewOnEDSMToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // labelTargetSystem
            // 
            this.labelTargetSystem.AutoSize = true;
            this.labelTargetSystem.Location = new System.Drawing.Point(3, 35);
            this.labelTargetSystem.Name = "labelTargetSystem";
            this.labelTargetSystem.Size = new System.Drawing.Size(44, 13);
            this.labelTargetSystem.TabIndex = 2;
            this.labelTargetSystem.Text = "System:";
            // 
            // labelCoordinates
            // 
            this.labelCoordinates.AutoSize = true;
            this.labelCoordinates.Location = new System.Drawing.Point(3, 65);
            this.labelCoordinates.Name = "labelCoordinates";
            this.labelCoordinates.Size = new System.Drawing.Size(122, 13);
            this.labelCoordinates.TabIndex = 5;
            this.labelCoordinates.Text = "Trilaterated Coordinates:";
            // 
            // labelCoordinateX
            // 
            this.labelCoordinateX.AutoSize = true;
            this.labelCoordinateX.Location = new System.Drawing.Point(148, 67);
            this.labelCoordinateX.Name = "labelCoordinateX";
            this.labelCoordinateX.Size = new System.Drawing.Size(17, 13);
            this.labelCoordinateX.TabIndex = 7;
            this.labelCoordinateX.Text = "X:";
            // 
            // labelCoordinateY
            // 
            this.labelCoordinateY.AutoSize = true;
            this.labelCoordinateY.Location = new System.Drawing.Point(228, 67);
            this.labelCoordinateY.Name = "labelCoordinateY";
            this.labelCoordinateY.Size = new System.Drawing.Size(17, 13);
            this.labelCoordinateY.TabIndex = 9;
            this.labelCoordinateY.Text = "Y:";
            // 
            // labelCoordinateZ
            // 
            this.labelCoordinateZ.AutoSize = true;
            this.labelCoordinateZ.Location = new System.Drawing.Point(309, 67);
            this.labelCoordinateZ.Name = "labelCoordinateZ";
            this.labelCoordinateZ.Size = new System.Drawing.Size(17, 13);
            this.labelCoordinateZ.TabIndex = 11;
            this.labelCoordinateZ.Text = "Z:";
            // 
            // wantedContextMenu
            // 
            this.wantedContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeFromWantedSystemsToolStripMenuItem,
            this.viewOnEDSMToolStripMenuItem1,
            this.deleteAllWithKnownPositionToolStripMenuItem,
            this.addAllLocalSystemsToolStripMenuItem,
            this.addAllEDSMSystemsToolStripMenuItem});
            this.wantedContextMenu.Name = "wantedContextMenu";
            this.wantedContextMenu.Size = new System.Drawing.Size(234, 114);
            // 
            // removeFromWantedSystemsToolStripMenuItem
            // 
            this.removeFromWantedSystemsToolStripMenuItem.Name = "removeFromWantedSystemsToolStripMenuItem";
            this.removeFromWantedSystemsToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.removeFromWantedSystemsToolStripMenuItem.Text = "Remove from wanted systems";
            this.removeFromWantedSystemsToolStripMenuItem.Click += new System.EventHandler(this.removeFromWantedSystemsToolStripMenuItem_Click);
            // 
            // viewOnEDSMToolStripMenuItem1
            // 
            this.viewOnEDSMToolStripMenuItem1.Name = "viewOnEDSMToolStripMenuItem1";
            this.viewOnEDSMToolStripMenuItem1.Size = new System.Drawing.Size(233, 22);
            this.viewOnEDSMToolStripMenuItem1.Text = "View on EDSM";
            this.viewOnEDSMToolStripMenuItem1.Click += new System.EventHandler(this.viewOnEDSMToolStripMenuItem1_Click);
            // 
            // deleteAllWithKnownPositionToolStripMenuItem
            // 
            this.deleteAllWithKnownPositionToolStripMenuItem.Name = "deleteAllWithKnownPositionToolStripMenuItem";
            this.deleteAllWithKnownPositionToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.deleteAllWithKnownPositionToolStripMenuItem.Text = "Delete all with known position";
            this.deleteAllWithKnownPositionToolStripMenuItem.Click += new System.EventHandler(this.deleteAllWithKnownPositionToolStripMenuItem_Click);
            // 
            // addAllLocalSystemsToolStripMenuItem
            // 
            this.addAllLocalSystemsToolStripMenuItem.Name = "addAllLocalSystemsToolStripMenuItem";
            this.addAllLocalSystemsToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.addAllLocalSystemsToolStripMenuItem.Text = "Add all local systems";
            this.addAllLocalSystemsToolStripMenuItem.Click += new System.EventHandler(this.addAllLocalSystemsToolStripMenuItem_Click);
            // 
            // addAllEDSMSystemsToolStripMenuItem
            // 
            this.addAllEDSMSystemsToolStripMenuItem.Name = "addAllEDSMSystemsToolStripMenuItem";
            this.addAllEDSMSystemsToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.addAllEDSMSystemsToolStripMenuItem.Text = "Add all EDSM systems";
            this.addAllEDSMSystemsToolStripMenuItem.Click += new System.EventHandler(this.addAllEDSMSystemsToolStripMenuItem_Click);
            // 
            // panel_controls
            // 
            this.panel_controls.Controls.Add(this.textBox_status);
            this.panel_controls.Controls.Add(this.labelstpos);
            this.panel_controls.Controls.Add(this.textBoxSystemName);
            this.panel_controls.Controls.Add(this.labelTargetSystem);
            this.panel_controls.Controls.Add(this.labelCoordinates);
            this.panel_controls.Controls.Add(this.textBoxCoordinateX);
            this.panel_controls.Controls.Add(this.labelCoordinateX);
            this.panel_controls.Controls.Add(this.textBoxCoordinateY);
            this.panel_controls.Controls.Add(this.labelCoordinateY);
            this.panel_controls.Controls.Add(this.textBoxCoordinateZ);
            this.panel_controls.Controls.Add(this.labelCoordinateZ);
            this.panel_controls.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_controls.Location = new System.Drawing.Point(0, 0);
            this.panel_controls.Name = "panel_controls";
            this.panel_controls.Size = new System.Drawing.Size(924, 98);
            this.panel_controls.TabIndex = 24;
            // 
            // textBox_status
            // 
            this.textBox_status.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.textBox_status.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.textBox_status.BorderColor = System.Drawing.Color.Transparent;
            this.textBox_status.BorderColorScaling = 0.5F;
            this.textBox_status.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_status.ControlBackground = System.Drawing.SystemColors.Control;
            this.textBox_status.Location = new System.Drawing.Point(102, 3);
            this.textBox_status.Multiline = false;
            this.textBox_status.Name = "textBox_status";
            this.textBox_status.ReadOnly = true;
            this.textBox_status.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox_status.SelectionLength = 0;
            this.textBox_status.SelectionStart = 0;
            this.textBox_status.Size = new System.Drawing.Size(167, 20);
            this.textBox_status.TabIndex = 21;
            this.textBox_status.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.toolTip.SetToolTip(this.textBox_status, "Current Status of the trilateration.");
            this.textBox_status.WordWrap = true;
            // 
            // labelstpos
            // 
            this.labelstpos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelstpos.Location = new System.Drawing.Point(3, 5);
            this.labelstpos.Name = "labelstpos";
            this.labelstpos.Size = new System.Drawing.Size(90, 19);
            this.labelstpos.TabIndex = 20;
            this.labelstpos.Text = "Current Status:";
            // 
            // textBoxSystemName
            // 
            this.textBoxSystemName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.textBoxSystemName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.textBoxSystemName.BorderColor = System.Drawing.Color.Transparent;
            this.textBoxSystemName.BorderColorScaling = 0.5F;
            this.textBoxSystemName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSystemName.ControlBackground = System.Drawing.SystemColors.Control;
            this.textBoxSystemName.Location = new System.Drawing.Point(102, 33);
            this.textBoxSystemName.Multiline = false;
            this.textBoxSystemName.Name = "textBoxSystemName";
            this.textBoxSystemName.ReadOnly = true;
            this.textBoxSystemName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxSystemName.SelectionLength = 0;
            this.textBoxSystemName.SelectionStart = 0;
            this.textBoxSystemName.Size = new System.Drawing.Size(178, 20);
            this.textBoxSystemName.TabIndex = 1;
            this.textBoxSystemName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.toolTip.SetToolTip(this.textBoxSystemName, "System to tri-lat to");
            this.textBoxSystemName.WordWrap = true;
            // 
            // textBoxCoordinateX
            // 
            this.textBoxCoordinateX.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.textBoxCoordinateX.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.textBoxCoordinateX.BorderColor = System.Drawing.Color.Transparent;
            this.textBoxCoordinateX.BorderColorScaling = 0.5F;
            this.textBoxCoordinateX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCoordinateX.ControlBackground = System.Drawing.SystemColors.Control;
            this.textBoxCoordinateX.Location = new System.Drawing.Point(165, 63);
            this.textBoxCoordinateX.Multiline = false;
            this.textBoxCoordinateX.Name = "textBoxCoordinateX";
            this.textBoxCoordinateX.ReadOnly = true;
            this.textBoxCoordinateX.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxCoordinateX.SelectionLength = 0;
            this.textBoxCoordinateX.SelectionStart = 0;
            this.textBoxCoordinateX.Size = new System.Drawing.Size(60, 20);
            this.textBoxCoordinateX.TabIndex = 6;
            this.textBoxCoordinateX.Text = "?";
            this.textBoxCoordinateX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip.SetToolTip(this.textBoxCoordinateX, "X Co-ord of system");
            this.textBoxCoordinateX.WordWrap = true;
            // 
            // textBoxCoordinateY
            // 
            this.textBoxCoordinateY.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.textBoxCoordinateY.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.textBoxCoordinateY.BorderColor = System.Drawing.Color.Transparent;
            this.textBoxCoordinateY.BorderColorScaling = 0.5F;
            this.textBoxCoordinateY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCoordinateY.ControlBackground = System.Drawing.SystemColors.Control;
            this.textBoxCoordinateY.Location = new System.Drawing.Point(245, 63);
            this.textBoxCoordinateY.Multiline = false;
            this.textBoxCoordinateY.Name = "textBoxCoordinateY";
            this.textBoxCoordinateY.ReadOnly = true;
            this.textBoxCoordinateY.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxCoordinateY.SelectionLength = 0;
            this.textBoxCoordinateY.SelectionStart = 0;
            this.textBoxCoordinateY.Size = new System.Drawing.Size(60, 20);
            this.textBoxCoordinateY.TabIndex = 8;
            this.textBoxCoordinateY.Text = "?";
            this.textBoxCoordinateY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip.SetToolTip(this.textBoxCoordinateY, "Y Co-ord of system");
            this.textBoxCoordinateY.WordWrap = true;
            // 
            // textBoxCoordinateZ
            // 
            this.textBoxCoordinateZ.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.textBoxCoordinateZ.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.textBoxCoordinateZ.BorderColor = System.Drawing.Color.Transparent;
            this.textBoxCoordinateZ.BorderColorScaling = 0.5F;
            this.textBoxCoordinateZ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCoordinateZ.ControlBackground = System.Drawing.SystemColors.Control;
            this.textBoxCoordinateZ.Location = new System.Drawing.Point(325, 63);
            this.textBoxCoordinateZ.Multiline = false;
            this.textBoxCoordinateZ.Name = "textBoxCoordinateZ";
            this.textBoxCoordinateZ.ReadOnly = true;
            this.textBoxCoordinateZ.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxCoordinateZ.SelectionLength = 0;
            this.textBoxCoordinateZ.SelectionStart = 0;
            this.textBoxCoordinateZ.Size = new System.Drawing.Size(60, 20);
            this.textBoxCoordinateZ.TabIndex = 10;
            this.textBoxCoordinateZ.Text = "?";
            this.textBoxCoordinateZ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip.SetToolTip(this.textBoxCoordinateZ, "Z Co-ord of system");
            this.textBoxCoordinateZ.WordWrap = true;
            // 
            // splitContainerCustom1
            // 
            this.splitContainerCustom1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerCustom1.Location = new System.Drawing.Point(0, 98);
            this.splitContainerCustom1.Name = "splitContainerCustom1";
            // 
            // splitContainerCustom1.Panel1
            // 
            this.splitContainerCustom1.Panel1.Controls.Add(this.splitContainerCustom2);
            // 
            // splitContainerCustom1.Panel2
            // 
            this.splitContainerCustom1.Panel2.Controls.Add(this.dataViewScroller_Wanted);
            this.splitContainerCustom1.Size = new System.Drawing.Size(924, 583);
            this.splitContainerCustom1.SplitterDistance = 500;
            this.splitContainerCustom1.TabIndex = 25;
            // 
            // splitContainerCustom2
            // 
            this.splitContainerCustom2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerCustom2.Location = new System.Drawing.Point(0, 0);
            this.splitContainerCustom2.Name = "splitContainerCustom2";
            this.splitContainerCustom2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerCustom2.Panel1
            // 
            this.splitContainerCustom2.Panel1.Controls.Add(this.dataViewScroller_Distances);
            // 
            // splitContainerCustom2.Panel2
            // 
            this.splitContainerCustom2.Panel2.Controls.Add(this.richTextBox_History);
            this.splitContainerCustom2.Size = new System.Drawing.Size(500, 583);
            this.splitContainerCustom2.SplitterDistance = 354;
            this.splitContainerCustom2.TabIndex = 0;
            // 
            // dataViewScroller_Distances
            // 
            this.dataViewScroller_Distances.Controls.Add(this.vScrollBarCustom1);
            this.dataViewScroller_Distances.Controls.Add(this.dataGridViewDistances);
            this.dataViewScroller_Distances.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataViewScroller_Distances.InternalMargin = new System.Windows.Forms.Padding(0);
            this.dataViewScroller_Distances.Location = new System.Drawing.Point(0, 0);
            this.dataViewScroller_Distances.Name = "dataViewScroller_Distances";
            this.dataViewScroller_Distances.ScrollBarWidth = 20;
            this.dataViewScroller_Distances.Size = new System.Drawing.Size(500, 354);
            this.dataViewScroller_Distances.TabIndex = 0;
            this.dataViewScroller_Distances.VerticalScrollBarDockRight = true;
            // 
            // vScrollBarCustom1
            // 
            this.vScrollBarCustom1.ArrowBorderColor = System.Drawing.Color.LightBlue;
            this.vScrollBarCustom1.ArrowButtonColor = System.Drawing.Color.LightGray;
            this.vScrollBarCustom1.ArrowColorScaling = 0.5F;
            this.vScrollBarCustom1.ArrowDownDrawAngle = 270F;
            this.vScrollBarCustom1.ArrowUpDrawAngle = 90F;
            this.vScrollBarCustom1.BorderColor = System.Drawing.Color.White;
            this.vScrollBarCustom1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.vScrollBarCustom1.HideScrollBar = false;
            this.vScrollBarCustom1.LargeChange = 1;
            this.vScrollBarCustom1.Location = new System.Drawing.Point(480, 21);
            this.vScrollBarCustom1.Maximum = 0;
            this.vScrollBarCustom1.Minimum = 0;
            this.vScrollBarCustom1.MouseOverButtonColor = System.Drawing.Color.Green;
            this.vScrollBarCustom1.MousePressedButtonColor = System.Drawing.Color.Red;
            this.vScrollBarCustom1.Name = "vScrollBarCustom1";
            this.vScrollBarCustom1.Size = new System.Drawing.Size(20, 333);
            this.vScrollBarCustom1.SliderColor = System.Drawing.Color.DarkGray;
            this.vScrollBarCustom1.SmallChange = 1;
            this.vScrollBarCustom1.TabIndex = 1;
            this.vScrollBarCustom1.Text = "vScrollBarCustom1";
            this.vScrollBarCustom1.ThumbBorderColor = System.Drawing.Color.Yellow;
            this.vScrollBarCustom1.ThumbButtonColor = System.Drawing.Color.DarkBlue;
            this.vScrollBarCustom1.ThumbColorScaling = 0.5F;
            this.vScrollBarCustom1.ThumbDrawAngle = 0F;
            this.vScrollBarCustom1.Value = 0;
            this.vScrollBarCustom1.ValueLimited = 0;
            // 
            // dataGridViewDistances
            // 
            this.dataGridViewDistances.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDistances.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnSystem,
            this.ColumnDistance,
            this.ColumnCalculated,
            this.ColumnStatus});
            this.dataGridViewDistances.ContextMenuStrip = this.trilatContextMenu;
            this.dataGridViewDistances.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDistances.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewDistances.Name = "dataGridViewDistances";
            this.dataGridViewDistances.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridViewDistances.Size = new System.Drawing.Size(480, 354);
            this.dataGridViewDistances.TabIndex = 0;
            this.dataGridViewDistances.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDistances_CellClick);
            this.dataGridViewDistances.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDistances_CellEndEdit);
            this.dataGridViewDistances.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDistances_CellLeave);
            this.dataGridViewDistances.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridViewDistances_CellValidating);
            this.dataGridViewDistances.CurrentCellChanged += new System.EventHandler(this.dataGridViewDistances_CurrentCellChanged);
            this.dataGridViewDistances.SortCompare += new System.Windows.Forms.DataGridViewSortCompareEventHandler(this.dataGridViewDistances_SortCompare);
            this.dataGridViewDistances.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridViewDistances_KeyDown);
            // 
            // ColumnSystem
            // 
            this.ColumnSystem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnSystem.FillWeight = 250F;
            this.ColumnSystem.HeaderText = "System";
            this.ColumnSystem.MinimumWidth = 75;
            this.ColumnSystem.Name = "ColumnSystem";
            // 
            // ColumnDistance
            // 
            this.ColumnDistance.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnDistance.HeaderText = "Distance";
            this.ColumnDistance.MinimumWidth = 75;
            this.ColumnDistance.Name = "ColumnDistance";
            // 
            // ColumnCalculated
            // 
            this.ColumnCalculated.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnCalculated.HeaderText = "Calculated";
            this.ColumnCalculated.MinimumWidth = 75;
            this.ColumnCalculated.Name = "ColumnCalculated";
            this.ColumnCalculated.ReadOnly = true;
            this.ColumnCalculated.Visible = false;
            // 
            // ColumnStatus
            // 
            this.ColumnStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnStatus.HeaderText = "Status";
            this.ColumnStatus.MinimumWidth = 75;
            this.ColumnStatus.Name = "ColumnStatus";
            this.ColumnStatus.ReadOnly = true;
            // 
            // richTextBox_History
            // 
            this.richTextBox_History.BorderColor = System.Drawing.Color.Transparent;
            this.richTextBox_History.BorderColorScaling = 0.5F;
            this.richTextBox_History.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox_History.HideScrollBar = true;
            this.richTextBox_History.Location = new System.Drawing.Point(0, 0);
            this.richTextBox_History.Name = "richTextBox_History";
            this.richTextBox_History.ReadOnly = false;
            this.richTextBox_History.ScrollBarArrowBorderColor = System.Drawing.Color.LightBlue;
            this.richTextBox_History.ScrollBarArrowButtonColor = System.Drawing.Color.LightGray;
            this.richTextBox_History.ScrollBarBackColor = System.Drawing.SystemColors.Control;
            this.richTextBox_History.ScrollBarBorderColor = System.Drawing.Color.White;
            this.richTextBox_History.ScrollBarFlatStyle = System.Windows.Forms.FlatStyle.System;
            this.richTextBox_History.ScrollBarForeColor = System.Drawing.SystemColors.ControlText;
            this.richTextBox_History.ScrollBarMouseOverButtonColor = System.Drawing.Color.Green;
            this.richTextBox_History.ScrollBarMousePressedButtonColor = System.Drawing.Color.Red;
            this.richTextBox_History.ScrollBarSliderColor = System.Drawing.Color.DarkGray;
            this.richTextBox_History.ScrollBarThumbBorderColor = System.Drawing.Color.Yellow;
            this.richTextBox_History.ScrollBarThumbButtonColor = System.Drawing.Color.DarkBlue;
            this.richTextBox_History.ScrollBarWidth = 20;
            this.richTextBox_History.ShowLineCount = false;
            this.richTextBox_History.Size = new System.Drawing.Size(500, 225);
            this.richTextBox_History.TabIndex = 0;
            this.richTextBox_History.TextBoxBackColor = System.Drawing.SystemColors.Control;
            this.richTextBox_History.TextBoxForeColor = System.Drawing.SystemColors.ControlText;
            // 
            // dataViewScroller_Wanted
            // 
            this.dataViewScroller_Wanted.Controls.Add(this.vScrollBarCustom2);
            this.dataViewScroller_Wanted.Controls.Add(this.dataGridViewClosestSystems);
            this.dataViewScroller_Wanted.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataViewScroller_Wanted.InternalMargin = new System.Windows.Forms.Padding(0);
            this.dataViewScroller_Wanted.Location = new System.Drawing.Point(0, 0);
            this.dataViewScroller_Wanted.Name = "dataViewScroller_Wanted";
            this.dataViewScroller_Wanted.ScrollBarWidth = 20;
            this.dataViewScroller_Wanted.Size = new System.Drawing.Size(420, 583);
            this.dataViewScroller_Wanted.TabIndex = 0;
            this.dataViewScroller_Wanted.VerticalScrollBarDockRight = true;
            // 
            // vScrollBarCustom2
            // 
            this.vScrollBarCustom2.ArrowBorderColor = System.Drawing.Color.LightBlue;
            this.vScrollBarCustom2.ArrowButtonColor = System.Drawing.Color.LightGray;
            this.vScrollBarCustom2.ArrowColorScaling = 0.5F;
            this.vScrollBarCustom2.ArrowDownDrawAngle = 270F;
            this.vScrollBarCustom2.ArrowUpDrawAngle = 90F;
            this.vScrollBarCustom2.BorderColor = System.Drawing.Color.White;
            this.vScrollBarCustom2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.vScrollBarCustom2.HideScrollBar = false;
            this.vScrollBarCustom2.LargeChange = 0;
            this.vScrollBarCustom2.Location = new System.Drawing.Point(400, 21);
            this.vScrollBarCustom2.Maximum = -1;
            this.vScrollBarCustom2.Minimum = 0;
            this.vScrollBarCustom2.MouseOverButtonColor = System.Drawing.Color.Green;
            this.vScrollBarCustom2.MousePressedButtonColor = System.Drawing.Color.Red;
            this.vScrollBarCustom2.Name = "vScrollBarCustom2";
            this.vScrollBarCustom2.Size = new System.Drawing.Size(20, 562);
            this.vScrollBarCustom2.SliderColor = System.Drawing.Color.DarkGray;
            this.vScrollBarCustom2.SmallChange = 1;
            this.vScrollBarCustom2.TabIndex = 14;
            this.vScrollBarCustom2.Text = "vScrollBarCustom2";
            this.vScrollBarCustom2.ThumbBorderColor = System.Drawing.Color.Yellow;
            this.vScrollBarCustom2.ThumbButtonColor = System.Drawing.Color.DarkBlue;
            this.vScrollBarCustom2.ThumbColorScaling = 0.5F;
            this.vScrollBarCustom2.ThumbDrawAngle = 0F;
            this.vScrollBarCustom2.Value = -1;
            this.vScrollBarCustom2.ValueLimited = -1;
            // 
            // dataGridViewClosestSystems
            // 
            this.dataGridViewClosestSystems.AllowUserToAddRows = false;
            this.dataGridViewClosestSystems.AllowUserToDeleteRows = false;
            this.dataGridViewClosestSystems.AllowUserToResizeRows = false;
            this.dataGridViewClosestSystems.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewClosestSystems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewClosestSystems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClosestSystems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Source,
            this.dataGridViewTextBoxColumnClosestSystemsSystem});
            this.dataGridViewClosestSystems.ContextMenuStrip = this.wantedContextMenu;
            this.dataGridViewClosestSystems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewClosestSystems.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridViewClosestSystems.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewClosestSystems.Name = "dataGridViewClosestSystems";
            this.dataGridViewClosestSystems.ReadOnly = true;
            this.dataGridViewClosestSystems.RowHeadersVisible = false;
            this.dataGridViewClosestSystems.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridViewClosestSystems.Size = new System.Drawing.Size(400, 583);
            this.dataGridViewClosestSystems.TabIndex = 13;
            this.dataGridViewClosestSystems.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewClosestSystems_CellMouseClick);
            // 
            // Source
            // 
            this.Source.HeaderText = "Source";
            this.Source.Name = "Source";
            this.Source.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumnClosestSystemsSystem
            // 
            this.dataGridViewTextBoxColumnClosestSystemsSystem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumnClosestSystemsSystem.HeaderText = "Wanted System";
            this.dataGridViewTextBoxColumnClosestSystemsSystem.MinimumWidth = 100;
            this.dataGridViewTextBoxColumnClosestSystemsSystem.Name = "dataGridViewTextBoxColumnClosestSystemsSystem";
            this.dataGridViewTextBoxColumnClosestSystemsSystem.ReadOnly = true;
            // 
            // TrilaterationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainerCustom1);
            this.Controls.Add(this.panel_controls);
            this.Name = "TrilaterationControl";
            this.Size = new System.Drawing.Size(924, 681);
            this.trilatContextMenu.ResumeLayout(false);
            this.wantedContextMenu.ResumeLayout(false);
            this.panel_controls.ResumeLayout(false);
            this.panel_controls.PerformLayout();
            this.splitContainerCustom1.Panel1.ResumeLayout(false);
            this.splitContainerCustom1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerCustom1)).EndInit();
            this.splitContainerCustom1.ResumeLayout(false);
            this.splitContainerCustom2.Panel1.ResumeLayout(false);
            this.splitContainerCustom2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerCustom2)).EndInit();
            this.splitContainerCustom2.ResumeLayout(false);
            this.dataViewScroller_Distances.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDistances)).EndInit();
            this.dataViewScroller_Wanted.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClosestSystems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ExtendedControls.TextBoxBorder textBoxSystemName;
        private System.Windows.Forms.Label labelTargetSystem;
        private System.Windows.Forms.Label labelCoordinates;
        private ExtendedControls.TextBoxBorder textBoxCoordinateX;
        private System.Windows.Forms.Label labelCoordinateX;
        private System.Windows.Forms.Label labelCoordinateY;
        private ExtendedControls.TextBoxBorder textBoxCoordinateY;
        private System.Windows.Forms.Label labelCoordinateZ;
        private ExtendedControls.TextBoxBorder textBoxCoordinateZ;
        protected System.Windows.Forms.DataGridView dataGridViewDistances;
        private System.Windows.Forms.Panel panel_controls;
        private System.Windows.Forms.Label labelstpos;
        private ExtendedControls.AutoCompleteDGVColumn ColumnSystem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDistance;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCalculated;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStatus;
        private ExtendedControls.TextBoxBorder textBox_status;
        private System.Windows.Forms.ContextMenuStrip trilatContextMenu;
        private System.Windows.Forms.ToolStripMenuItem addToWantedSystemsToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip wantedContextMenu;
        private System.Windows.Forms.ToolStripMenuItem removeFromWantedSystemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewOnEDSMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewOnEDSMToolStripMenuItem1;
        private System.Windows.Forms.DataGridView dataGridViewClosestSystems;
        private System.Windows.Forms.DataGridViewTextBoxColumn Source;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnClosestSystemsSystem;
        private ExtendedControls.SplitContainerCustom splitContainerCustom1;
        private ExtendedControls.SplitContainerCustom splitContainerCustom2;
        private ExtendedControls.RichTextBoxScroll richTextBox_History;
        private ExtendedControls.DataViewScrollerPanel dataViewScroller_Distances;
        private ExtendedControls.DataViewScrollerPanel dataViewScroller_Wanted;
        private ExtendedControls.VScrollBarCustom vScrollBarCustom1;
        private ExtendedControls.VScrollBarCustom vScrollBarCustom2;
        private System.Windows.Forms.ToolStripMenuItem deleteAllWithKnownPositionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAllLocalSystemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAllEDSMSystemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip;
    }
}
