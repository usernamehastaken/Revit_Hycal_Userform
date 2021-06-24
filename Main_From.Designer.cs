
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
            this.File_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.New_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Save_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Open_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Edit_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Cal_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DatabaseView_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.About_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Airflow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Width = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Height = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diameter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Length = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.V = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.R = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Py = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sigema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DPressure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPressure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File_ToolStripMenuItem,
            this.Edit_ToolStripMenuItem,
            this.About_ToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1123, 25);
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
            this.Edit_ToolStripMenuItem.Text = "编辑";
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
            // About_ToolStripMenuItem
            // 
            this.About_ToolStripMenuItem.Name = "About_ToolStripMenuItem";
            this.About_ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.About_ToolStripMenuItem.Text = "关于";
            this.About_ToolStripMenuItem.Click += new System.EventHandler(this.About_ToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.Airflow,
            this.Width,
            this.Height,
            this.Diameter,
            this.Length,
            this.V,
            this.R,
            this.Py,
            this.Sigema,
            this.DPressure,
            this.Pj,
            this.TotalPressure,
            this.ID});
            this.dataGridView1.Location = new System.Drawing.Point(0, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1123, 494);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // No
            // 
            this.No.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.No.HeaderText = "序号";
            this.No.Name = "No";
            this.No.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.No.Width = 60;
            // 
            // Airflow
            // 
            this.Airflow.HeaderText = "风量(m³/h)";
            this.Airflow.Name = "Airflow";
            this.Airflow.Width = 80;
            // 
            // Width
            // 
            this.Width.HeaderText = "风管宽(mm)";
            this.Width.Name = "Width";
            this.Width.Width = 80;
            // 
            // Height
            // 
            this.Height.HeaderText = "风管高(mm)";
            this.Height.Name = "Height";
            this.Height.Width = 80;
            // 
            // Diameter
            // 
            this.Diameter.HeaderText = "直径(mm)";
            this.Diameter.Name = "Diameter";
            this.Diameter.Width = 80;
            // 
            // Length
            // 
            this.Length.HeaderText = "管长(m)";
            this.Length.Name = "Length";
            this.Length.Width = 80;
            // 
            // V
            // 
            this.V.HeaderText = "v(m/s)";
            this.V.Name = "V";
            this.V.Width = 80;
            // 
            // R
            // 
            this.R.HeaderText = "R(Pa/m)";
            this.R.Name = "R";
            this.R.ReadOnly = true;
            this.R.Width = 80;
            // 
            // Py
            // 
            this.Py.HeaderText = "Py(Pa)";
            this.Py.Name = "Py";
            this.Py.ReadOnly = true;
            this.Py.Width = 80;
            // 
            // Sigema
            // 
            this.Sigema.HeaderText = "ξ";
            this.Sigema.Name = "Sigema";
            this.Sigema.Width = 60;
            // 
            // DPressure
            // 
            this.DPressure.HeaderText = "动压(Pa)";
            this.DPressure.Name = "DPressure";
            this.DPressure.ReadOnly = true;
            this.DPressure.Width = 80;
            // 
            // Pj
            // 
            this.Pj.HeaderText = "Pj(Pa)";
            this.Pj.Name = "Pj";
            this.Pj.ReadOnly = true;
            this.Pj.Width = 80;
            // 
            // TotalPressure
            // 
            this.TotalPressure.HeaderText = "Py+Pj(Pa)";
            this.TotalPressure.Name = "TotalPressure";
            this.TotalPressure.ReadOnly = true;
            this.TotalPressure.Width = 80;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Main_From
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1123, 522);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menu;
            this.Name = "Main_From";
            this.ShowIcon = false;
            this.Text = "风管水力计算及优化";
            this.TopMost = true;
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem Cal_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DatabaseView_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem About_ToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Airflow;
        private System.Windows.Forms.DataGridViewTextBoxColumn Width;
        private System.Windows.Forms.DataGridViewTextBoxColumn Height;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diameter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Length;
        private System.Windows.Forms.DataGridViewTextBoxColumn V;
        private System.Windows.Forms.DataGridViewTextBoxColumn R;
        private System.Windows.Forms.DataGridViewTextBoxColumn Py;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sigema;
        private System.Windows.Forms.DataGridViewTextBoxColumn DPressure;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pj;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPressure;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
    }
}

