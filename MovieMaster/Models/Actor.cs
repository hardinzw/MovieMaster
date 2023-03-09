using System.ComponentModel.DataAnnotations;

namespace MovieMaster.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }
        public string ProfilePictureURL { get; set; }
        public string FullName { get; set; }
        public string Biography { get; set; }
        //Relationships
        public ICollection<Actor_Movie> Actors_Movies { get; set; }
    }
}
