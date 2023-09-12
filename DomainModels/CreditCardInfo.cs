namespace DomainModels
{
    public class CreditCardInfo
    {
        public int Id { get; set; }
        public string NameOnCard { get; set; }
        public int CardNumber { get; set; }
        public DateTime ExpirationDate { get; set; }
    }
}
