using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        [Required(ErrorMessage = "Отсутствует название товара")]
        [RegularExpression(@"^[А-Я][а-я\s-]+$", ErrorMessage = "Неверный формат названия товара")]
        public string _productName { get; set; }

        [DataMember]
        [Required(ErrorMessage = "Отсутствует инвентарный номер")]
        [inventoryNumberValAtr]
        public string _inventoryNumber { get; set; }

        [DataMember]
        [Required(ErrorMessage = "Отсутствует размер товара")]
        public string _size { get; set; }

        [DataMember]
        [Required(ErrorMessage = "Отсутствует тип товара")]
        public string _type { get; set; }

        [DataMember]
        [Required(ErrorMessage = "Отсутствует вес товара")]
        public string _weight { get; set; }

        [DataMember]
        [Required(ErrorMessage = "Отсутствует дата поступления товара")]
        public DateTime _date { get; set; }

        [DataMember]
        [Required(ErrorMessage = "Отсутствует кол-во товара")]
        public int _amount { get; set; }

        [DataMember]
        [Required(ErrorMessage = "Отсутствует цена товара")]
        [RegularExpression(@"^\d+(\.\d{1,2})?$", ErrorMessage = "Неверный формат цены товара")]
        public string _price { get; set; }

        [DataMember]
        public StoreKeeper _storeKeeper;

        [DataMember]
        [Required(ErrorMessage = "Отсутствует инормация о произодителе")]
        public ProducerTemplate _producer;

        public ShopTemplate(string productName, string inventoryNumber, string size, string type, string weight, DateTime date, int amount, string price)
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
            return $"==== Товар ====\r\n" +
                   $"Название товара: {_productName}\r\n" +
                   $"Инвентарный номер: {_inventoryNumber}\r\n" +
                   $"Размер: {_size}\r\n" +
                   $"Тип: {_type}\r\n" +
                   $"Вес: {_weight}\r\n" +
                   $"Дата поступления: {_date}\r\n" +
                   $"Кол-во: {_amount}\r\n" +
                   $"Цена: {_price}\r\n{ _storeKeeper.ToString()}{_producer.ToString()}\r\n";
        }
    }
}
