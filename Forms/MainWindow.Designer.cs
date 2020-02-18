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
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(601, 25);
			this.toolStrip1.TabIndex = 0;
			this.toolStrip1.Text = "toolStrip1";
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
			this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
			this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
			this.toolStripDropDownButton1.Size = new System.Drawing.Size(47, 22);
			this.toolStripDropDownButton1.Text = "Arkiv";
			// 
			// NewToolStripMenuItem
			// 
			this.NewToolStripMenuItem.Name = "NewToolStripMenuItem";
			this.NewToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.NewToolStripMenuItem.Text = "Ny";
			this.NewToolStripMenuItem.Click += new System.EventHandler(this.NewToolStripMenuItem_Click);
			// 
			// OpenToolStripMenuItem
			// 
			this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
			this.OpenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.OpenToolStripMenuItem.Text = "Öppna";
			this.OpenToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
			// 
			// SaveToolStripMenuItem
			// 
			this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
			this.SaveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.SaveToolStripMenuItem.Text = "Spara";
			this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
			// 
			// SaveAsToolStripMenuItem
			// 
			this.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem";
			this.SaveAsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.SaveAsToolStripMenuItem.Text = "Spara som...";
			// 
			// CloseToolStripMenuItem
			// 
			this.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem";
			this.CloseToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.CloseToolStripMenuItem.Text = "Stäng";
			// 
			// Rtb_Main
			// 
			this.Rtb_Main.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Rtb_Main.EnableAutoDragDrop = true;
			this.Rtb_Main.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Rtb_Main.Location = new System.Drawing.Point(0, 25);
			this.Rtb_Main.Name = "Rtb_Main";
			this.Rtb_Main.Size = new System.Drawing.Size(601, 464);
			this.Rtb_Main.TabIndex = 2;
			this.Rtb_Main.TabStop = false;
			this.Rtb_Main.Text = "";
			this.Rtb_Main.TextChanged += new System.EventHandler(this.Rtb_Main_TextChanged);
			// 
			// Main_Form
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(601, 489);
			this.Controls.Add(this.Rtb_Main);
			this.Controls.Add(this.toolStrip1);
			this.MinimumSize = new System.Drawing.Size(601, 464);
			this.Name = "Main_Form";
			this.Text = "dok1.txt - NotPad";
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

