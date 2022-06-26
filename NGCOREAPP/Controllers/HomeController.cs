﻿using Microsoft.AspNetCore.Mvc;
using NGCOREAPP.Models;
using NGCOREAPP.Models.List;
using NGCOREAPP.Operation;
using System.Diagnostics;

namespace NGCOREAPP.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public string GenerateShortLink([FromBody] Link _link)
        {
            GenerateLink generate = new GenerateLink();
            _link.ShortUrl = generate.Generate();
            Links.LinkList.Add(_link);
            return _link.ShortUrl;

        }
        [HttpPost]
        public List<Link> GetLinkList()
        {
            return Links.LinkList;
        }


    }
}