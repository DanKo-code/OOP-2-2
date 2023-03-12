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
    public class StoreKeeper
    {
            [DataMember]
            [Required(ErrorMessage = "Отсутствует ФИО")]
            [RegularExpression(@"^[А-Я][а-я]+ [А-Я]\.[А-Я]$", ErrorMessage = "Неверный формат имени")]
            public string _fullName { get; set; }

            [DataMember]
            [Required(ErrorMessage = "Отсутствует опыт")]
            [Range(0, 50, ErrorMessage = "Диапазон опыта от 0 до 50")]
            public int _experience { get; set; }

            [DataMember]
            [Required(ErrorMessage = "Отсутствует адрес")]
            [RegularExpression(@"^[А-Я][а-я]+(, | )\d+$", ErrorMessage = "Неверный формат адреса")]
            public string _address { get; set; }

            public StoreKeeper(string fullName, int experience, string adress)
            {
                _fullName = fullName;
                _experience = experience;
                _address = adress;
            }

            public override string ToString()
            {
                return $"==== Кладовщик ====\r\n" +
                       $"Имя: {_fullName}\r\n" +
                       $"Опыт работы: {_experience}\r\n" +
                       $"Адрес : {_address}.\r\n";
                       
            }
    }
}
