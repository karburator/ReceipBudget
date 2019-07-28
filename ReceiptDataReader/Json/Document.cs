using System.Runtime.Serialization;

namespace ReceiptDataReader.Json
{
    /// <summary>Документ, который приходит из ФНС.</summary>
    [DataContract]
    public class Document
    {
        /// <summary>Внутренняя информация о чеке.</summary>
        [DataMember]
        public Receipt Receipt { get; internal set; }
    }
}