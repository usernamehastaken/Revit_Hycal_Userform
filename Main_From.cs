using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Revit_Hycal_Userform
{
    public partial class Main_From : Form
    {
        public Main_From()
        {
            //this.Width = this.dataGridView1.Width;
            InitializeComponent();
        }

        public void Show_About()
        {
            About about = new About();
            about.ShowDialog();
        }

        private void About_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show_About();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
