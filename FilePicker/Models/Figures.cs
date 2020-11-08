using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilePicker.Models
{
    public class Figures
    {
        public Figures()
        {

        }

        public Figures(string str1, string str2, int str3, string str4)
        {
            this.Name = str1;
            this.Series = str2;
            this.Year = str3;
            this.Company = str4;
        }

        public string Name { get; set; }
        public string Series { get; set; }
        public int Year { get; set; }
        public string Company { get; set; }
    }
}
