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

        public Figures(string name, string series, int year, string company)
        {
            Name = name;
            Series = series;
            Year = year;
            Company = company;
        }

        public string Name { get; set; }
        public string Series { get; set; }
        public int Year { get; set; }
        public string Company { get; set; }
    }
}
