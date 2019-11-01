using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PxxCore.Repository.EFCore;

namespace PxxCore.Web.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class PublicController : ControllerBase
    {
        protected DbContextBase dbContext;
    }
}