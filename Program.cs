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

    public class userform_Util
    {
        //所有与窗体有关操作的接口都从这出

        public static double doubleGBCCDXZXS;
        public static double doubleGBCCD;
        public static double doubleYDND;
        public static double doubleMD;
        //public static double doubleDQYL;
        //public static double doubleWD;
        //public static double doubleXDSD;
        public static double doubleMDXZ=1;
        public static List<DataElement> dataElements = new List<DataElement>();
        public static double cal_R(double de,double V) /*计算沿程阻力系数 de(当量直径) V(流速)*/
        {
            //y=x+2lg(a + bx);
            //y`=1+2b / (a + bx);
            //y``=-2*b^2/(a+bx)^2
            if (doubleGBCCDXZXS==0)
            {
                throw new Exception("Error: 基础数据未初始化");
                //return 0;
            }
            doubleGBCCD = doubleGBCCDXZXS * doubleGBCCD;
            double a = doubleGBCCD / (3.71 * de);
            double Re = V * de / doubleYDND;
            double b = 2.51 / Re;
            double lanta=0,x=0;/*以0.001步进*/
            while (x+0.01+2*Math.Log10(a+b*(x+0.01))<0)
            {
                x = x + 0.01;
            }
            x = x + 0.005;
            lanta = Math.Pow(1 / x, 2);
            double R=lanta*V*V*doubleMD/de/2*doubleMDXZ;
            return R;
        }
        public static void OpenFile(Main_From main_From)
        {
            IList<DataElement> dataElements = new List<DataElement>();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            //openFileDialog.Filter ="计算文件|*.hy";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                main_From.currentFileName=openFileDialog.FileName;
                using (FileStream fileStream = new FileStream(main_From.currentFileName, FileMode.Open, FileAccess.Read))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    dataElements= (IList<DataElement>) bf.Deserialize(fileStream);
                    main_From.showDataGridView(dataElements);
                } 
            }
            
        }
        public static double cal_de(double a,double b)
        {
            double de;
            de = 2 * a * b / (a + b);
            return de;
        }
        public static double cal_DPressure(double V)
        {
            return doubleMDXZ* doubleMD * V * V / 2;
        }
        public static void cal_MDXZ(double p,double wd)
        {
            doubleMDXZ = 3.47 * p / (273 + wd)/1000/doubleMD;
        }

        public delegate void del_pipeline<T,T1,T2>(T uidoc, T1 doc, out List<T2> ids);
        public event del_pipeline<UIDocument , Document , List<ElementId> > pick;
        public void mypick()
        {
            if (pick!=null)
            {
                pick(a,b,c);
            }
        }

    }
}
