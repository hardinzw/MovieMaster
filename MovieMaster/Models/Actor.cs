using System.ComponentModel.DataAnnotations;

namespace MovieMaster.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Profile Picture URL")]
        public string ProfilePictureURL { get; set; }
        [Display(Name = "Actor Name")]
        public string FullName { get; set; }
        [Display(Name = "Biography")]
        public string Biography { get; set; }
        //Relationships
        public ICollection<Actor_Movie> Actors_Movies { get; set; }
    }
}
