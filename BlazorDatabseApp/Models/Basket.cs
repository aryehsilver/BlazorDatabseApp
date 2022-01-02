namespace BlazorDatabseApp.Models;

public class Basket {
  public Guid ID { get; set; }
  public List<BasketItem> BasketItems { get; set; }
  public DateTime LastUpdated { get; set; } = DateTime.Now;
}
