﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client_GruppForms.Objects
{
    public class MediaUser
    {

        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
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

        public MediaUser() { }
    }
}
