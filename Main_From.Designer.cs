
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
            this.dataElementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.noDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.airflowDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.widthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diameterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lengthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sigemaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dPressureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pjDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPressureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataElementBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File,
            this.Edit,
            this.Initial,
            this.Database,
            this.About});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1128, 25);
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
            this.File.Size = new System.Drawing.Size(44, 21);
            this.File.Text = "文件";
            // 
            // New
            // 
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(124, 22);
            this.New.Text = "新建工程";
            // 
            // Save
            // 
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(124, 22);
            this.Save.Text = "保存工程";
            // 
            // Open
            // 
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(124, 22);
            this.Open.Text = "打开工程";
            this.Open.Click += new System.EventHandler(this.Open_ToolStripMenuItem_Click);
            // 
            // Exit
            // 
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(124, 22);
            this.Exit.Text = "退出程序";
            // 
            // Edit
            // 
            this.Edit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Cal});
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(44, 21);
            this.Edit.Text = "计算";
            // 
            // Cal
            // 
            this.Cal.Name = "Cal";
            this.Cal.Size = new System.Drawing.Size(172, 22);
            this.Cal.Text = "局部阻力系数分析";
            // 
            // Initial
            // 
            this.Initial.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.WFBasic,
            this.SCBasic});
            this.Initial.Name = "Initial";
            this.Initial.Size = new System.Drawing.Size(68, 21);
            this.Initial.Text = "基础配置";
            // 
            // WFBasic
            // 
            this.WFBasic.Name = "WFBasic";
            this.WFBasic.Size = new System.Drawing.Size(196, 22);
            this.WFBasic.Text = "危废风管基本参数设置";
            this.WFBasic.Click += new System.EventHandler(this.WFBasic_Click);
            // 
            // SCBasic
            // 
            this.SCBasic.Name = "SCBasic";
            this.SCBasic.Size = new System.Drawing.Size(196, 22);
            this.SCBasic.Text = "收尘风管基本参数设置";
            this.SCBasic.Click += new System.EventHandler(this.SCBasic_Click);
            // 
            // Database
            // 
            this.Database.Name = "Database";
            this.Database.Size = new System.Drawing.Size(56, 21);
            this.Database.Text = "数据库";
            // 
            // About
            // 
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(44, 21);
            this.About.Text = "关于";
            this.About.Click += new System.EventHandler(this.About_ToolStripMenuItem_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
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
            this.sigemaDataGridViewTextBoxColumn,
            this.dPressureDataGridViewTextBoxColumn,
            this.pjDataGridViewTextBoxColumn,
            this.totalPressureDataGridViewTextBoxColumn,
            this.iDDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.dataElementBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(0, 28);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 23;
            this.dataGridView.Size = new System.Drawing.Size(1128, 515);
            this.dataGridView.TabIndex = 1;
            // 
            // dataElementBindingSource
            // 
            this.dataElementBindingSource.DataSource = typeof(Revit_Hycal_Userform.DataElement);
            // 
            // noDataGridViewTextBoxColumn
            // 
            this.noDataGridViewTextBoxColumn.DataPropertyName = "No";
            this.noDataGridViewTextBoxColumn.HeaderText = "No";
            this.noDataGridViewTextBoxColumn.Name = "noDataGridViewTextBoxColumn";
            this.noDataGridViewTextBoxColumn.Width = 60;
            // 
            // airflowDataGridViewTextBoxColumn
            // 
            this.airflowDataGridViewTextBoxColumn.DataPropertyName = "Airflow";
            this.airflowDataGridViewTextBoxColumn.HeaderText = "Airflow";
            this.airflowDataGridViewTextBoxColumn.Name = "airflowDataGridViewTextBoxColumn";
            // 
            // widthDataGridViewTextBoxColumn
            // 
            this.widthDataGridViewTextBoxColumn.DataPropertyName = "Width";
            this.widthDataGridViewTextBoxColumn.HeaderText = "Width";
            this.widthDataGridViewTextBoxColumn.Name = "widthDataGridViewTextBoxColumn";
            // 
            // heightDataGridViewTextBoxColumn
            // 
            this.heightDataGridViewTextBoxColumn.DataPropertyName = "Height";
            this.heightDataGridViewTextBoxColumn.HeaderText = "Height";
            this.heightDataGridViewTextBoxColumn.Name = "heightDataGridViewTextBoxColumn";
            // 
            // diameterDataGridViewTextBoxColumn
            // 
            this.diameterDataGridViewTextBoxColumn.DataPropertyName = "Diameter";
            this.diameterDataGridViewTextBoxColumn.HeaderText = "Diameter";
            this.diameterDataGridViewTextBoxColumn.Name = "diameterDataGridViewTextBoxColumn";
            // 
            // lengthDataGridViewTextBoxColumn
            // 
            this.lengthDataGridViewTextBoxColumn.DataPropertyName = "Length";
            this.lengthDataGridViewTextBoxColumn.HeaderText = "Length";
            this.lengthDataGridViewTextBoxColumn.Name = "lengthDataGridViewTextBoxColumn";
            // 
            // vDataGridViewTextBoxColumn
            // 
            this.vDataGridViewTextBoxColumn.DataPropertyName = "V";
            this.vDataGridViewTextBoxColumn.HeaderText = "V";
            this.vDataGridViewTextBoxColumn.Name = "vDataGridViewTextBoxColumn";
            // 
            // rDataGridViewTextBoxColumn
            // 
            this.rDataGridViewTextBoxColumn.DataPropertyName = "R";
            this.rDataGridViewTextBoxColumn.HeaderText = "R";
            this.rDataGridViewTextBoxColumn.Name = "rDataGridViewTextBoxColumn";
            // 
            // pyDataGridViewTextBoxColumn
            // 
            this.pyDataGridViewTextBoxColumn.DataPropertyName = "Py";
            this.pyDataGridViewTextBoxColumn.HeaderText = "Py";
            this.pyDataGridViewTextBoxColumn.Name = "pyDataGridViewTextBoxColumn";
            // 
            // sigemaDataGridViewTextBoxColumn
            // 
            this.sigemaDataGridViewTextBoxColumn.DataPropertyName = "Sigema";
            this.sigemaDataGridViewTextBoxColumn.HeaderText = "Sigema";
            this.sigemaDataGridViewTextBoxColumn.Name = "sigemaDataGridViewTextBoxColumn";
            // 
            // dPressureDataGridViewTextBoxColumn
            // 
            this.dPressureDataGridViewTextBoxColumn.DataPropertyName = "DPressure";
            this.dPressureDataGridViewTextBoxColumn.HeaderText = "DPressure";
            this.dPressureDataGridViewTextBoxColumn.Name = "dPressureDataGridViewTextBoxColumn";
            // 
            // pjDataGridViewTextBoxColumn
            // 
            this.pjDataGridViewTextBoxColumn.DataPropertyName = "Pj";
            this.pjDataGridViewTextBoxColumn.HeaderText = "Pj";
            this.pjDataGridViewTextBoxColumn.Name = "pjDataGridViewTextBoxColumn";
            // 
            // totalPressureDataGridViewTextBoxColumn
            // 
            this.totalPressureDataGridViewTextBoxColumn.DataPropertyName = "TotalPressure";
            this.totalPressureDataGridViewTextBoxColumn.HeaderText = "TotalPressure";
            this.totalPressureDataGridViewTextBoxColumn.Name = "totalPressureDataGridViewTextBoxColumn";
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // Main_From
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1128, 543);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menu;
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
    }
}

