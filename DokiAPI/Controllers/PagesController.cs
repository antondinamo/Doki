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
        private readonly IRepository<Page> pages;
        public PagesController(IRepository<Page> repository)
        {
            pages = repository;
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var page = pages.Get(id);

            return Ok(page);
        }
    }
}