using ADO.NET_Task2.Models.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET_Task2.Models.Concretes
{
    public class Book : BaseEntity
    {
        public string Name { get; set; }
        public int Pages { get; set; }
        public int YearPress { get; set; }
        public int Id_Themes { get; set; }
        public int Id_Author { get; set; }
        public int Id_Category { get; set; }
        public int Id_Press { get; set; }
        public int Quantity { get; set; }
        public string? Comment { get; set; }

        public override string ToString() => $"{Id} {Name} {Pages} {YearPress}";
    }
}
