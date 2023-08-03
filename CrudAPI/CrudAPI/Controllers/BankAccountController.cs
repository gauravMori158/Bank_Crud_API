using AutoMapper;
using Azure;
using CrudAPI.DTOs;
using CrudAPI.Models;
using CrudAPI.Models.Database;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CrudAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankAccountController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        public BankAccountController(ApplicationDbContext context , IMapper mapper)
        {
                _context = context;
                _mapper = mapper;
        }

        [HttpPost]
        [ActionName("Create Account")]
        public async Task<IActionResult> Create(BankAccountDTO bankAccountDTO)
        {
            var  bankAccount = _mapper.Map<BankAccount>(bankAccountDTO);

            await _context.BankAccounts.AddAsync(bankAccount);

            int acn = await _context.SaveChangesAsync();

            if(acn >0)
                return Ok("User Added Successfully!");
            return BadRequest("Error While Adding User !");
        }

        [HttpGet]
        [ActionName("Get Account")]
        public async Task<IActionResult> GetAccount(int? id)
        { 
            if(id is  null)
            {
               var accountList = await _context.BankAccounts.ToListAsync();
                if (accountList == null)
                    return BadRequest("Accounts does not exist.");

                var mappedLisy = _mapper.Map<List<BankAccountDTO>>(accountList);
                return Ok(mappedLisy);
            }

            var account = await _context.BankAccounts.FirstOrDefaultAsync(a => a.Id == id);
            if (account == null)
                return BadRequest("Account does not exist.");
            var mappedAccount = _mapper.Map<BankAccountDTO>(account);
            return Ok(mappedAccount);
        }

        [HttpPatch]
        public async Task<IActionResult> UpdateAccount(int id,  BankAccountUpdateDTO bankAccountDTO)
        {
            var account = await _context.BankAccounts.FirstOrDefaultAsync(x => x.Id == id);
             
            _mapper.Map(bankAccountDTO, account);
             
            int acn = await _context.SaveChangesAsync();

            if (acn >0)
                  return Ok(bankAccountDTO);
            return BadRequest("Error While Updating Account ");
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id )
        {
            var account = await _context.BankAccounts.FirstOrDefaultAsync(x => x.Id == id);
            _context.BankAccounts.Remove(account);
            int acn = await _context.SaveChangesAsync();
            if (acn >0) 
                 return Ok("Account Removed Successfully !");
            return BadRequest("Error While Removing Account");
        }
    }
}
