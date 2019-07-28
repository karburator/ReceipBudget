using System;

namespace BudgetReceiptDao.Model
{
    /// <summary>Непосредственно сам чек. В разных чеках по разному заполнены параметры.</summary>
    public interface IReceipt
    {
        #region Money

        /// <summary>Общая сумма по чеку, в копейках.</summary>
        int TotalSum { get; set; }

        /// <summary>Сумма, оплаченная наличными, в копейках.</summary>
        int CashTotalSum { get; set; }

        /// <summary>Сумма, оплаченная безналичным способом оплаты, в копейках.</summary>
        int EcashTotalSum { get; set; }

        /// <summary>Сумма НДС оплаченная по ставке 18%, в копейках.</summary>
        int TotalNds18Sum { get; set; }

        /// <summary>Сумма НДС оплаченная по ставке 10%, в копейках.</summary>
        int TotalNds10Sum { get; set; }

        #endregion

        #region Cashbox

        /// <summary>Фискальный признак документа, также известный как ФП, ФПД.</summary>
        ulong FiscalSign { get; set; }

        /// <summary>Номер фискального документа.</summary>
        int FiscalDocumentNumber { get; set; }

        /// <summary>Код чека.</summary>
        int ReceiptCode { get; set; }

        /// <summary>.Номер запроса.</summary>
        int RequestNumber { get; set; }

        /// <summary>Фискальный номер.</summary>
        string FiscalNumber { get; set; }

        /// <summary>Что-то вроде зашифрованной информации о чеке.</summary>
        string RawData { get; set; }

        /// <summary>Номер смены.</summary>
        int ShiftNumber { get; set; }

        /// <summary>Регистрационный номер ККТ.</summary>
        string KktRegId { get; set; }

        #endregion

        #region Store

        /// <summary>ИНН продавца.</summary>
        string RetailInn { get; set; }

        /// <summary>Адрес точки продажи.</summary>
        string RetailPlaceAddress { get; set; }

        /// <summary>Наименование продавца.</summary>
        string StoreName { get; set; }

        /// <summary>Данные кассира, который пробил чек.</summary>
        string Cashier { get; set; }

        /// <summary>Адрес электронной почты организации, отправившей информацию по чеку в ФНС.</summary>
        string SenderEmailAddress { get; set; }

        #endregion

        #region Operation

        /// <summary>Тип операции. Полагаю продажа, покупка и т.д.</summary>
        int OperationType { get; set; }

        /// <summary>Дата совершения операции.</summary>
        DateTime ReceiptDateTime { get; set; }

        #endregion

        #region Other

        /// <summary>Тип системы налогообложения.</summary>
        int TaxationType { get; set; }

        /// <summary>Не понимаю что это.</summary>
        string StornoItems { get; set; }

        /// <summary>Не понимаю что это.</summary>
        string Modifiers { get; set; }

        /// <summary>Не понимаю что это.</summary>
        string Message { get; set; }

        /// <summary>Не понимаю что это.</summary>
        string Properties { get; set; }

        #endregion
    }
}