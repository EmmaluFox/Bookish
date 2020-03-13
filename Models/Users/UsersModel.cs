using System.ComponentModel.DataAnnotations;

namespace Bookish.Models.Users
{
    public class UsersModel
    {
            [Required]
            [MinLength(1)]
            [MaxLength(128)]
            public string FirstName { get; set; }
        
            [Required]
            [MinLength(1)]
            [MaxLength(128)]
            public string LastName { get; set; }
            
            [Required]
            [MinLength(1)]
            [MaxLength(128)]
            public string Email { get; set; }
            
            [MaxLength(200)]
            public string ImageUrl { get; set; }
     
    }
}