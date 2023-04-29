using Ank_Boost_12_Mvc.CustomValidation;
using System.ComponentModel.DataAnnotations;

namespace Ank_Boost_12_Mvc.Models
{
    public class Musteri
    {

        public int Id { get; set; }
        public string SirketAdi { get; set; } = null!;

        [Required(ErrorMessage = "Müsteri Yasi girilmedi")]

        [AgeValidation]
        public int Yas { get; set; }

        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? GirisTarihi { get; set; }
        public MusteriTuru? Turu { get; set; }
    }
}
