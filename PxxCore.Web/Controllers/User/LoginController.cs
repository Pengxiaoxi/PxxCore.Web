﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PxxCore.Entity;
using PxxCore.Repository.EFCore;

namespace PxxCore.Web.Controller
{
    /// <summary>
    /// LoginController
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    //[ApiExplorerSettings(IgnoreApi = true)]   //设置ApiExplorerSettings 会禁用此Api
    public class LoginController : PublicController<Base_User>
    {
        /// <summary>
        /// Get
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            try
            {
                var userList = await Repository.GetList();

                return Ok(userList);
            }
            catch (Exception ex)
            {
                return Ok(new JsonResult("") {StatusCode = 404, Value = ex.Message });
            }
        }

        /// <summary>
        /// GET: api/Login/5
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            return Ok(new {name = "PxxCore", pass = "123" });
        }

        /// <summary>
        /// POST: api/Login
        /// </summary>
        /// <param name="value"></param>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        /// <summary>
        /// PUT: api/Login/5
        /// </summary>
        /// <param name="id"></param>
        /// <param name="value"></param>
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        /// <summary>
        /// DELETE: api/ApiWithActions/5
        /// </summary>
        /// <param name="id"></param>
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
