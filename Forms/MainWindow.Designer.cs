namespace Laboration_2_Ordbehandling
{
	partial class Main_Form
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
			this.NewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.SaveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.CloseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.Rtb_Main = new System.Windows.Forms.RichTextBox();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
			resources.ApplyResources(this.toolStrip1, "toolStrip1");
			this.toolStrip1.Name = "toolStrip1";
			// 
			// toolStripDropDownButton1
			// 
			this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewToolStripMenuItem,
            this.OpenToolStripMenuItem,
            this.SaveToolStripMenuItem,
            this.SaveAsToolStripMenuItem,
            this.CloseToolStripMenuItem});
			resources.ApplyResources(this.toolStripDropDownButton1, "toolStripDropDownButton1");
			this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
			// 
			// NewToolStripMenuItem
			// 
			this.NewToolStripMenuItem.Name = "NewToolStripMenuItem";
			resources.ApplyResources(this.NewToolStripMenuItem, "NewToolStripMenuItem");
			this.NewToolStripMenuItem.Click += new System.EventHandler(this.NewToolStripMenuItem_Click);
			// 
			// OpenToolStripMenuItem
			// 
			this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
			resources.ApplyResources(this.OpenToolStripMenuItem, "OpenToolStripMenuItem");
			this.OpenToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
			// 
			// SaveToolStripMenuItem
			// 
			this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
			resources.ApplyResources(this.SaveToolStripMenuItem, "SaveToolStripMenuItem");
			this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
			// 
			// SaveAsToolStripMenuItem
			// 
			this.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem";
			resources.ApplyResources(this.SaveAsToolStripMenuItem, "SaveAsToolStripMenuItem");
			this.SaveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveAsToolStripMenuItem_Click);
			// 
			// CloseToolStripMenuItem
			// 
			this.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem";
			resources.ApplyResources(this.CloseToolStripMenuItem, "CloseToolStripMenuItem");
			this.CloseToolStripMenuItem.Click += new System.EventHandler(this.CloseToolStripMenuItem_Click);
			// 
			// Rtb_Main
			// 
			resources.ApplyResources(this.Rtb_Main, "Rtb_Main");
			this.Rtb_Main.EnableAutoDragDrop = true;
			this.Rtb_Main.Name = "Rtb_Main";
			this.Rtb_Main.TabStop = false;
			this.Rtb_Main.TextChanged += new System.EventHandler(this.Rtb_Main_TextChanged);
			// 
			// Main_Form
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.Rtb_Main);
			this.Controls.Add(this.toolStrip1);
			this.Name = "Main_Form";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_Form_FormClosing);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
		private System.Windows.Forms.ToolStripMenuItem NewToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem SaveAsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem CloseToolStripMenuItem;
		private System.Windows.Forms.RichTextBox Rtb_Main;
	}
}

