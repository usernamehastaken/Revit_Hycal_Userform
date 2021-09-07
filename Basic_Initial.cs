using System;
using System.Windows.Forms;

namespace Revit_Hycal_Userform
{
    public partial class Basic_Initial : Form
    {
        public Basic_Initial()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CmdOK_Click(object sender, EventArgs e)
        {
            userform_Util.doubleGBCCDXZXS = double.Parse(this.GBCCDXZXS.Text);
            userform_Util.doubleGBCCD = double.Parse(this.GBCCD.Text)*0.001;
            userform_Util.doubleYDND = double.Parse(this.YDND.Text)*0.000001;
            userform_Util.doubleMD = double.Parse(this.MD.Text);
            //MessageBox.Show(userform_Util.floatMD.ToString());
            //MessageBox.Show(userform_Util.cal_R(0.2, 2).ToString());
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MDXZ mDXZ = new MDXZ();
            mDXZ.Show();
        }
    }
}
