namespace BlazorLeBonCoin.DTOs;

public class CommentDto
{
    public string Text { get; set; }

    public int UserAppId { get; set; }

    public UserResponseDto User { get; set; }

    public string StatusCom { get; set; }


}