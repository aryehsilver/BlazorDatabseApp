using System.ComponentModel.DataAnnotations;

namespace BlazorDatabseApp.Models;

public class BasketItem {
  public int ID { get; set; }
	[Required]
	public int Quantity { get; set; }
	public int ProductId { get; set; }
	[Required]
	public Product Product { get; set; }
	[Required]
	public Guid BasketID { get; set; }
	[Required]
  public Basket Basket { get; set; }
}
