using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatingApp.API.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {        
        private readonly Entities _entityContext;
        
        public ValuesController(Entities entityContext){
            _entityContext = entityContext;
        }
        [HttpGet]
        public async Task<IActionResult> GetValues(){
            var values = await _entityContext.Values.ToListAsync();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetValues(int id){
            var value = await _entityContext.Values.FirstOrDefaultAsync(x=> x.Id == id);
            return Ok(value);
        }
    }
}