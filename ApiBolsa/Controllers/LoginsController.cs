﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApiBolsa.Model;
using ApiBolsa.Model.Request;
using ApiBolsa.Servicios;
using ApiBolsa.Tools;
using Microsoft.AspNetCore.Authorization;

namespace ApiBolsa.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginsController : ControllerBase
    {
        private readonly BolsaContext _context;

        private ILoginService _loginService;


        public LoginsController(BolsaContext context, ILoginService loginService)
        {
            _context = context;
            _loginService = loginService;
        }

        // GET: api/Logins
        [Authorize(Roles= "Administrador")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Login>>> GetLogins()
        {
            return await _context.Logins.ToListAsync();
        }

        // GET: api/Logins/5
        [Authorize(Roles = "Administrador")]
        [HttpGet("{id}")]
        public async Task<ActionResult<Login>> GetLogin(int id)
        {
            var login = await _context.Logins.FindAsync(id);

            if (login == null)
            {
                return NotFound();
            }

            return login;
        }

        // PUT: api/Logins/5
        [Authorize]
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLogin(int id, Login login)
        {
            if (id != login.Id)
            {
                return BadRequest();
            }

            _context.Entry(login).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LoginExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Ok();
        }


        // POST: api/Logins
        [HttpPost]
        public async Task<ActionResult<Login>> PostLogin(Login login)
        {
            login.Contraseña = Encryptar.GetSHA256(login.Contraseña);
            _context.Logins.Add(login);
            await _context.SaveChangesAsync();
            return CreatedAtAction("GetLogin", new { id = login.Id }, login);
        }

        [HttpPost("Login")]
        public IActionResult Autentificar([FromBody] LoginRequest model)
        {
            var  responses = _loginService.Auth(model);
            if (responses == null)
            {
                return BadRequest("Usuario o contraseña incorrecta");
            }
            else
            { 
                return Ok(responses);
            }
        }

        // DELETE: api/Logins/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLogin(int id)
        {
            var login = await _context.Logins.FindAsync(id);
            if (login == null)
            {
                return NotFound();
            }

            _context.Logins.Remove(login);
            await _context.SaveChangesAsync();

            return Ok();
        }

        private bool LoginExists(int id)
        {
            return _context.Logins.Any(e => e.Id == id);
        }
    }
}
