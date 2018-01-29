﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CleaningServices.Controllers
{
    [Route("blog")]
    public class BlogController : Controller
    {
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("{year:min(2000)}/{month:range(1,12)}/{key}")]
        public IActionResult Post(int year, int month, string key)
        {
            ViewBag.Title = "My blog post";
            ViewBag.Posted = DateTime.Now;
            ViewBag.Author = "Carlos Guisao";
            ViewBag.Body = "This is a great blog post, don't you think?";

            return View();
        }
    }
}