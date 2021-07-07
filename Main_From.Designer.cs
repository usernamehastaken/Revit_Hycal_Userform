
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
            this.File_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.New_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Save_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Open_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Edit_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Initial_ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.About_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.sigemaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dPressureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pjDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPressureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataElementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Cal_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DatabaseView_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataElementBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File_ToolStripMenuItem,
            this.Edit_ToolStripMenuItem,
            this.Initial_ToolStripMenuItem1,
            this.About_ToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1128, 25);
            this.menu.TabIndex = 0;
            // 
            // File_ToolStripMenuItem
            // 
            this.File_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.New_ToolStripMenuItem,
            this.Save_ToolStripMenuItem,
            this.Open_ToolStripMenuItem,
            this.Exit_ToolStripMenuItem});
            this.File_ToolStripMenuItem.Name = "File_ToolStripMenuItem";
            this.File_ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.File_ToolStripMenuItem.Text = "文件";
            // 
            // New_ToolStripMenuItem
            // 
            this.New_ToolStripMenuItem.Name = "New_ToolStripMenuItem";
            this.New_ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.New_ToolStripMenuItem.Text = "新建工程";
            // 
            // Save_ToolStripMenuItem
            // 
            this.Save_ToolStripMenuItem.Name = "Save_ToolStripMenuItem";
            this.Save_ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.Save_ToolStripMenuItem.Text = "保存工程";
            // 
            // Open_ToolStripMenuItem
            // 
            this.Open_ToolStripMenuItem.Name = "Open_ToolStripMenuItem";
            this.Open_ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.Open_ToolStripMenuItem.Text = "打开工程";
            this.Open_ToolStripMenuItem.Click += new System.EventHandler(this.Open_ToolStripMenuItem_Click);
            // 
            // Exit_ToolStripMenuItem
            // 
            this.Exit_ToolStripMenuItem.Name = "Exit_ToolStripMenuItem";
            this.Exit_ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.Exit_ToolStripMenuItem.Text = "退出程序";
            // 
            // Edit_ToolStripMenuItem
            // 
            this.Edit_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Cal_ToolStripMenuItem,
            this.DatabaseView_ToolStripMenuItem});
            this.Edit_ToolStripMenuItem.Name = "Edit_ToolStripMenuItem";
            this.Edit_ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.Edit_ToolStripMenuItem.Text = "计算";
            // 
            // Initial_ToolStripMenuItem1
            // 
            this.Initial_ToolStripMenuItem1.Name = "Initial_ToolStripMenuItem1";
            this.Initial_ToolStripMenuItem1.Size = new System.Drawing.Size(68, 21);
            this.Initial_ToolStripMenuItem1.Text = "基础设置";
            // 
            // About_ToolStripMenuItem
            // 
            this.About_ToolStripMenuItem.Name = "About_ToolStripMenuItem";
            this.About_ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.About_ToolStripMenuItem.Text = "关于";
            this.About_ToolStripMenuItem.Click += new System.EventHandler(this.About_ToolStripMenuItem_Click);
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
            // noDataGridViewTextBoxColumn
            // 
            this.noDataGridViewTextBoxColumn.DataPropertyName = "No";
            this.noDataGridViewTextBoxColumn.HeaderText = "序号";
            this.noDataGridViewTextBoxColumn.Name = "noDataGridViewTextBoxColumn";
            this.noDataGridViewTextBoxColumn.Width = 60;
            // 
            // airflowDataGridViewTextBoxColumn
            // 
            this.airflowDataGridViewTextBoxColumn.DataPropertyName = "Airflow";
            this.airflowDataGridViewTextBoxColumn.HeaderText = "风量(m³/h)";
            this.airflowDataGridViewTextBoxColumn.Name = "airflowDataGridViewTextBoxColumn";
            this.airflowDataGridViewTextBoxColumn.Width = 80;
            // 
            // widthDataGridViewTextBoxColumn
            // 
            this.widthDataGridViewTextBoxColumn.DataPropertyName = "Width";
            this.widthDataGridViewTextBoxColumn.HeaderText = "风管宽(mm)";
            this.widthDataGridViewTextBoxColumn.Name = "widthDataGridViewTextBoxColumn";
            this.widthDataGridViewTextBoxColumn.Width = 80;
            // 
            // heightDataGridViewTextBoxColumn
            // 
            this.heightDataGridViewTextBoxColumn.DataPropertyName = "Height";
            this.heightDataGridViewTextBoxColumn.HeaderText = "风管高(mm)";
            this.heightDataGridViewTextBoxColumn.Name = "heightDataGridViewTextBoxColumn";
            this.heightDataGridViewTextBoxColumn.Width = 80;
            // 
            // diameterDataGridViewTextBoxColumn
            // 
            this.diameterDataGridViewTextBoxColumn.DataPropertyName = "Diameter";
            this.diameterDataGridViewTextBoxColumn.HeaderText = "风管直径(mm)";
            this.diameterDataGridViewTextBoxColumn.Name = "diameterDataGridViewTextBoxColumn";
            this.diameterDataGridViewTextBoxColumn.Width = 80;
            // 
            // lengthDataGridViewTextBoxColumn
            // 
            this.lengthDataGridViewTextBoxColumn.DataPropertyName = "Length";
            this.lengthDataGridViewTextBoxColumn.HeaderText = "风管长(mm)";
            this.lengthDataGridViewTextBoxColumn.Name = "lengthDataGridViewTextBoxColumn";
            this.lengthDataGridViewTextBoxColumn.Width = 80;
            // 
            // vDataGridViewTextBoxColumn
            // 
            this.vDataGridViewTextBoxColumn.DataPropertyName = "V";
            this.vDataGridViewTextBoxColumn.HeaderText = "V(m/s)";
            this.vDataGridViewTextBoxColumn.Name = "vDataGridViewTextBoxColumn";
            this.vDataGridViewTextBoxColumn.Width = 80;
            // 
            // rDataGridViewTextBoxColumn
            // 
            this.rDataGridViewTextBoxColumn.DataPropertyName = "R";
            this.rDataGridViewTextBoxColumn.HeaderText = "R(Pa)";
            this.rDataGridViewTextBoxColumn.Name = "rDataGridViewTextBoxColumn";
            this.rDataGridViewTextBoxColumn.Width = 80;
            // 
            // pyDataGridViewTextBoxColumn
            // 
            this.pyDataGridViewTextBoxColumn.DataPropertyName = "Py";
            this.pyDataGridViewTextBoxColumn.HeaderText = "Py(Pa)";
            this.pyDataGridViewTextBoxColumn.Name = "pyDataGridViewTextBoxColumn";
            this.pyDataGridViewTextBoxColumn.Width = 80;
            // 
            // sigemaDataGridViewTextBoxColumn
            // 
            this.sigemaDataGridViewTextBoxColumn.DataPropertyName = "Sigema";
            this.sigemaDataGridViewTextBoxColumn.HeaderText = "Sigema";
            this.sigemaDataGridViewTextBoxColumn.Name = "sigemaDataGridViewTextBoxColumn";
            this.sigemaDataGridViewTextBoxColumn.Width = 80;
            // 
            // dPressureDataGridViewTextBoxColumn
            // 
            this.dPressureDataGridViewTextBoxColumn.DataPropertyName = "DPressure";
            this.dPressureDataGridViewTextBoxColumn.HeaderText = "动压(Pa)";
            this.dPressureDataGridViewTextBoxColumn.Name = "dPressureDataGridViewTextBoxColumn";
            this.dPressureDataGridViewTextBoxColumn.Width = 80;
            // 
            // pjDataGridViewTextBoxColumn
            // 
            this.pjDataGridViewTextBoxColumn.DataPropertyName = "Pj";
            this.pjDataGridViewTextBoxColumn.HeaderText = "Pj(Pa)";
            this.pjDataGridViewTextBoxColumn.Name = "pjDataGridViewTextBoxColumn";
            this.pjDataGridViewTextBoxColumn.Width = 80;
            // 
            // totalPressureDataGridViewTextBoxColumn
            // 
            this.totalPressureDataGridViewTextBoxColumn.DataPropertyName = "TotalPressure";
            this.totalPressureDataGridViewTextBoxColumn.HeaderText = "Py+Pj";
            this.totalPressureDataGridViewTextBoxColumn.Name = "totalPressureDataGridViewTextBoxColumn";
            this.totalPressureDataGridViewTextBoxColumn.Width = 80;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // dataElementBindingSource
            // 
            this.dataElementBindingSource.DataSource = typeof(Revit_Hycal_Userform.DataElement);
            // 
            // Cal_ToolStripMenuItem
            // 
            this.Cal_ToolStripMenuItem.Name = "Cal_ToolStripMenuItem";
            this.Cal_ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.Cal_ToolStripMenuItem.Text = "局部阻力系数分析";
            // 
            // DatabaseView_ToolStripMenuItem
            // 
            this.DatabaseView_ToolStripMenuItem.Name = "DatabaseView_ToolStripMenuItem";
            this.DatabaseView_ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.DatabaseView_ToolStripMenuItem.Text = "数据库查看";
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
        private System.Windows.Forms.ToolStripMenuItem File_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem New_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Save_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Open_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Exit_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Edit_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem About_ToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.BindingSource dataElementBindingSource;
        private System.Windows.Forms.ToolStripMenuItem Initial_ToolStripMenuItem1;
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
        private System.Windows.Forms.ToolStripMenuItem Cal_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DatabaseView_ToolStripMenuItem;
    }
}

