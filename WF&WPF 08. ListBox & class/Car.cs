using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_WPF_08._ListBox___class
{
    internal class Car
    {
        public string? Model { get; set; }
        public string? Marka { get; set; }
        public int Year { get; set; }
        public override string ToString()
        {
            return $"Model: {Model} - Marka: {Marka} - Year: {Year}";
        }
    }

}
