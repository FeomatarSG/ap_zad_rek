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
        [MinimumAge(18,ErrorMessage ="Aby skorzystać z portalu musisz mieć ukończone 18 lat.")]
        public DateTime DataUrodzenia { get; set; }
        [Required(ErrorMessage = "Proszę wybrać kolor oczu")]
        public string KolorOczu { get; set; }
        [Required(ErrorMessage = "Proszę wprowadzić swój wzrost")]
        public decimal Wzrost { get; set; }

        public bool Compare(Person woman)
        {
            int i = 0;
            if (Wzrost > woman.Wzrost + 7) i++;
            if (KolorOczu == woman.KolorOczu) i++;
            if ((DataUrodzenia.Year - woman.DataUrodzenia.Year) < 5
                && (DataUrodzenia.Year - woman.DataUrodzenia.Year) > -5
                ) i++;
            if(i>1)
                return true;
            else
                return false;
        }
    }
}