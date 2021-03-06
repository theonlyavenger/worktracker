﻿using System.Drawing;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace MaterialSkinExample
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.endmyday = new MaterialSkin.Controls.MaterialFlatButton();
            this.starymyday = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            this.txtWork = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.materialListView1 = new MaterialSkin.Controls.MaterialListView();
            this.date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.start = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.work = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.end = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.searchlabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.lblwork = new MaterialSkin.Controls.MaterialLabel();
            this.ok = new MaterialSkin.Controls.MaterialFlatButton();
            this.cancel = new MaterialSkin.Controls.MaterialFlatButton();
            this.tbedit = new System.Windows.Forms.TextBox();
            this.edit = new MaterialSkin.Controls.MaterialFlatButton();
            this.searchlabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.endTime = new MaterialSkin.Controls.MaterialLabel();
            this.searchlabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.startTime = new MaterialSkin.Controls.MaterialLabel();
            this.searchlabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel13 = new MaterialSkin.Controls.MaterialLabel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.hours = new MaterialSkin.Controls.MaterialLabel();
            this.retroentry = new System.Windows.Forms.TabPage();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.retroAdd = new MaterialSkin.Controls.MaterialRaisedButton();
            this.tbwork = new System.Windows.Forms.TextBox();
            this.materialLabel17 = new MaterialSkin.Controls.MaterialLabel();
            this.tbend = new System.Windows.Forms.TextBox();
            this.materialLabel16 = new MaterialSkin.Controls.MaterialLabel();
            this.tbstart = new System.Windows.Forms.TextBox();
            this.materialLabel15 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel14 = new MaterialSkin.Controls.MaterialLabel();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.grey = new System.Windows.Forms.RadioButton();
            this.green = new System.Windows.Forms.RadioButton();
            this.blue = new System.Windows.Forms.RadioButton();
            this.darkmode = new MaterialSkin.Controls.MaterialCheckBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialContextMenuStrip1 = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.item1ToolStripMenuItem = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.subItem1ToolStripMenuItem = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.subItem2ToolStripMenuItem = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.disabledItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.item2ToolStripMenuItem = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.item3ToolStripMenuItem = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.addworkhistory = new MaterialSkin.Controls.MaterialFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.currenttime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.statusdialogue = new MaterialSkin.Controls.MaterialLabel();
            this.status = new MaterialSkin.Controls.MaterialLabel();
            this.refresh = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.retroentry.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.materialContextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // endmyday
            // 
            this.endmyday.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.endmyday.AutoSize = true;
            this.endmyday.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.endmyday.Cursor = System.Windows.Forms.Cursors.Hand;
            this.endmyday.Depth = 0;
            this.endmyday.Icon = null;
            this.endmyday.Location = new System.Drawing.Point(400, 440);
            this.endmyday.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.endmyday.MouseState = MaterialSkin.MouseState.HOVER;
            this.endmyday.Name = "endmyday";
            this.endmyday.Primary = false;
            this.endmyday.Size = new System.Drawing.Size(154, 36);
            this.endmyday.TabIndex = 13;
            this.endmyday.Text = "END MY DAY\'S WORK";
            this.endmyday.UseVisualStyleBackColor = true;
            this.endmyday.Click += new System.EventHandler(this.endmyday_Click);
            // 
            // starymyday
            // 
            this.starymyday.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.starymyday.AutoSize = true;
            this.starymyday.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.starymyday.Cursor = System.Windows.Forms.Cursors.Hand;
            this.starymyday.Depth = 0;
            this.starymyday.Icon = null;
            this.starymyday.Location = new System.Drawing.Point(24, 440);
            this.starymyday.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.starymyday.MouseState = MaterialSkin.MouseState.HOVER;
            this.starymyday.Name = "starymyday";
            this.starymyday.Primary = true;
            this.starymyday.Size = new System.Drawing.Size(170, 36);
            this.starymyday.TabIndex = 1;
            this.starymyday.Text = "START MY DAY\'S WORK";
            this.starymyday.UseVisualStyleBackColor = true;
            this.starymyday.Click += new System.EventHandler(this.starymyday_Click);
            // 
            // materialDivider1
            // 
            this.materialDivider1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(0, 434);
            this.materialDivider1.Margin = new System.Windows.Forms.Padding(0);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(681, 1);
            this.materialDivider1.TabIndex = 16;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 64);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(681, 48);
            this.materialTabSelector1.TabIndex = 17;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Controls.Add(this.tabPage3);
            this.materialTabControl1.Controls.Add(this.retroentry);
            this.materialTabControl1.Controls.Add(this.tabPage4);
            this.materialTabControl1.Controls.Add(this.tabPage5);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(14, 112);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(647, 284);
            this.materialTabControl1.TabIndex = 18;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.materialLabel12);
            this.tabPage1.Controls.Add(this.txtWork);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(639, 258);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Work Done";
            // 
            // materialLabel12
            // 
            this.materialLabel12.AutoSize = true;
            this.materialLabel12.Depth = 0;
            this.materialLabel12.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel12.Location = new System.Drawing.Point(93, 13);
            this.materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel12.Name = "materialLabel12";
            this.materialLabel12.Size = new System.Drawing.Size(417, 19);
            this.materialLabel12.TabIndex = 23;
            this.materialLabel12.Text = "ENTER WHAT WORK YOU\'VE DONE / WILL BE DOING TODAY";
            // 
            // txtWork
            // 
            this.txtWork.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWork.Location = new System.Drawing.Point(6, 45);
            this.txtWork.Multiline = true;
            this.txtWork.Name = "txtWork";
            this.txtWork.Size = new System.Drawing.Size(626, 203);
            this.txtWork.TabIndex = 22;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.materialListView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(639, 258);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Display";
            // 
            // materialListView1
            // 
            this.materialListView1.AllowColumnReorder = true;
            this.materialListView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.date,
            this.start,
            this.work,
            this.end});
            this.materialListView1.Depth = 0;
            this.materialListView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.materialListView1.FullRowSelect = true;
            this.materialListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.materialListView1.Location = new System.Drawing.Point(6, 6);
            this.materialListView1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialListView1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialListView1.Name = "materialListView1";
            this.materialListView1.OwnerDraw = true;
            this.materialListView1.Size = new System.Drawing.Size(626, 247);
            this.materialListView1.TabIndex = 0;
            this.materialListView1.TileSize = new System.Drawing.Size(200, 150);
            this.materialListView1.UseCompatibleStateImageBehavior = false;
            this.materialListView1.View = System.Windows.Forms.View.Details;
            // 
            // date
            // 
            this.date.Text = "Date";
            this.date.Width = 100;
            // 
            // start
            // 
            this.start.Text = "Start";
            this.start.Width = 108;
            // 
            // work
            // 
            this.work.Text = "Work";
            this.work.Width = 288;
            // 
            // end
            // 
            this.end.Text = "End";
            this.end.Width = 113;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.searchlabel4);
            this.tabPage3.Controls.Add(this.lblwork);
            this.tabPage3.Controls.Add(this.ok);
            this.tabPage3.Controls.Add(this.cancel);
            this.tabPage3.Controls.Add(this.tbedit);
            this.tabPage3.Controls.Add(this.edit);
            this.tabPage3.Controls.Add(this.searchlabel3);
            this.tabPage3.Controls.Add(this.endTime);
            this.tabPage3.Controls.Add(this.searchlabel2);
            this.tabPage3.Controls.Add(this.startTime);
            this.tabPage3.Controls.Add(this.searchlabel1);
            this.tabPage3.Controls.Add(this.materialLabel13);
            this.tabPage3.Controls.Add(this.dateTimePicker1);
            this.tabPage3.Controls.Add(this.hours);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(639, 258);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Search";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // searchlabel4
            // 
            this.searchlabel4.AutoSize = true;
            this.searchlabel4.Depth = 0;
            this.searchlabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.searchlabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.searchlabel4.Location = new System.Drawing.Point(432, 64);
            this.searchlabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.searchlabel4.Name = "searchlabel4";
            this.searchlabel4.Size = new System.Drawing.Size(109, 19);
            this.searchlabel4.TabIndex = 23;
            this.searchlabel4.Text = "Working Hours";
            // 
            // lblwork
            // 
            this.lblwork.AutoSize = true;
            this.lblwork.Depth = 0;
            this.lblwork.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblwork.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblwork.Location = new System.Drawing.Point(8, 144);
            this.lblwork.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblwork.Name = "lblwork";
            this.lblwork.Size = new System.Drawing.Size(0, 19);
            this.lblwork.TabIndex = 22;
            // 
            // ok
            // 
            this.ok.AutoSize = true;
            this.ok.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ok.Depth = 0;
            this.ok.Icon = null;
            this.ok.Location = new System.Drawing.Point(568, 144);
            this.ok.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ok.MouseState = MaterialSkin.MouseState.HOVER;
            this.ok.Name = "ok";
            this.ok.Primary = false;
            this.ok.Size = new System.Drawing.Size(39, 36);
            this.ok.TabIndex = 9;
            this.ok.Text = "OK";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // cancel
            // 
            this.cancel.AutoSize = true;
            this.cancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cancel.Depth = 0;
            this.cancel.Icon = null;
            this.cancel.Location = new System.Drawing.Point(568, 184);
            this.cancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.cancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.cancel.Name = "cancel";
            this.cancel.Primary = false;
            this.cancel.Size = new System.Drawing.Size(73, 36);
            this.cancel.TabIndex = 8;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // tbedit
            // 
            this.tbedit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbedit.Location = new System.Drawing.Point(8, 144);
            this.tbedit.Multiline = true;
            this.tbedit.Name = "tbedit";
            this.tbedit.Size = new System.Drawing.Size(560, 32);
            this.tbedit.TabIndex = 6;
            // 
            // edit
            // 
            this.edit.AutoSize = true;
            this.edit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.edit.Depth = 0;
            this.edit.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.edit.Icon = null;
            this.edit.Location = new System.Drawing.Point(568, 144);
            this.edit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.edit.MouseState = MaterialSkin.MouseState.HOVER;
            this.edit.Name = "edit";
            this.edit.Primary = false;
            this.edit.Size = new System.Drawing.Size(50, 36);
            this.edit.TabIndex = 7;
            this.edit.Text = "EDIT";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // searchlabel3
            // 
            this.searchlabel3.AutoSize = true;
            this.searchlabel3.Depth = 0;
            this.searchlabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.searchlabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.searchlabel3.Location = new System.Drawing.Point(8, 112);
            this.searchlabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.searchlabel3.Name = "searchlabel3";
            this.searchlabel3.Size = new System.Drawing.Size(277, 19);
            this.searchlabel3.TabIndex = 5;
            this.searchlabel3.Text = "You have completed the following tasks";
            // 
            // endTime
            // 
            this.endTime.AutoSize = true;
            this.endTime.Depth = 0;
            this.endTime.Font = new System.Drawing.Font("Roboto", 11F);
            this.endTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.endTime.Location = new System.Drawing.Point(304, 64);
            this.endTime.MouseState = MaterialSkin.MouseState.HOVER;
            this.endTime.Name = "endTime";
            this.endTime.Size = new System.Drawing.Size(83, 19);
            this.endTime.TabIndex = 3;
            this.endTime.Text = "HH:MM:SS";
            // 
            // searchlabel2
            // 
            this.searchlabel2.AutoSize = true;
            this.searchlabel2.Depth = 0;
            this.searchlabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.searchlabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.searchlabel2.Location = new System.Drawing.Point(224, 64);
            this.searchlabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.searchlabel2.Name = "searchlabel2";
            this.searchlabel2.Size = new System.Drawing.Size(76, 19);
            this.searchlabel2.TabIndex = 3;
            this.searchlabel2.Text = "End Time:";
            // 
            // startTime
            // 
            this.startTime.AutoSize = true;
            this.startTime.Depth = 0;
            this.startTime.Font = new System.Drawing.Font("Roboto", 11F);
            this.startTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.startTime.Location = new System.Drawing.Point(96, 64);
            this.startTime.MouseState = MaterialSkin.MouseState.HOVER;
            this.startTime.Name = "startTime";
            this.startTime.Size = new System.Drawing.Size(83, 19);
            this.startTime.TabIndex = 2;
            this.startTime.Text = "HH:MM:SS";
            // 
            // searchlabel1
            // 
            this.searchlabel1.AutoSize = true;
            this.searchlabel1.Depth = 0;
            this.searchlabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.searchlabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.searchlabel1.Location = new System.Drawing.Point(16, 64);
            this.searchlabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.searchlabel1.Name = "searchlabel1";
            this.searchlabel1.Size = new System.Drawing.Size(87, 19);
            this.searchlabel1.TabIndex = 2;
            this.searchlabel1.Text = "Start Time: ";
            // 
            // materialLabel13
            // 
            this.materialLabel13.AutoSize = true;
            this.materialLabel13.Depth = 0;
            this.materialLabel13.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel13.Location = new System.Drawing.Point(136, 16);
            this.materialLabel13.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel13.Name = "materialLabel13";
            this.materialLabel13.Size = new System.Drawing.Size(220, 19);
            this.materialLabel13.TabIndex = 1;
            this.materialLabel13.Text = "SEARCH WORK FOR DONE ON :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimePicker1.CustomFormat = "dd-MMM-yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(362, 14);
            this.dateTimePicker1.MinDate = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(112, 20);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // hours
            // 
            this.hours.AutoSize = true;
            this.hours.Depth = 0;
            this.hours.Font = new System.Drawing.Font("Roboto", 11F);
            this.hours.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.hours.Location = new System.Drawing.Point(544, 64);
            this.hours.MouseState = MaterialSkin.MouseState.HOVER;
            this.hours.Name = "hours";
            this.hours.Size = new System.Drawing.Size(37, 19);
            this.hours.TabIndex = 10;
            this.hours.Text = "H:M";
            // 
            // retroentry
            // 
            this.retroentry.Controls.Add(this.dtpDate);
            this.retroentry.Controls.Add(this.retroAdd);
            this.retroentry.Controls.Add(this.tbwork);
            this.retroentry.Controls.Add(this.materialLabel17);
            this.retroentry.Controls.Add(this.tbend);
            this.retroentry.Controls.Add(this.materialLabel16);
            this.retroentry.Controls.Add(this.tbstart);
            this.retroentry.Controls.Add(this.materialLabel15);
            this.retroentry.Controls.Add(this.materialLabel14);
            this.retroentry.Location = new System.Drawing.Point(4, 22);
            this.retroentry.Name = "retroentry";
            this.retroentry.Padding = new System.Windows.Forms.Padding(3);
            this.retroentry.Size = new System.Drawing.Size(639, 258);
            this.retroentry.TabIndex = 5;
            this.retroentry.Text = "Retro Entry";
            this.retroentry.UseVisualStyleBackColor = true;
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "dd-MMM-yyyy";
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(72, 16);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(112, 20);
            this.dtpDate.TabIndex = 4;
            // 
            // retroAdd
            // 
            this.retroAdd.AutoSize = true;
            this.retroAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.retroAdd.Depth = 0;
            this.retroAdd.Icon = null;
            this.retroAdd.Location = new System.Drawing.Point(264, 208);
            this.retroAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.retroAdd.Name = "retroAdd";
            this.retroAdd.Primary = true;
            this.retroAdd.Size = new System.Drawing.Size(94, 36);
            this.retroAdd.TabIndex = 3;
            this.retroAdd.Text = "Add Entry";
            this.retroAdd.UseVisualStyleBackColor = true;
            this.retroAdd.Click += new System.EventHandler(this.retroAdd_Click);
            // 
            // tbwork
            // 
            this.tbwork.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbwork.Location = new System.Drawing.Point(24, 80);
            this.tbwork.Multiline = true;
            this.tbwork.Name = "tbwork";
            this.tbwork.Size = new System.Drawing.Size(592, 120);
            this.tbwork.TabIndex = 2;
            // 
            // materialLabel17
            // 
            this.materialLabel17.AutoSize = true;
            this.materialLabel17.Depth = 0;
            this.materialLabel17.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel17.Location = new System.Drawing.Point(24, 56);
            this.materialLabel17.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel17.Name = "materialLabel17";
            this.materialLabel17.Size = new System.Drawing.Size(83, 19);
            this.materialLabel17.TabIndex = 1;
            this.materialLabel17.Text = "Work Done";
            // 
            // tbend
            // 
            this.tbend.Location = new System.Drawing.Point(512, 16);
            this.tbend.Name = "tbend";
            this.tbend.Size = new System.Drawing.Size(104, 20);
            this.tbend.TabIndex = 2;
            // 
            // materialLabel16
            // 
            this.materialLabel16.AutoSize = true;
            this.materialLabel16.Depth = 0;
            this.materialLabel16.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel16.Location = new System.Drawing.Point(456, 8);
            this.materialLabel16.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel16.Name = "materialLabel16";
            this.materialLabel16.Size = new System.Drawing.Size(43, 38);
            this.materialLabel16.TabIndex = 1;
            this.materialLabel16.Text = "End\r\nTime";
            // 
            // tbstart
            // 
            this.tbstart.Location = new System.Drawing.Point(296, 16);
            this.tbstart.Name = "tbstart";
            this.tbstart.Size = new System.Drawing.Size(104, 20);
            this.tbstart.TabIndex = 2;
            // 
            // materialLabel15
            // 
            this.materialLabel15.AutoSize = true;
            this.materialLabel15.Depth = 0;
            this.materialLabel15.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel15.Location = new System.Drawing.Point(240, 8);
            this.materialLabel15.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel15.Name = "materialLabel15";
            this.materialLabel15.Size = new System.Drawing.Size(43, 38);
            this.materialLabel15.TabIndex = 1;
            this.materialLabel15.Text = "Start\r\nTime";
            // 
            // materialLabel14
            // 
            this.materialLabel14.AutoSize = true;
            this.materialLabel14.Depth = 0;
            this.materialLabel14.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel14.Location = new System.Drawing.Point(24, 16);
            this.materialLabel14.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel14.Name = "materialLabel14";
            this.materialLabel14.Size = new System.Drawing.Size(40, 19);
            this.materialLabel14.TabIndex = 1;
            this.materialLabel14.Text = "Date";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.materialLabel9);
            this.tabPage4.Controls.Add(this.materialLabel8);
            this.tabPage4.Controls.Add(this.materialLabel2);
            this.tabPage4.Controls.Add(this.materialLabel1);
            this.tabPage4.Controls.Add(this.grey);
            this.tabPage4.Controls.Add(this.green);
            this.tabPage4.Controls.Add(this.blue);
            this.tabPage4.Controls.Add(this.darkmode);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(639, 258);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Settings";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel9.Location = new System.Drawing.Point(51, 70);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(130, 19);
            this.materialLabel9.TabIndex = 29;
            this.materialLabel9.Text = "COLOR SCHEMES";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(75, 196);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(46, 19);
            this.materialLabel8.TabIndex = 28;
            this.materialLabel8.Text = "GREY";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(75, 148);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(57, 19);
            this.materialLabel2.TabIndex = 28;
            this.materialLabel2.Text = "GREEN";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(75, 102);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(45, 19);
            this.materialLabel1.TabIndex = 28;
            this.materialLabel1.Text = "BLUE";
            // 
            // grey
            // 
            this.grey.AutoSize = true;
            this.grey.Location = new System.Drawing.Point(55, 202);
            this.grey.Name = "grey";
            this.grey.Size = new System.Drawing.Size(14, 13);
            this.grey.TabIndex = 27;
            this.grey.UseVisualStyleBackColor = true;
            this.grey.CheckedChanged += new System.EventHandler(this.grey_CheckedChanged);
            // 
            // green
            // 
            this.green.AutoSize = true;
            this.green.Location = new System.Drawing.Point(55, 152);
            this.green.Name = "green";
            this.green.Size = new System.Drawing.Size(14, 13);
            this.green.TabIndex = 26;
            this.green.UseVisualStyleBackColor = true;
            this.green.CheckedChanged += new System.EventHandler(this.green_CheckedChanged);
            // 
            // blue
            // 
            this.blue.AutoSize = true;
            this.blue.Checked = true;
            this.blue.Location = new System.Drawing.Point(55, 106);
            this.blue.Name = "blue";
            this.blue.Size = new System.Drawing.Size(14, 13);
            this.blue.TabIndex = 25;
            this.blue.TabStop = true;
            this.blue.UseVisualStyleBackColor = true;
            this.blue.CheckedChanged += new System.EventHandler(this.blue_CheckedChanged);
            // 
            // darkmode
            // 
            this.darkmode.AutoSize = true;
            this.darkmode.Depth = 0;
            this.darkmode.Font = new System.Drawing.Font("Roboto", 10F);
            this.darkmode.Location = new System.Drawing.Point(47, 22);
            this.darkmode.Margin = new System.Windows.Forms.Padding(0);
            this.darkmode.MouseLocation = new System.Drawing.Point(-1, -1);
            this.darkmode.MouseState = MaterialSkin.MouseState.HOVER;
            this.darkmode.Name = "darkmode";
            this.darkmode.Ripple = true;
            this.darkmode.Size = new System.Drawing.Size(107, 30);
            this.darkmode.TabIndex = 24;
            this.darkmode.Text = "DARK MODE";
            this.darkmode.UseVisualStyleBackColor = true;
            this.darkmode.CheckedChanged += new System.EventHandler(this.darkmode_CheckedChanged);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.materialLabel7);
            this.tabPage5.Controls.Add(this.materialLabel6);
            this.tabPage5.Controls.Add(this.materialLabel10);
            this.tabPage5.Controls.Add(this.materialLabel11);
            this.tabPage5.Controls.Add(this.materialLabel3);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(639, 258);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "About";
            this.tabPage5.UseVisualStyleBackColor = true;
            
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(264, 168);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(116, 19);
            this.materialLabel7.TabIndex = 24;
            this.materialLabel7.Text = "RADHIKA PATIL";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(248, 139);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(146, 19);
            this.materialLabel6.TabIndex = 26;
            this.materialLabel6.Text = "MANOJ JAHGIRDAR";
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel10.Location = new System.Drawing.Point(264, 56);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.materialLabel10.Size = new System.Drawing.Size(119, 19);
            this.materialLabel10.TabIndex = 28;
            this.materialLabel10.Text = "WORK TRACKER";
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel11.Location = new System.Drawing.Point(296, 75);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(43, 19);
            this.materialLabel11.TabIndex = 28;
            this.materialLabel11.Text = "V 2.5";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(275, 105);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(84, 19);
            this.materialLabel3.TabIndex = 28;
            this.materialLabel3.Text = "Developers";
            // 
            // materialContextMenuStrip1
            // 
            this.materialContextMenuStrip1.BackColor = System.Drawing.Color.White;
            this.materialContextMenuStrip1.Depth = 0;
            this.materialContextMenuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.item1ToolStripMenuItem,
            this.disabledItemToolStripMenuItem,
            this.item2ToolStripMenuItem,
            this.toolStripSeparator1,
            this.item3ToolStripMenuItem});
            this.materialContextMenuStrip1.Margin = new System.Windows.Forms.Padding(16, 8, 16, 8);
            this.materialContextMenuStrip1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialContextMenuStrip1.Name = "materialContextMenuStrip1";
            this.materialContextMenuStrip1.Size = new System.Drawing.Size(166, 130);
            // 
            // item1ToolStripMenuItem
            // 
            this.item1ToolStripMenuItem.AutoSize = false;
            this.item1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subItem1ToolStripMenuItem,
            this.subItem2ToolStripMenuItem});
            this.item1ToolStripMenuItem.Name = "item1ToolStripMenuItem";
            this.item1ToolStripMenuItem.Size = new System.Drawing.Size(170, 30);
            this.item1ToolStripMenuItem.Text = "Item 1";
            // 
            // subItem1ToolStripMenuItem
            // 
            this.subItem1ToolStripMenuItem.AutoSize = false;
            this.subItem1ToolStripMenuItem.Name = "subItem1ToolStripMenuItem";
            this.subItem1ToolStripMenuItem.Size = new System.Drawing.Size(152, 30);
            this.subItem1ToolStripMenuItem.Text = "SubItem 1";
            // 
            // subItem2ToolStripMenuItem
            // 
            this.subItem2ToolStripMenuItem.AutoSize = false;
            this.subItem2ToolStripMenuItem.Name = "subItem2ToolStripMenuItem";
            this.subItem2ToolStripMenuItem.Size = new System.Drawing.Size(152, 30);
            this.subItem2ToolStripMenuItem.Text = "SubItem 2";
            // 
            // disabledItemToolStripMenuItem
            // 
            this.disabledItemToolStripMenuItem.AutoSize = false;
            this.disabledItemToolStripMenuItem.Enabled = false;
            this.disabledItemToolStripMenuItem.Name = "disabledItemToolStripMenuItem";
            this.disabledItemToolStripMenuItem.Size = new System.Drawing.Size(170, 30);
            this.disabledItemToolStripMenuItem.Text = "Disabled item";
            // 
            // item2ToolStripMenuItem
            // 
            this.item2ToolStripMenuItem.AutoSize = false;
            this.item2ToolStripMenuItem.Name = "item2ToolStripMenuItem";
            this.item2ToolStripMenuItem.Size = new System.Drawing.Size(170, 30);
            this.item2ToolStripMenuItem.Text = "Item 2";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(162, 6);
            // 
            // item3ToolStripMenuItem
            // 
            this.item3ToolStripMenuItem.AutoSize = false;
            this.item3ToolStripMenuItem.Name = "item3ToolStripMenuItem";
            this.item3ToolStripMenuItem.Size = new System.Drawing.Size(170, 30);
            this.item3ToolStripMenuItem.Text = "Item 3";
            // 
            // addworkhistory
            // 
            this.addworkhistory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addworkhistory.AutoSize = true;
            this.addworkhistory.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addworkhistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addworkhistory.Depth = 0;
            this.addworkhistory.Icon = null;
            this.addworkhistory.Location = new System.Drawing.Point(224, 440);
            this.addworkhistory.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.addworkhistory.MouseState = MaterialSkin.MouseState.HOVER;
            this.addworkhistory.Name = "addworkhistory";
            this.addworkhistory.Primary = false;
            this.addworkhistory.Size = new System.Drawing.Size(150, 36);
            this.addworkhistory.TabIndex = 13;
            this.addworkhistory.Text = "ADD WORK HISTORY";
            this.addworkhistory.UseVisualStyleBackColor = true;
            this.addworkhistory.Click += new System.EventHandler(this.addworkhistory_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(400, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 18);
            this.label1.TabIndex = 19;
            this.label1.Text = "CURRENT TIME : ";
            // 
            // currenttime
            // 
            this.currenttime.AutoSize = true;
            this.currenttime.BackColor = System.Drawing.Color.Transparent;
            this.currenttime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currenttime.ForeColor = System.Drawing.Color.White;
            this.currenttime.Location = new System.Drawing.Point(544, 32);
            this.currenttime.Name = "currenttime";
            this.currenttime.Size = new System.Drawing.Size(126, 18);
            this.currenttime.TabIndex = 20;
            this.currenttime.Text = "PLEASE WAIT..";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // statusdialogue
            // 
            this.statusdialogue.AutoSize = true;
            this.statusdialogue.Depth = 0;
            this.statusdialogue.Font = new System.Drawing.Font("Roboto", 11F);
            this.statusdialogue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.statusdialogue.Location = new System.Drawing.Point(25, 405);
            this.statusdialogue.MouseState = MaterialSkin.MouseState.HOVER;
            this.statusdialogue.Name = "statusdialogue";
            this.statusdialogue.Size = new System.Drawing.Size(77, 19);
            this.statusdialogue.TabIndex = 21;
            this.statusdialogue.Text = "STATUS : ";
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Depth = 0;
            this.status.Font = new System.Drawing.Font("Roboto", 11F);
            this.status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.status.Location = new System.Drawing.Point(99, 405);
            this.status.MouseState = MaterialSkin.MouseState.HOVER;
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(196, 19);
            this.status.TabIndex = 21;
            this.status.Text = "Your Status will appear here";
            // 
            // refresh
            // 
            this.refresh.AutoSize = true;
            this.refresh.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.refresh.Cursor = System.Windows.Forms.Cursors.Default;
            this.refresh.Depth = 0;
            this.refresh.Icon = null;
            this.refresh.Location = new System.Drawing.Point(576, 440);
            this.refresh.MouseState = MaterialSkin.MouseState.HOVER;
            this.refresh.Name = "refresh";
            this.refresh.Primary = true;
            this.refresh.Size = new System.Drawing.Size(79, 36);
            this.refresh.TabIndex = 1;
            this.refresh.Text = "Refresh";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(673, 484);
            this.ContextMenuStrip = this.materialContextMenuStrip1;
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.status);
            this.Controls.Add(this.statusdialogue);
            this.Controls.Add(this.currenttime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addworkhistory);
            this.Controls.Add(this.endmyday);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.starymyday);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "WORK TRACKER";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.retroentry.ResumeLayout(false);
            this.retroentry.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.materialContextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialFlatButton starymyday;
        private MaterialFlatButton endmyday;
        private MaterialDivider materialDivider1;
        private MaterialTabSelector materialTabSelector1;
        private MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private MaterialContextMenuStrip materialContextMenuStrip1;
        private MaterialSkin.Controls.MaterialToolStripMenuItem item1ToolStripMenuItem;
        private MaterialSkin.Controls.MaterialToolStripMenuItem subItem1ToolStripMenuItem;
        private MaterialSkin.Controls.MaterialToolStripMenuItem subItem2ToolStripMenuItem;
        private MaterialSkin.Controls.MaterialToolStripMenuItem item2ToolStripMenuItem;
        private MaterialSkin.Controls.MaterialToolStripMenuItem item3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem disabledItemToolStripMenuItem;
        private TextBox txtWork;
        private ColumnHeader date;
        private ColumnHeader start;
        private ColumnHeader work;
        private ColumnHeader end;
        private TabPage tabPage3;
        private MaterialListView materialListView1;
        private TabPage tabPage4;
        private DateTimePicker dateTimePicker1;
        private MaterialCheckBox darkmode;
        private MaterialLabel materialLabel8;
        private MaterialLabel materialLabel2;
        private MaterialLabel materialLabel1;
        private RadioButton blue;
        private RadioButton green;
        private RadioButton grey;
        private MaterialLabel materialLabel9;
        private TabPage tabPage5;
        private MaterialLabel materialLabel11;
        private MaterialLabel materialLabel3;
        private MaterialLabel materialLabel6;
        private MaterialLabel materialLabel7;
        private MaterialLabel materialLabel10;
        private MaterialLabel materialLabel12;
        private MaterialLabel materialLabel13;
        private MaterialFlatButton addworkhistory;
        private Label label1;
        private Label currenttime;
        private Timer timer1;
        private Timer timer2;
        private MaterialLabel statusdialogue;
        private MaterialLabel status;
        private MaterialRaisedButton refresh;
        private MaterialLabel endTime;
        private MaterialLabel searchlabel2;
        private MaterialLabel startTime;
        private MaterialLabel searchlabel1;
        private MaterialLabel searchlabel3;
        private TabPage retroentry;
        private MaterialRaisedButton retroAdd;
        private TextBox tbwork;
        private MaterialLabel materialLabel17;
        private TextBox tbend;
        private MaterialLabel materialLabel16;
        private TextBox tbstart;
        private MaterialLabel materialLabel15;
        private MaterialLabel materialLabel14;
        private TextBox tbedit;
        private MaterialFlatButton edit;
        private MaterialFlatButton cancel;
        private MaterialFlatButton ok;
        private DateTimePicker dtpDate;
        private MaterialLabel hours;
        private MaterialLabel lblwork;
        private MaterialLabel searchlabel4;
    }
}