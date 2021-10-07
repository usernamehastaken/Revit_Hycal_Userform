using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;

namespace Revit_Hycal_Userform
{
    public partial class Main_From : System.Windows.Forms.Form
    {
        public Main_From()
        {
            //this.Width = this.dataGridView1.Width;
            InitializeComponent();
            DataGridView dataGridView = new DataGridView();
            this.components.Add(dataGridView);
        }
        #region//关于窗体，不用修改
        public void Show_About()
        {
            About about = new About();
            about.ShowDialog();
        }

        private void About_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show_About();
        }
        #endregion

    }
}
