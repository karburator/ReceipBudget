using System.Runtime.Serialization;

namespace BudgetReceiptDao.Model
{
    /// <summary>Класс, представляющий позицию в чеке. В разных чеках параметры заполнены по разному.</summary>
    [DataContract]
    class Item : IItem
    {
        public int Id { get; set; }

        public int ReceiptId { get; set; }

        /// <summary>Сумма по позиции, в копейках.</summary>
        [DataMember]
        public int Sum { get; set; }

        /// <summary>Количество.</summary>
        [DataMember]
        public double Quantity { get; set; }

        /// <summary>Цена позиции, в копейках.</summary>
        [DataMember]
        public int Price { get; set; }

        /// <summary>Наименование позиции.</summary>
        [DataMember]
        public string Name { get; set; }

        /// <summary>Сумма НДС, оплаченная по ставке 10%, в копейках.</summary>
        [DataMember(Name = "nds10", IsRequired = false)]
        public int Nds10Sum { get; set; }

        /// <summary>Сумма НДС, оплаченная по ставке 18%, в копейках.</summary>
        [DataMember(Name = "nds18", IsRequired = false)]
        public int Nds18Sum { get; set; }

        /// <summary>Не понимаю что это.</summary>
        [DataMember(IsRequired = false)]
        public string PropertiesJson { get; set; }

        /// <summary>Не понимаю что это.</summary>
        [DataMember(IsRequired = false)]
        public string ModifiersJson { get; set; }
    }
}