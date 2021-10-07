
namespace Revit_Hycal_Userform
{
    partial class Main_From
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menu = new System.Windows.Forms.MenuStrip();
            this.File = new System.Windows.Forms.ToolStripMenuItem();
            this.New = new System.Windows.Forms.ToolStripMenuItem();
            this.Save = new System.Windows.Forms.ToolStripMenuItem();
            this.Open = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.拾取管道ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.二次拾取管道ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Cal = new System.Windows.Forms.ToolStripMenuItem();
            this.Initial = new System.Windows.Forms.ToolStripMenuItem();
            this.WFBasic = new System.Windows.Forms.ToolStripMenuItem();
            this.SCBasic = new System.Windows.Forms.ToolStripMenuItem();
            this.Database = new System.Windows.Forms.ToolStripMenuItem();
            this.About = new System.Windows.Forms.ToolStripMenuItem();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File,
            this.Edit,
            this.Initial,
            this.Database,
            this.About});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1692, 36);
            this.menu.TabIndex = 0;
            // 
            // File
            // 
            this.File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.New,
            this.Save,
            this.Open,
            this.Exit});
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(62, 32);
            this.File.Text = "文件";
            // 
            // New
            // 
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(182, 34);
            this.New.Text = "新建工程";
            // 
            // Save
            // 
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(182, 34);
            this.Save.Text = "保存工程";
            // 
            // Open
            // 
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(182, 34);
            this.Open.Text = "打开工程";
            // 
            // Exit
            // 
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(182, 34);
            this.Exit.Text = "退出程序";
            // 
            // Edit
            // 
            this.Edit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.拾取管道ToolStripMenuItem,
            this.二次拾取管道ToolStripMenuItem,
            this.Cal});
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(62, 32);
            this.Edit.Text = "计算";
            // 
            // 拾取管道ToolStripMenuItem
            // 
            this.拾取管道ToolStripMenuItem.Name = "拾取管道ToolStripMenuItem";
            this.拾取管道ToolStripMenuItem.Size = new System.Drawing.Size(254, 34);
            this.拾取管道ToolStripMenuItem.Text = "拾取管道";
            // 
            // 二次拾取管道ToolStripMenuItem
            // 
            this.二次拾取管道ToolStripMenuItem.Name = "二次拾取管道ToolStripMenuItem";
            this.二次拾取管道ToolStripMenuItem.Size = new System.Drawing.Size(254, 34);
            this.二次拾取管道ToolStripMenuItem.Text = "二次拾取管道";
            // 
            // Cal
            // 
            this.Cal.Name = "Cal";
            this.Cal.Size = new System.Drawing.Size(254, 34);
            this.Cal.Text = "局部阻力系数分析";
            // 
            // Initial
            // 
            this.Initial.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.WFBasic,
            this.SCBasic});
            this.Initial.Name = "Initial";
            this.Initial.Size = new System.Drawing.Size(98, 32);
            this.Initial.Text = "基础配置";
            // 
            // WFBasic
            // 
            this.WFBasic.Name = "WFBasic";
            this.WFBasic.Size = new System.Drawing.Size(290, 34);
            this.WFBasic.Text = "危废风管基本参数设置";
            // 
            // SCBasic
            // 
            this.SCBasic.Name = "SCBasic";
            this.SCBasic.Size = new System.Drawing.Size(290, 34);
            this.SCBasic.Text = "收尘风管基本参数设置";
            // 
            // Database
            // 
            this.Database.Name = "Database";
            this.Database.Size = new System.Drawing.Size(80, 32);
            this.Database.Text = "数据库";
            // 
            // About
            // 
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(62, 32);
            this.About.Text = "关于";
            this.About.Click += new System.EventHandler(this.About_ToolStripMenuItem_Click);
            // 
            // Main_From
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1692, 814);
            this.Controls.Add(this.menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menu;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main_From";
            this.ShowIcon = false;
            this.Text = "风管水力计算及优化";
            this.TopMost = true;
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem File;
        private System.Windows.Forms.ToolStripMenuItem New;
        private System.Windows.Forms.ToolStripMenuItem Save;
        private System.Windows.Forms.ToolStripMenuItem Open;
        private System.Windows.Forms.ToolStripMenuItem Exit;
        private System.Windows.Forms.ToolStripMenuItem Edit;
        private System.Windows.Forms.ToolStripMenuItem About;
        private System.Windows.Forms.ToolStripMenuItem Initial;
        private System.Windows.Forms.ToolStripMenuItem Cal;
        private System.Windows.Forms.ToolStripMenuItem WFBasic;
        private System.Windows.Forms.ToolStripMenuItem Database;
        private System.Windows.Forms.ToolStripMenuItem SCBasic;
        private System.Windows.Forms.DataGridViewTextBoxColumn sigemaDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem 拾取管道ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 二次拾取管道ToolStripMenuItem;
    }
}

