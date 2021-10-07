
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
            this.components = new System.ComponentModel.Container();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.File = new System.Windows.Forms.ToolStripMenuItem();
            this.New = new System.Windows.Forms.ToolStripMenuItem();
            this.Save = new System.Windows.Forms.ToolStripMenuItem();
            this.Open = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.Cal = new System.Windows.Forms.ToolStripMenuItem();
            this.Initial = new System.Windows.Forms.ToolStripMenuItem();
            this.WFBasic = new System.Windows.Forms.ToolStripMenuItem();
            this.SCBasic = new System.Windows.Forms.ToolStripMenuItem();
            this.Database = new System.Windows.Forms.ToolStripMenuItem();
            this.About = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.noDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.airflowDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.widthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diameterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lengthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dPressureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pjDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPressureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataElementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.拾取管道ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.二次拾取管道ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataElementBindingSource)).BeginInit();
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
            this.menu.Size = new System.Drawing.Size(1692, 34);
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
            this.File.Size = new System.Drawing.Size(62, 28);
            this.File.Text = "文件";
            // 
            // New
            // 
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(270, 34);
            this.New.Text = "新建工程";
            // 
            // Save
            // 
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(270, 34);
            this.Save.Text = "保存工程";
            // 
            // Open
            // 
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(270, 34);
            this.Open.Text = "打开工程";
            this.Open.Click += new System.EventHandler(this.Open_ToolStripMenuItem_Click);
            // 
            // Exit
            // 
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(270, 34);
            this.Exit.Text = "退出程序";
            // 
            // Edit
            // 
            this.Edit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.拾取管道ToolStripMenuItem,
            this.二次拾取管道ToolStripMenuItem,
            this.Cal});
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(62, 28);
            this.Edit.Text = "计算";
            // 
            // Cal
            // 
            this.Cal.Name = "Cal";
            this.Cal.Size = new System.Drawing.Size(270, 34);
            this.Cal.Text = "局部阻力系数分析";
            // 
            // Initial
            // 
            this.Initial.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.WFBasic,
            this.SCBasic});
            this.Initial.Name = "Initial";
            this.Initial.Size = new System.Drawing.Size(98, 28);
            this.Initial.Text = "基础配置";
            // 
            // WFBasic
            // 
            this.WFBasic.Name = "WFBasic";
            this.WFBasic.Size = new System.Drawing.Size(290, 34);
            this.WFBasic.Text = "危废风管基本参数设置";
            this.WFBasic.Click += new System.EventHandler(this.WFBasic_Click);
            // 
            // SCBasic
            // 
            this.SCBasic.Name = "SCBasic";
            this.SCBasic.Size = new System.Drawing.Size(290, 34);
            this.SCBasic.Text = "收尘风管基本参数设置";
            this.SCBasic.Click += new System.EventHandler(this.SCBasic_Click);
            // 
            // Database
            // 
            this.Database.Name = "Database";
            this.Database.Size = new System.Drawing.Size(80, 28);
            this.Database.Text = "数据库";
            // 
            // About
            // 
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(62, 28);
            this.About.Text = "关于";
            this.About.Click += new System.EventHandler(this.About_ToolStripMenuItem_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dataGridView.ColumnHeadersHeight = 34;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.noDataGridViewTextBoxColumn,
            this.airflowDataGridViewTextBoxColumn,
            this.widthDataGridViewTextBoxColumn,
            this.heightDataGridViewTextBoxColumn,
            this.diameterDataGridViewTextBoxColumn,
            this.lengthDataGridViewTextBoxColumn,
            this.vDataGridViewTextBoxColumn,
            this.rDataGridViewTextBoxColumn,
            this.pyDataGridViewTextBoxColumn,
            this.dPressureDataGridViewTextBoxColumn,
            this.pjDataGridViewTextBoxColumn,
            this.totalPressureDataGridViewTextBoxColumn,
            this.iDDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.dataElementBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(0, 42);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 62;
            this.dataGridView.RowTemplate.Height = 23;
            this.dataGridView.Size = new System.Drawing.Size(1692, 772);
            this.dataGridView.TabIndex = 1;
            // 
            // noDataGridViewTextBoxColumn
            // 
            this.noDataGridViewTextBoxColumn.DataPropertyName = "No";
            this.noDataGridViewTextBoxColumn.HeaderText = "No";
            this.noDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.noDataGridViewTextBoxColumn.Name = "noDataGridViewTextBoxColumn";
            // 
            // airflowDataGridViewTextBoxColumn
            // 
            this.airflowDataGridViewTextBoxColumn.DataPropertyName = "Airflow";
            this.airflowDataGridViewTextBoxColumn.HeaderText = "Airflow";
            this.airflowDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.airflowDataGridViewTextBoxColumn.Name = "airflowDataGridViewTextBoxColumn";
            // 
            // widthDataGridViewTextBoxColumn
            // 
            this.widthDataGridViewTextBoxColumn.DataPropertyName = "Width";
            this.widthDataGridViewTextBoxColumn.HeaderText = "Width";
            this.widthDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.widthDataGridViewTextBoxColumn.Name = "widthDataGridViewTextBoxColumn";
            // 
            // heightDataGridViewTextBoxColumn
            // 
            this.heightDataGridViewTextBoxColumn.DataPropertyName = "Height";
            this.heightDataGridViewTextBoxColumn.HeaderText = "Height";
            this.heightDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.heightDataGridViewTextBoxColumn.Name = "heightDataGridViewTextBoxColumn";
            // 
            // diameterDataGridViewTextBoxColumn
            // 
            this.diameterDataGridViewTextBoxColumn.DataPropertyName = "Diameter";
            this.diameterDataGridViewTextBoxColumn.HeaderText = "Diameter";
            this.diameterDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.diameterDataGridViewTextBoxColumn.Name = "diameterDataGridViewTextBoxColumn";
            // 
            // lengthDataGridViewTextBoxColumn
            // 
            this.lengthDataGridViewTextBoxColumn.DataPropertyName = "Length";
            this.lengthDataGridViewTextBoxColumn.HeaderText = "Length";
            this.lengthDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.lengthDataGridViewTextBoxColumn.Name = "lengthDataGridViewTextBoxColumn";
            // 
            // vDataGridViewTextBoxColumn
            // 
            this.vDataGridViewTextBoxColumn.DataPropertyName = "V";
            this.vDataGridViewTextBoxColumn.HeaderText = "V";
            this.vDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.vDataGridViewTextBoxColumn.Name = "vDataGridViewTextBoxColumn";
            // 
            // rDataGridViewTextBoxColumn
            // 
            this.rDataGridViewTextBoxColumn.DataPropertyName = "R";
            this.rDataGridViewTextBoxColumn.HeaderText = "R";
            this.rDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.rDataGridViewTextBoxColumn.Name = "rDataGridViewTextBoxColumn";
            // 
            // pyDataGridViewTextBoxColumn
            // 
            this.pyDataGridViewTextBoxColumn.DataPropertyName = "Py";
            this.pyDataGridViewTextBoxColumn.HeaderText = "Py";
            this.pyDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.pyDataGridViewTextBoxColumn.Name = "pyDataGridViewTextBoxColumn";
            // 
            // dPressureDataGridViewTextBoxColumn
            // 
            this.dPressureDataGridViewTextBoxColumn.DataPropertyName = "DPressure";
            this.dPressureDataGridViewTextBoxColumn.HeaderText = "DPressure";
            this.dPressureDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dPressureDataGridViewTextBoxColumn.Name = "dPressureDataGridViewTextBoxColumn";
            // 
            // pjDataGridViewTextBoxColumn
            // 
            this.pjDataGridViewTextBoxColumn.DataPropertyName = "Pj";
            this.pjDataGridViewTextBoxColumn.HeaderText = "Pj";
            this.pjDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.pjDataGridViewTextBoxColumn.Name = "pjDataGridViewTextBoxColumn";
            // 
            // totalPressureDataGridViewTextBoxColumn
            // 
            this.totalPressureDataGridViewTextBoxColumn.DataPropertyName = "TotalPressure";
            this.totalPressureDataGridViewTextBoxColumn.HeaderText = "TotalPressure";
            this.totalPressureDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.totalPressureDataGridViewTextBoxColumn.Name = "totalPressureDataGridViewTextBoxColumn";
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // dataElementBindingSource
            // 
            this.dataElementBindingSource.DataSource = typeof(Revit_Hycal_Userform.DataElement);
            // 
            // 拾取管道ToolStripMenuItem
            // 
            this.拾取管道ToolStripMenuItem.Name = "拾取管道ToolStripMenuItem";
            this.拾取管道ToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.拾取管道ToolStripMenuItem.Text = "拾取管道";
            this.拾取管道ToolStripMenuItem.Click += new System.EventHandler(this.拾取管道ToolStripMenuItem_Click);
            //this.拾取管道ToolStripMenuItem.Click += new System.EventHandler(userform_Util.pick_pipeline);
            // 
            // 二次拾取管道ToolStripMenuItem
            // 
            this.二次拾取管道ToolStripMenuItem.Name = "二次拾取管道ToolStripMenuItem";
            this.二次拾取管道ToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.二次拾取管道ToolStripMenuItem.Text = "二次拾取管道";
            // 
            // Main_From
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1692, 814);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menu;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Main_From";
            this.ShowIcon = false;
            this.Text = "风管水力计算及优化";
            this.TopMost = true;
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataElementBindingSource)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.ToolStripMenuItem Initial;
        private System.Windows.Forms.ToolStripMenuItem Cal;
        private System.Windows.Forms.ToolStripMenuItem WFBasic;
        private System.Windows.Forms.ToolStripMenuItem Database;
        private System.Windows.Forms.ToolStripMenuItem SCBasic;
        private System.Windows.Forms.DataGridViewTextBoxColumn noDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn airflowDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn widthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diameterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lengthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sigemaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dPressureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pjDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPressureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource dataElementBindingSource;
        private System.Windows.Forms.ToolStripMenuItem 拾取管道ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 二次拾取管道ToolStripMenuItem;
    }
}

