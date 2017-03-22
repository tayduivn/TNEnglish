using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TN.Core.Model
{
    public class Learn
    {
        public int Id { get; set; }
        public int IdUser { get; set; }
        public int No { get; set; }
        public string Word { get; set; }
        public string Mean { get; set; }
        public string WordRemember { get; set; }
        public string Audio { get; set; }
        public string Image { get; set; }
        public int Point { get; set; }
        public int PointWord { get; set; }
        public int Review { get; set; }
        public int NumFail { get; set; }
        public bool Done { get; set; }
        public bool Hight { get; set; }
        public DateTime Date { get; set; }
    }
}
