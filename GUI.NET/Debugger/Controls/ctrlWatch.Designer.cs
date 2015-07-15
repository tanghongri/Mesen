﻿namespace Mesen.GUI.Debugger
{
	partial class ctrlWatch
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
			if(disposing && (components != null)) {
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
			System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
			this.lstWatch = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.contextMenuWatch = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.mnuRemoveWatch = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuHexDisplay = new System.Windows.Forms.ToolStripMenuItem();
			this.colLastColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.contextMenuWatch.SuspendLayout();
			this.SuspendLayout();
			// 
			// lstWatch
			// 
			this.lstWatch.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.colLastColumn});
			this.lstWatch.ContextMenuStrip = this.contextMenuWatch;
			this.lstWatch.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lstWatch.FullRowSelect = true;
			this.lstWatch.GridLines = true;
			this.lstWatch.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.lstWatch.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
			this.lstWatch.LabelEdit = true;
			this.lstWatch.Location = new System.Drawing.Point(0, 0);
			this.lstWatch.Name = "lstWatch";
			this.lstWatch.Size = new System.Drawing.Size(378, 112);
			this.lstWatch.TabIndex = 6;
			this.lstWatch.UseCompatibleStateImageBehavior = false;
			this.lstWatch.View = System.Windows.Forms.View.Details;
			this.lstWatch.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.lstWatch_AfterLabelEdit);
			this.lstWatch.SelectedIndexChanged += new System.EventHandler(this.lstWatch_SelectedIndexChanged);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Address";
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Value";
			this.columnHeader2.Width = 100;
			// 
			// contextMenuWatch
			// 
			this.contextMenuWatch.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRemoveWatch,
            this.mnuHexDisplay});
			this.contextMenuWatch.Name = "contextMenuWatch";
			this.contextMenuWatch.Size = new System.Drawing.Size(184, 48);
			// 
			// mnuRemoveWatch
			// 
			this.mnuRemoveWatch.Name = "mnuRemoveWatch";
			this.mnuRemoveWatch.ShortcutKeys = System.Windows.Forms.Keys.Delete;
			this.mnuRemoveWatch.Size = new System.Drawing.Size(183, 22);
			this.mnuRemoveWatch.Text = "Remove";
			this.mnuRemoveWatch.Click += new System.EventHandler(this.mnuRemoveWatch_Click);
			// 
			// mnuHexDisplay
			// 
			this.mnuHexDisplay.Checked = true;
			this.mnuHexDisplay.CheckOnClick = true;
			this.mnuHexDisplay.CheckState = System.Windows.Forms.CheckState.Checked;
			this.mnuHexDisplay.Name = "mnuHexDisplay";
			this.mnuHexDisplay.Size = new System.Drawing.Size(183, 22);
			this.mnuHexDisplay.Text = "Hexadecimal Display";
			this.mnuHexDisplay.Click += new System.EventHandler(this.mnuHexDisplay_Click);
			// 
			// colLastColumn
			// 
			this.colLastColumn.Text = "";
			// 
			// ctrlWatch
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.lstWatch);
			this.Name = "ctrlWatch";
			this.Size = new System.Drawing.Size(378, 112);
			this.contextMenuWatch.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListView lstWatch;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ContextMenuStrip contextMenuWatch;
		private System.Windows.Forms.ToolStripMenuItem mnuRemoveWatch;
		private System.Windows.Forms.ToolStripMenuItem mnuHexDisplay;
		private System.Windows.Forms.ColumnHeader colLastColumn;
	}
}