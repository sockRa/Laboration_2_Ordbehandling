namespace Laboration_2_Ordbehandling.Forms
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
			this.NewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.SaveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.CloseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.Rtb_Main = new System.Windows.Forms.RichTextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label_letters_with_space = new System.Windows.Forms.Label();
			this.label_letters_with_no_space = new System.Windows.Forms.Label();
			this.label_number_of_words = new System.Windows.Forms.Label();
			this.label_number_of_rows = new System.Windows.Forms.Label();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.toolStrip1.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
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
			this.Rtb_Main.Name = "Rtb_Main";
			this.Rtb_Main.TabStop = false;
			this.Rtb_Main.DragDrop += new System.Windows.Forms.DragEventHandler(this.Rtb_Main_DragDrop);
			this.Rtb_Main.DragEnter += new System.Windows.Forms.DragEventHandler(this.Rtb_Main_DragEnter);
			this.Rtb_Main.TextChanged += new System.EventHandler(this.Rtb_Main_TextChanged);
			// 
			// label1
			// 
			resources.ApplyResources(this.label1, "label1");
			this.label1.Name = "label1";
			// 
			// label2
			// 
			resources.ApplyResources(this.label2, "label2");
			this.label2.Name = "label2";
			// 
			// label3
			// 
			resources.ApplyResources(this.label3, "label3");
			this.label3.Name = "label3";
			// 
			// label4
			// 
			resources.ApplyResources(this.label4, "label4");
			this.label4.Name = "label4";
			// 
			// label_letters_with_space
			// 
			resources.ApplyResources(this.label_letters_with_space, "label_letters_with_space");
			this.label_letters_with_space.Name = "label_letters_with_space";
			// 
			// label_letters_with_no_space
			// 
			resources.ApplyResources(this.label_letters_with_no_space, "label_letters_with_no_space");
			this.label_letters_with_no_space.Name = "label_letters_with_no_space";
			// 
			// label_number_of_words
			// 
			resources.ApplyResources(this.label_number_of_words, "label_number_of_words");
			this.label_number_of_words.Name = "label_number_of_words";
			// 
			// label_number_of_rows
			// 
			resources.ApplyResources(this.label_number_of_rows, "label_number_of_rows");
			this.label_number_of_rows.Name = "label_number_of_rows";
			// 
			// tableLayoutPanel1
			// 
			resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.label_number_of_rows, 3, 1);
			this.tableLayoutPanel1.Controls.Add(this.label_letters_with_space, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.label4, 2, 1);
			this.tableLayoutPanel1.Controls.Add(this.label_letters_with_no_space, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.label_number_of_words, 3, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			// 
			// MainForm
			// 
			this.AllowDrop = true;
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.Rtb_Main);
			this.Controls.Add(this.toolStrip1);
			this.Name = "MainForm";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_Form_FormClosing);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
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
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label_letters_with_space;
		private System.Windows.Forms.Label label_letters_with_no_space;
		private System.Windows.Forms.Label label_number_of_words;
		private System.Windows.Forms.Label label_number_of_rows;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
	}
}

