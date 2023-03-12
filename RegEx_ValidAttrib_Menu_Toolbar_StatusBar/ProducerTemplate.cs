using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Winf_FillingObject_File_ShittyValidation
{
    [DataContract]
    public class ProducerTemplate
    {
        [DataMember]
        [Required(ErrorMessage = "Отсутствует название организации")]
        [RegularExpression(@"^[А-Я][a-я\s-]+$", ErrorMessage = "Неверный формат названия организации")]
        public string _organization { get; set; }

        [DataMember]
        [Required(ErrorMessage = "Отсутствует название организации")]
        [RegularExpression(@"^[А-Я][а-я]+( [А-Я][а-я]+)?$", ErrorMessage = "Неверный формат страны")]
        public string _country { get; set; }

        [DataMember]
        [Required(ErrorMessage = "Отсутствует название города")]
        [RegularExpression(@"^[А-Я][а-я]+( [А-Я][а-я]+)?$", ErrorMessage = "Неверный формат города")]
        public string _city { get; set; }

        [DataMember]
        [Required(ErrorMessage = "Отсутствует номер телефона")]
        [RegularExpression(@"^\+\d{1,3}\(\d{1,3}\)\d{7}$", ErrorMessage = "Неверный формат номера телефона")]
        public string _phone { get; set; }

        public ProducerTemplate(string organization, string country, string city, string phone)
        {
            _organization = organization;
            _country = country;
            _city = city;
            _phone = phone;
        }

        public override string ToString()
        {
            return $"==== Поставщик ====\r\n" +
                   $"Организация: {_organization}\r\n" +
                   $"Страна: {_country}\r\n" +
                   $"Город: {_city}\r\n" +
                   $"Телефон: {_phone}.\r\n";
        }
    }
}
