using System.Runtime.Serialization;

namespace ReceiptDataReader.Json
{
    /// <summary>
    /// Класс, описывающий информацию, получаемую в результате запроса от ФНС детальной информации по чеку
    /// </summary>
    public sealed class ReceiptResult
    {
        /// <summary>
        /// Информация о документе, которая приходит из ФНС
        /// </summary>
        public Document Document { get; internal set; }

        internal ReceiptResult()
        {
        }
    }

    [DataContract]
    internal class RootObject
    {
        [DataMember] public Document Document { get; internal set; }
    }
}