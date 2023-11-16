using System.ComponentModel.DataAnnotations;

namespace Models;

public class Post
{
    [Key]
    public int Id { get; set; }
    public User Owner { get; private set; }
    // public int OwnerId { get; set; }
    
    public string Title { get; private set; }
    public string Body { get; set; }
    public bool IsPrivate { get; set; }

    public Post(User owner, string title, string body)
    {
        Owner = owner;
        Body = body;
        Title = title;
    }
   private Post(){} 
}