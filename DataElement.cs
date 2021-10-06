using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revit_Hycal_Userform
{
    [Serializable] //注意类的定义及使用
    public class DataElement
    {
        public int No { get; set; }
        public float Airflow { get; set; } = 0;
        public float Width { get; set; } = 0;
        public float Height { get; set; } = 0;
        public float Diameter { get; set; } = 0;
        public float Length { get; set; } = 0;
        public float V { get; set; } = 0;
        public float R { get; set; } = 0;
        public float Py { get; set; } = 0;
        public float kSai { get; set; } = 0;
        public float DPressure { get; set; } = 0;
        public float Pj { get; set; } = 0;
        public float TotalPressure { get; set; } = 0;
        public string ID { get; set; }
    }
}
