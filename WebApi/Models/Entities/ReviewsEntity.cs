namespace WebApi.Models.Entities;

public class ReviewsEntity
{

    public int Id { get; set; }
    public string Title { get; set; } = null!;
    public string Content { get; set; } = null!;
    public int Rating { get; set; } 
    public DateTime DateCreated { get; set; }

  
}
