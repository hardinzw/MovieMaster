using MovieMaster.Data.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieMaster.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public MovieCategory MovieCategory { get; set; }
        //Relationships
        public ICollection<Actor_Movie> Actors_Movies { get; set; }
        [ForeignKey("TheaterId")]
        public int TheaterId { get; set; }
        public Theater Theater { get; set; }
        [ForeignKey("ProducerId")]
        public int ProducerId { get; set; }
        public Producer Producer { get; set; }
        public double Price { get; set; }
        public string ImageURL { get; set; }
    }
}
