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
    public partial class MDXZ : Form
    {
        public MDXZ()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userform_Util.doubleMD = 1.197803; /*进入此窗体，自动设置密度为1.2，注意返回窗体重新定义密度*/
            userform_Util.cal_MDXZ(double.Parse(this.DQYL.Text), double.Parse(this.WD.Text));
            this.Dispose();
        }
    }
}
