using BlazorLeBonCoin.DTOs;

namespace BlazorLeBonCoin.DTOs;

public class ArticleRequestDTO
{
    public DateTime Date { get; set; }
    public int CategoryId { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public int UserId { get; set; }

}