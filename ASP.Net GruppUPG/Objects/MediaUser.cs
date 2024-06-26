﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ASP.Net_GruppUPG.Objects
{
    public class MediaUser
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Email { get; set; }
        [MaxLength(50)]

        public string Password { get; set; }
        [MaxLength(50)]

        public string FirstName { get; set; }
        [MaxLength(50)]

        public string LastName { get; set; }

        public List<Movie> MoviesInLibrary { get; set; } = new List<Movie>();
        public List<Serie> SeriesInLibrary { get; set; } = new List<Serie>();

        public MediaUser(int id, string email, string password, string firstName, string lastName)
        {
            Id = id;
            Email = email;
            Password = password;
            FirstName = firstName;
            LastName = lastName;
        }
        public MediaUser(string email, string password, string firstName, string lastName)
        {
            Email = email;
            Password = password;
            FirstName = firstName;
            LastName = lastName;
        }

        public MediaUser() 
        {
            
        }
    }
}
