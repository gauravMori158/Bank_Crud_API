using AutoMapper;
using CrudAPI.Configuration;
using CrudAPI.DTOs;
using CrudAPI.Models;
using CrudAPI.Models.Database;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
 

namespace CrudAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentMethodController : BaseApiController
    {
        private readonly IMapper _mapper;
        private readonly ApplicationDbContext _context;

        public PaymentMethodController(IMapper mapper,ApplicationDbContext context)
        {
                _mapper = mapper;
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetMethods(int?id)
        {
            if(id is null)
            {
                var methodList = await _context.PaymentMethods.ToListAsync();
                var mappedList = _mapper.Map<List<PaymentMethodDTO>>(methodList);
                return Ok(mappedList);
            }

            var methods = await _context.PaymentMethods.FirstOrDefaultAsync(x=>x.Id == id);
            var mappedMethod = _mapper.Map<PaymentMethodDTO>(methods);
            return Ok(mappedMethod);
        }
        [HttpPost]
        public async Task<IActionResult> CreateNewMethod(PaymentMethodDTO methodDTO)
        {
            var method = _mapper.Map<PaymentMethod>(methodDTO);
            await _context.PaymentMethods.AddAsync(method);

            int acn = await _context.SaveChangesAsync();

            if (acn > 0)
            {
                return Ok("Added !");
            }

            return BadRequest("Error!");

        }

        [HttpPut]
        public async Task<IActionResult> UpdateMethod(int id,PaymentMethodDTO methodDTO)
        {
            var method = await _context.PaymentMethods.FirstOrDefaultAsync(x => x.Id == id);
            _mapper.Map(methodDTO, method);
            int acn = await _context.SaveChangesAsync();
            if (acn > 0)
            {
                return Ok("Updated !");
            }
            return BadRequest("Error !");
        }

        [HttpDelete]

        public async Task<IActionResult>DeleteMethod(int id)
        {
            var method = await _context.PaymentMethods.FirstOrDefaultAsync(x => x.Id == id);
            _context.PaymentMethods.Remove(method);
            int acn = await _context.SaveChangesAsync();
            if (acn > 0)
            {
                return Ok("Deleted !");
            }
            return BadRequest("Error !");

        }

    }
}
