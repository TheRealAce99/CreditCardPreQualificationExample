namespace BankWebApp.Models
{
  public class CardModel
  {
    public string CardName { get; set; }

    public string PromotionalMessage { get; set; }

    public decimal? APR { get; set; }

    public string CardImageSrc { get; set; }
  }
}
