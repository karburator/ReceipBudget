namespace BudgetReceiptDao.Model
{
    /// <summary>Класс, представляющий позицию в чеке. В разных чеках параметры заполнены по разному.</summary>
    public interface IItem
    {
            int Id { get; set; }
        
            int ReceiptId { get; set; }
        
            /// <summary>Сумма по позиции, в копейках.</summary>
            int Sum { get; set; }

            /// <summary>Количество.</summary>
            double Quantity { get; set; }

            /// <summary>Цена позиции, в копейках.</summary>
            int Price { get; set; }

            /// <summary>Наименование позиции.</summary>
            string Name { get; set; }

            /// <summary>Сумма НДС, оплаченная по ставке 10%, в копейках.</summary>
            int Nds10Sum { get; set; }

            /// <summary>Сумма НДС, оплаченная по ставке 18%, в копейках.</summary>
            int Nds18Sum { get; set; }

            /// <summary>Не понимаю что это.</summary>
            string PropertiesJson { get; set; }

            /// <summary>Не понимаю что это.</summary>
            string ModifiersJson { get; set; }
    }
}