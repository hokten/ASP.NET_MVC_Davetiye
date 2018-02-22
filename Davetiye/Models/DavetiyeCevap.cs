using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace Davetiye.Models
{
    public class DavetiyeCevap
    {
        [Required(ErrorMessage ="Adınızı ve soyadınız girmediniz")]
        public string AdSoyad { get; set; }
        [Required(ErrorMessage ="Email adresinizi girmediniz")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage ="Geçersiz bir email adresi girdiniz.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Telefon numaranızı girmediniz")]
        public string Telefon { get; set; }
        [Required(ErrorMessage = "Katılım durumunuzu girmediniz")]
        public bool? KatilimDurumu { get; set; }

    }
}