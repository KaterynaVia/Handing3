using System.Text.Json.Serialization;

namespace Models;

public class User
{
    public string UserName { get; set; }
    public string Password { get; set; }

    public int Id { get; set; }
    
   
    public User()
    {
        
    }
}