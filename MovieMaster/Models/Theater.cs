﻿namespace MovieMaster.Models
{
    public class Theater
    {
        public int Id { get; set; }
        public string Logo { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        //Relationships
        public ICollection<Movie> Movies { get; set;}
    }
}
