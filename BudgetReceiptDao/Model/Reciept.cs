using System;
using System.Runtime.Serialization;

namespace BudgetReceiptDao.Model
{
    /// <summary>Непосредственно сам чек. В разных чеках по разному заполнены параметры.</summary>
    [DataContract]
    class Receipt : IReceipt
    {
        #region Money

        /// <summary>Общая сумма по чеку, в копейках.</summary>
        [DataMember]
        public int TotalSum { get; set; }

        /// <summary>Сумма, оплаченная наличными, в копейках.</summary>
        [DataMember]
        public int CashTotalSum { get; set; }

        /// <summary>Сумма, оплаченная безналичным способом оплаты, в копейках.</summary>
        [DataMember]
        public int EcashTotalSum { get; set; }

        /// <summary>Сумма НДС оплаченная по ставке 18%, в копейках.</summary>
        [DataMember(Name = "nds18")]
        public int TotalNds18Sum { get; set; }

        /// <summary>Сумма НДС оплаченная по ставке 10%, в копейках.</summary>
        [DataMember(Name = "nds10")]
        public int TotalNds10Sum { get; set; }

        #endregion

        #region Cashbox

        /// <summary>Фискальный признак документа, также известный как ФП, ФПД.</summary>
        [DataMember]
        public ulong FiscalSign { get; set; }

        /// <summary>Номер фискального документа.</summary>
        [DataMember]
        public int FiscalDocumentNumber { get; set; }

        /// <summary>Код чека.</summary>
        [DataMember]
        public int ReceiptCode { get; set; }

        /// <summary>.Номер запроса.</summary>
        [DataMember]
        public int RequestNumber { get; set; }

        /// <summary>Фискальный номер.</summary>
        [DataMember(Name = "fiscalDriveNumber")]
        public string FiscalNumber { get; set; }

        /// <summary>Что-то вроде зашифрованной информации о чеке.</summary>
        [DataMember(IsRequired = false)]
        public string RawData { get; set; }

        /// <summary>Номер смены.</summary>
        [DataMember]
        public int ShiftNumber { get; set; }

        /// <summary>Регистрационный номер ККТ.</summary>
        [DataMember]
        public string KktRegId { get; set; }

        #endregion

        #region Store

        /// <summary>ИНН продавца.</summary>
        [DataMember(Name = "userInn")]
        public string RetailInn { get; set; }

        /// <summary>Адрес точки продажи.</summary>
        [DataMember(IsRequired = false)]
        public string RetailPlaceAddress { get; set; }

        /// <summary>Наименование продавца.</summary>
        [DataMember(Name = "user", IsRequired = false)]
        public string StoreName { get; set; }

        /// <summary>Данные кассира, который пробил чек.</summary>
        [DataMember(Name = "operator")]
        public string Cashier { get; set; }

        /// <summary>Адрес электронной почты организации, отправившей информацию по чеку в ФНС.</summary>
        [DataMember(Name = "senderAddress", IsRequired = false)]
        public string SenderEmailAddress { get; set; }

        #endregion

        #region Operation

        /// <summary>Тип операции. Полагаю продажа, покупка и т.д.</summary>
        [DataMember]
        public int OperationType { get; set; }

        /// <summary>Дата совершения операции.</summary>
        [DataMember(Name = "dateTime")]
        public DateTime ReceiptDateTime { get; set; }

        #endregion

        #region Other

        /// <summary>Тип системы налогообложения.</summary>
        [DataMember]
        public int TaxationType { get; set; }

        /// <summary>Не понимаю что это.</summary>
        [DataMember(IsRequired = false)]
        public string StornoItems { get; set; }

        /// <summary>Не понимаю что это.</summary>
        [DataMember(IsRequired = false)]
        public string Modifiers { get; set; }

        /// <summary>Не понимаю что это.</summary>
        [DataMember(IsRequired = false)]
        public string Message { get; set; }

        /// <summary>Не понимаю что это.</summary>
        [DataMember(IsRequired = false)]
        public string Properties { get; set; }

        #endregion
    }
}