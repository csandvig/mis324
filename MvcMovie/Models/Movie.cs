﻿using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class Movie
    {

        public int ID { get; set; }
        public string Title { get; set; }

        public DateTime ReleaseDate { get; set; }

        public string Genre { get; set; }
        public decimal Price { get; set; }
    }

    //connection string name must match name of this class.
    public class MovieDBContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
    }

}