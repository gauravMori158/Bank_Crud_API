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
    public class AccountTypeController : BaseApiController
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        public AccountTypeController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;

        }
        [HttpGet]
        public async Task<IActionResult> GetAccountTypes(int? id)
        {
            if (id == null)
            {
                var accountTypes = await _context.AccountTypes.ToListAsync();
                var mappedList = _mapper.Map<List<AccountTypeDTO>>(accountTypes);
                return Ok(mappedList);
            }
            var accountType = await _context.AccountTypes.FirstOrDefaultAsync(x => x.Id == id);

            var mappedType = _mapper.Map<AccountTypeDTO>(accountType);
            return Ok(mappedType);
        }
        [HttpPost]
        public async Task<IActionResult> CreateAccountType(AccountTypeDTO accountTypeDTO)
        {
            var accountType = _mapper.Map<AccountType>(accountTypeDTO);

            await _context.AccountTypes.AddAsync(accountType);
            int acn = await _context.SaveChangesAsync();

            if (acn > 0)
            {
                return Ok("Added !");
            }

            return BadRequest("Error!");

        }

        [HttpPut]

        public async Task<IActionResult> UpdateTypes(int id, AccountTypeDTO accountTypeDTO)
        {
            var accountType = await _context.AccountTypes.FirstOrDefaultAsync(x=>x.Id == id);

            _mapper.Map(accountTypeDTO, accountType);

            int acn = await _context.SaveChangesAsync();
            if (acn > 0)
            {
                return Ok("Updated !");
            }
            return BadRequest("Error !");
        }

        [HttpDelete]

        public async Task<IActionResult> DeleteTypes(int id)
        {
            var accountType = await _context.AccountTypes.FirstOrDefaultAsync(x => x.Id == id);

            _context.AccountTypes.Remove(accountType);
            int acn = await _context.SaveChangesAsync();
            if (acn > 0)
            {
                return Ok("Deleted !");
            }
            return BadRequest("Error !");

        }
    }
}