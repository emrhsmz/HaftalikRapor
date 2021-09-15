using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HaftalikRapor.Models
{
    public class Reports
    {
        [Key]
        public int Id { get; set; }
        [Display(Name ="Ay")]
        public string Month { get; set; }
        [Display(Name = "Hafta")]
        public int Week { get; set; }
        [Display(Name = "Çağrı Adedi")]
        public int Interaction { get; set; }
        [Display(Name = "Karşılama Oranı")]
        public string Rate { get; set; }
        [Display(Name = "Yıl")]
        public int Year { get; set; }
    }
}