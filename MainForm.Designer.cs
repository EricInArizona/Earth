namespace ClimateModel
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
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.earthSceneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.MainTextBox = new System.Windows.Forms.TextBox();
      this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.testToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      //
      // menuStrip1
      //
      this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.showToolStripMenuItem,
            this.testToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(715, 28);
      this.menuStrip1.TabIndex = 0;
      this.menuStrip1.Text = "menuStrip1";
      //
      // fileToolStripMenuItem
      //
      this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
      this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
      this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
      this.fileToolStripMenuItem.Text = "&File";
      //
      // exitToolStripMenuItem
      //
      this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
      this.exitToolStripMenuItem.Size = new System.Drawing.Size(108, 26);
      this.exitToolStripMenuItem.Text = "E&xit";
      this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
      //
      // showToolStripMenuItem
      //
      this.showToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.earthSceneToolStripMenuItem});
      this.showToolStripMenuItem.Name = "showToolStripMenuItem";
      this.showToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
      this.showToolStripMenuItem.Text = "&Show";
      //
      // earthSceneToolStripMenuItem
      //
      this.earthSceneToolStripMenuItem.Name = "earthSceneToolStripMenuItem";
      this.earthSceneToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
      this.earthSceneToolStripMenuItem.Text = "&Earth Scene";
      this.earthSceneToolStripMenuItem.Click += new System.EventHandler(this.earthSceneToolStripMenuItem_Click);
      //
      // MainTextBox
      //
      this.MainTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
      this.MainTextBox.Location = new System.Drawing.Point(0, 28);
      this.MainTextBox.Multiline = true;
      this.MainTextBox.Name = "MainTextBox";
      this.MainTextBox.ReadOnly = true;
      this.MainTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.MainTextBox.Size = new System.Drawing.Size(715, 383);
      this.MainTextBox.TabIndex = 1;
      //
      // testToolStripMenuItem
      //
      this.testToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testToolStripMenuItem1});
      this.testToolStripMenuItem.Name = "testToolStripMenuItem";
      this.testToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
      this.testToolStripMenuItem.Text = "&Test";
      //
      // testToolStripMenuItem1
      //
      this.testToolStripMenuItem1.Name = "testToolStripMenuItem1";
      this.testToolStripMenuItem1.Size = new System.Drawing.Size(181, 26);
      this.testToolStripMenuItem1.Text = "&Test";
      this.testToolStripMenuItem1.Click += new System.EventHandler(this.testToolStripMenuItem1_Click);
      //
      // MainForm
      //
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
      this.BackColor = System.Drawing.Color.Black;
      this.ClientSize = new System.Drawing.Size(715, 411);
      this.Controls.Add(this.MainTextBox);
      this.Controls.Add(this.menuStrip1);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
      this.ForeColor = System.Drawing.Color.White;
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "MainForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Climate Model";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem earthSceneToolStripMenuItem;
    private System.Windows.Forms.TextBox MainTextBox;
    private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem1;
  }
}


