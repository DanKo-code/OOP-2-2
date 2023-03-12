using System;
using System.Collections.Generic;
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
        private string _fullName;
        [DataMember]
        private int _experience;
        [DataMember]
        private string _street;
        [DataMember]
        private int _houseNumber;
        
        public StoreKeeper(string fullName, int experience, string street, int houseNumber)
        {
            _fullName = fullName;
            _experience = experience;
            _street = street;
            _houseNumber = houseNumber;
        }

        public override string ToString()
        {
            return $"==== Кладовщик ====\n" +
                   $"Имя: {_fullName}\n" +
                   $"Опыт работы: {_experience}\n" +
                   $"Улица проживания: {_street}\n" +
                   $"Дом: {_houseNumber}.\n";
        }
    }
}
