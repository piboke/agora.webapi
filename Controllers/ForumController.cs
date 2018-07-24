using System.Collections.Generic;
using agora.webapi.Models;
using Microsoft.AspNetCore.Mvc;

namespace agora.webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ForumController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<Forum>> Get()
        {
            return new Forum[]
            {
                new Forum()
                {
                    Description = "bla bla bla",
                    Name = "First Forum",
                    Id = 1
                },
                new Forum()
                {
                    Description = "bla bla bla",
                    Name = "First Forum",
                    Id = 1
                },
                new Forum()
                {
                    Description = "bla bla bla",
                    Name = "Second Forum",
                    Id = 2
                },
                new Forum()
                {
                    Description = "bla bla bla",
                    Name = "Third Forum",
                    Id = 3
                },
                new Forum()
                {
                    Description = "bla bla bla",
                    Name = "Fourth Forum",
                    Id = 4
                }

             };
        }
    }

}