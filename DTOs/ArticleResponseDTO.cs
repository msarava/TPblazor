using BlazorLeBonCoin.DTOs;

namespace BlazorLeBonCoin.DTOs;

public class ArticleResponseDTO
{
    public  int Id { get; set; }
    public DateTime Date { get; set; }
    public int CategoryId { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public bool Status { get; set; }
    public List<ImageDto> Images { get; set; }
    public List<CommentDto> Comments { get; set; }
    public ArticleResponseDTO()
    {
        Images = new List<ImageDto>();
        Comments = new List<CommentDto>();
    }
}