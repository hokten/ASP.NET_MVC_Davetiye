using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Davetiye.Models
{
    public class DavetiyeCevap
    {
        public string AdSoyad { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public bool? KatilimDurumu { get; set; }

    }
}