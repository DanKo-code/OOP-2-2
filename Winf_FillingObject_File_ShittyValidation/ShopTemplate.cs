using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;

namespace Winf_FillingObject_File_ShittyValidation
{
    [DataContract]
    public class ShopTemplate
    {
        [DataMember]
        private string _productName;
        [DataMember]
        private int _inventoryNumber;
        [DataMember]
        private string _size;
        [DataMember]
        private string _type;
        [DataMember]
        private string _weight;
        [DataMember]
        private string _date;
        [DataMember]
        private int _amount;
        [DataMember]
        private int _price;

        [DataMember]
        public StoreKeeper _storeKeeper;
        [DataMember]
        public ProducerTemplate _producer;

        public ShopTemplate(string productName, int inventoryNumber, string size, string type, string weight, string date, int amount, int price)
        {
            _productName = productName;
            _inventoryNumber = inventoryNumber;
            _size = size;
            _type = type;
            _weight = weight;
            _date = date;
            _amount = amount;
            _price = price;
        }

        public override string ToString()
        {
            return $"==== Склад магазина ====\n" +
                   $"Название товара: {_productName}\n" +
                   $"Инвентарный номер: {_inventoryNumber}\n" +
                   $"Размер: {_size}\n" +
                   $"Тип: {_type}.\n" +
                   $"Вес: {_weight} \n" +
                   $"Дата поступления: {_date}\n" +
                   $"Кол-во: {_amount}\n" +
                   $"Цена: {_price}\n{ _storeKeeper.ToString()}{_producer.ToString()} ";
        }
    }
}
