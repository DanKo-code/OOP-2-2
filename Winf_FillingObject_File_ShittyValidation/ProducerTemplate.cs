using System;
using System.Collections.Generic;
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
        private string _organization;
        [DataMember]
        private string _country;
        [DataMember]
        private string _city;
        [DataMember]
        private string _phone;

        public ProducerTemplate(string organization, string country, string city, string phone)
        {
            _organization = organization;
            _country = country;
            _city = city;
            _phone = phone;
        }

        public override string ToString()
        {
            return $"==== Поставщик ====\n" +
                   $"Организация: {_organization}\n" +
                   $"Страна: {_country}\n" +
                   $"Город: {_city}\n" +
                   $"Телефон: {_phone}.\n";
        }
    }
}
