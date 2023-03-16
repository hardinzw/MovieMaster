using System.ComponentModel.DataAnnotations;

namespace MovieMaster.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Profile Picture URL")]
        [Required(ErrorMessage = "Profile picture is required")]
        public string ProfilePictureURL { get; set; }

        [Display(Name = "Actor Name")]
        [Required(ErrorMessage = "Full name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Full Name must be between 3 and 50 chars")]
        public string FullName { get; set; }

        [Display(Name = "Biography")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Biography must be between 3 and 50 chars")]
        public string Biography { get; set; }

        //Relationships
        public ICollection<Actor_Movie>? Actors_Movies { get; set; }
    }
}
