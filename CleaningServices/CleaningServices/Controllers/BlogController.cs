using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CleaningServices.Models;

namespace CleaningServices.Controllers
{
    [Route("blog")]
    public class BlogController : Controller
    {
        [Route("")]
        public IActionResult Index()
        {
            var posts = new[]
            {
                new Post
                {
                    Title = "My blog post",
                    Posted = DateTime.Now,
                    Author = "Carlos Guisao",
                    Body = "This is a great blog post, don't you think?",
                },
                new Post
                {
                    Title = "My second blog post",
                    Posted = DateTime.Now,
                    Author = "Carlos Guisao",
                    Body = "This is ANOTHER great blog post, don't you think?",
                },
            };

            return View(posts);
        }

        [Route("{year:min(2000)}/{month:range(1,12)}/{key}")]
        public IActionResult Post(int year, int month, string key)
        {
            var post = new Post
            {
                Title = "My blog post",
                Posted = DateTime.Now,
                Author = "Carlos Guisao",
                Body = "This is a great blog post, don't you think?"
            };

            // using ViewBag example 

            //ViewBag.Title = "My blog post";
            //ViewBag.Posted = DateTime.Now;
            //ViewBag.Author = "Carlos Guisao";
            //ViewBag.Body = "This is a great blog post, don't you think?";

            return View(post);
        }
    }
}