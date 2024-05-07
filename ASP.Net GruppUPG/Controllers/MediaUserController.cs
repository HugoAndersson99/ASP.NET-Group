﻿using ASP.Net_GruppUPG.Objects;
using ASP.Net_GruppUPG.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASP.Net_GruppUPG.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class MediaUserController : ControllerBase
    {
        MediaUserService mediaUserService;
        
        public MediaUserController(MediaUserService mediaUserService)
        {
            this.mediaUserService = mediaUserService;
        }

        [HttpGet("all")]
        public List<MediaUser> GetAll()
        {
            return mediaUserService.GetMediaUsers();
        }

        [HttpGet]
        public ActionResult GetMediaUser(int id)
        {
            MediaUser mediaUser = mediaUserService.GetMediaUserById(id);
            if (mediaUser == null)
            {
                return NotFound();
            }
            return Ok(mediaUser);
        }

        [HttpDelete] 
        public ActionResult DeleteMediaUser(int id)
        {
            bool success = mediaUserService.DeleteMediaUserById(id);
            if (success)
            {
                return Ok();
            }
            return BadRequest();
        }

        [HttpPost("add")]

        public ActionResult AddUser(MediaUser mediaUser)
        {
            bool success = mediaUserService.AddMediaUser(mediaUser);
            if (success)
            {
                return Ok();
            }
            return BadRequest();
        }
        [HttpPut("edit")]

        public ActionResult UpdateUser(MediaUser mediaUser)
        {
            bool success = mediaUserService.UpdateMediaUser(mediaUser);
            if (success)
            {
                return Ok();
            }
            return BadRequest();
        }
        [HttpPost("addMovieToLibrary")]
        public ActionResult AddMovie(Movie movie)
        {
            
            bool success = mediaUserService.AddMovieToLibrary(movie);
            if (success)
            {
                return Ok();
            }
            return BadRequest();
        }
        [HttpPost("user")]
        public ActionResult GetUser(MediaUser mediaUser)
        {
            mediaUserService.SetUser(mediaUser);
            return Ok();
        }
        [HttpGet("movies")]
        public void addMovies(MediaUser user)
        {
            
            
            Movie movie = new Movie("Sandarna", "Comedy", "Rolig", 1999, 180);

            movie.Users.Add(user);
            mediaUserService.Save(movie);

        }
    }
}
