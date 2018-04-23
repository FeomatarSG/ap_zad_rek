using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace APawelec_Nexio_rekrutacja.Models
{
    public class Person
    {
        [Required(ErrorMessage = "Proszę wprowadzić imię")]
        public string Imie { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "Proszę wprowadzić wiek")]
        //[MinimumAge(18,ErrorMessage ="Aby skorzystać z portalu musisz mieć ukończone 18 lat.")]
        public string Wiek { get; set; }
        [Required(ErrorMessage = "Proszę wybrać kolor oczu")]
        public string KoloOczu { get; set; }
        [Required(ErrorMessage = "Proszę wprowadzić swój wzrost")]
        public decimal Wzrost { get; set; }
    }
}