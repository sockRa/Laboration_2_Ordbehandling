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
			this.nuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.öppnaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sparaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sparaSomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.stängToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.Rtb_Main = new System.Windows.Forms.RichTextBox();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(800, 25);
			this.toolStrip1.TabIndex = 0;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStripDropDownButton1
			// 
			this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuToolStripMenuItem,
            this.öppnaToolStripMenuItem,
            this.sparaToolStripMenuItem,
            this.sparaSomToolStripMenuItem,
            this.stängToolStripMenuItem});
			this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
			this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
			this.toolStripDropDownButton1.Size = new System.Drawing.Size(47, 22);
			this.toolStripDropDownButton1.Text = "Arkiv";
			// 
			// nuToolStripMenuItem
			// 
			this.nuToolStripMenuItem.Name = "nuToolStripMenuItem";
			this.nuToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
			this.nuToolStripMenuItem.Text = "Ny";
			// 
			// öppnaToolStripMenuItem
			// 
			this.öppnaToolStripMenuItem.Name = "öppnaToolStripMenuItem";
			this.öppnaToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
			this.öppnaToolStripMenuItem.Text = "Öppna";
			// 
			// sparaToolStripMenuItem
			// 
			this.sparaToolStripMenuItem.Name = "sparaToolStripMenuItem";
			this.sparaToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
			this.sparaToolStripMenuItem.Text = "Spara";
			// 
			// sparaSomToolStripMenuItem
			// 
			this.sparaSomToolStripMenuItem.Name = "sparaSomToolStripMenuItem";
			this.sparaSomToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
			this.sparaSomToolStripMenuItem.Text = "Spara som...";
			// 
			// stängToolStripMenuItem
			// 
			this.stängToolStripMenuItem.Name = "stängToolStripMenuItem";
			this.stängToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
			this.stängToolStripMenuItem.Text = "Stäng";
			// 
			// Rtb_Main
			// 
			this.Rtb_Main.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Rtb_Main.EnableAutoDragDrop = true;
			this.Rtb_Main.Location = new System.Drawing.Point(0, 25);
			this.Rtb_Main.Name = "Rtb_Main";
			this.Rtb_Main.Size = new System.Drawing.Size(800, 742);
			this.Rtb_Main.TabIndex = 2;
			this.Rtb_Main.TabStop = false;
			this.Rtb_Main.Text = "";
			this.Rtb_Main.TextChanged += new System.EventHandler(this.Rtb_Main_TextChanged);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// Main_Form
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 767);
			this.Controls.Add(this.Rtb_Main);
			this.Controls.Add(this.toolStrip1);
			this.Name = "Main_Form";
			this.Text = "dok1.txt";
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
		private System.Windows.Forms.ToolStripMenuItem nuToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem öppnaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem sparaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem sparaSomToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem stängToolStripMenuItem;
		private System.Windows.Forms.RichTextBox Rtb_Main;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
	}
}

