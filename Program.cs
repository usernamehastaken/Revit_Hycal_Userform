using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;
using System.Windows.Forms;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;

namespace Revit_Hycal_Userform
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main_From());
        }

    }
    [Serializable]
    public class userform_Util
    {
        //所有与窗体有关操作的接口都从这出
        //对于一个窗体就是一个工程
        //管道需要一个沿程阻力参数,一个风量参数，管道性质参数放入this，
        //

        public  List<ElementId> elementIds;//保存管道系统id，dataEle的信息由程序读取及计算，局部阻力参数保存到族中
        public  UIDocument uIDocument;
        public  Document document;

        public string pipesystem_name;
        public  double doubleGBCCDXZXS;
        public  double doubleGBCCD;
        public  double doubleYDND;
        public  double doubleMD;
        //public static double doubleDQYL;
        //public static double doubleWD;
        //public static double doubleXDSD;
        public  double doubleMDXZ = 1;
        public  List<DataElement> dataElements = new List<DataElement>();
        public  double cal_R(double de, double V) /*计算沿程阻力系数 de(当量直径) V(流速)*/
        {
            //y=x+2lg(a + bx);
            //y`=1+2b / (a + bx);
            //y``=-2*b^2/(a+bx)^2
            if (this.doubleGBCCDXZXS == 0)
            {
                throw new Exception("Error: 基础数据未初始化");
                //return 0;
            }
            this.doubleGBCCD = this.doubleGBCCDXZXS * this.doubleGBCCD;
            double a = this.doubleGBCCD / (3.71 * de);
            double Re = V * de / this.doubleYDND;
            double b = 2.51 / Re;
            double lanta = 0, x = 0;/*以0.001步进*/
            while (x + 0.01 + 2 * Math.Log10(a + b * (x + 0.01)) < 0)
            {
                x = x + 0.01;
            }
            x = x + 0.005;
            lanta = Math.Pow(1 / x, 2);
            double R = lanta * V * V * this.doubleMD / de / 2 * this.doubleMDXZ;
            return R;
        }
        //public  void OpenFile(Main_From main_From)
        //{
        //    IList<DataElement> dataElements = new List<DataElement>();
        //    OpenFileDialog openFileDialog = new OpenFileDialog();
        //    //openFileDialog.Filter ="计算文件|*.hy";
        //    if (openFileDialog.ShowDialog() == DialogResult.OK)
        //    {
        //        main_From.currentFileName = openFileDialog.FileName;
        //        using (FileStream fileStream = new FileStream(main_From.currentFileName, FileMode.Open, FileAccess.Read))
        //        {
        //            BinaryFormatter bf = new BinaryFormatter();
        //            dataElements = (IList<DataElement>)bf.Deserialize(fileStream);
        //            main_From.showDataGridView(dataElements);
        //        }
        //    }

        //}
        public  double cal_de(double a, double b)
        {
            double de;
            de = 2 * a * b / (a + b);
            return de;
        }
        public  double cal_DPressure( double V)
        {
            return this.doubleMDXZ * this.doubleMD * V * V / 2;
        }
        public  void cal_MDXZ(double p, double wd)
        {
            this.doubleMDXZ = 3.47 * p / (273 + wd) / 1000 / this.doubleMD;
        }

        public delegate void del_pipeline(UIDocument uidoc, Document doc, out List<ElementId> ids);

        public del_pipeline mypick;
    }
}
