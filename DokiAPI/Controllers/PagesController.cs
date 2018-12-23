using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DokiAPI.Models;
using DokiAPI.Services;
using DokiAPI.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DokiAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PagesController : ControllerBase
    {
        private readonly IRepository<Page> _pages;
        public PagesController(IRepository<Page> repository)
        {
            _pages = repository;
        }

        [HttpGet("{id}")]
        public Page Get(int id)
        {
            var page = _pages.Get(id);


            return page;
        }

        [HttpGet]
        [Route("Contents")]
        public Dictionary<int, string> GetContents()
        {
            var result = new Dictionary<int, string>()
            {
                { 1, "Страница один" },
                { 2, "Страница два" }
            };

            return result;
        }
    }
}