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

namespace Revit_Hycal_Userform
{
    public partial class Main_From : Form
    {
        public string currentFileName = "";
        public Main_From()
        {
            //this.Width = this.dataGridView1.Width;
            InitializeComponent();
            //test
            DataElement dataElement = new DataElement();
            dataElement.No = 1;
            dataElement.Airflow = 123456;
            dataElement.ID = "1265454112";
            IList<DataElement> dataElements = new List<DataElement>();
            dataElements.Add(dataElement);
            this.dataGridView.DataSource = dataElements;
            //this.d
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


        private void Open_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userform_Util.showDataElements(this);
        }
        public void showDataGridView(IList<DataElement> dataElements)///只暴露方法
        {
            this.dataGridView.DataSource = dataElements;
        }

        private void WFBasic_Click(object sender, EventArgs e)
        {
            Basic_Initial basic_Initial = new Basic_Initial();
            basic_Initial.ShowDialog();
        }

        private void SCBasic_Click(object sender, EventArgs e)
        {
            Basic_Initial basic_Initial = new Basic_Initial();
            basic_Initial.Text = "收尘风管基本参数设置";
            basic_Initial.ShowDialog();
        }
    }
}
