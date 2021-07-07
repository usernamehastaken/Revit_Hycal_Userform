using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;
using System.Windows.Forms;

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

    public static class userform_Util
    {
        //public IList<DataElement> returnDataElements()
        //{
        //    IList<DataElement> dataElements = new List<DataElement>();
        //    return dataElements;
        //}

        public static void showDataElements(Main_From main_From)
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
    }
}
