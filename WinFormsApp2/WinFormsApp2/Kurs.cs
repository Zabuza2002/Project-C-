using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2
{

    public class Kurs
    {
        public string disclaimer { get; set; }
        public string date { get; set; }
        public int timestamp { get; set; }
        public string _base { get; set; }
        public Rates rates { get; set; }
    }

    public class Rates
    {
        public float USD { get; set; }
        public float EUR { get; set; }
        public float CHF { get; set; }
    }

}
