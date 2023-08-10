using AutoMapper;
using CrudAPI.Configuration;
using CrudAPI.DTOs.BankTransaction;
using CrudAPI.Models;
using CrudAPI.Models.Database;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CrudAPI.Controllers
{

    public class BankTransactionController : BaseApiController
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public BankTransactionController(ApplicationDbContext context, IMapper mapper)
        {
                _context = context;
                _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetTransaction(int? id)
        { 
            if(id is null)
            {
                var transactionList = await _context.BankTransactions.Include(x=>x.Person).Include(x=>x.PaymentMethod).ToListAsync();
                if (transactionList == null)
                    return BadRequest("Empty !");
                var mappedList = _mapper.Map< List < BankTransactionDTO >> (transactionList);

                return Ok(mappedList);
            }
             
           var transaction = await _context.BankTransactions.FirstOrDefaultAsync(x => x.Id == id);
            if (transaction == null)
                return BadRequest("Empty");

            var mappedTransaction = _mapper.Map<BankTransactionDTO>(transaction);

            return Ok(mappedTransaction);
        }

        [HttpPost]
        public async Task<IActionResult> CreateTransaction(BankTransactionDTO bankTransactionDTO)
        {
            var bankTransaction = _mapper.Map<BankTransaction>(bankTransactionDTO);

            var bankAccount = await _context.BankAccounts.FirstOrDefaultAsync(x => x.AccountNumber == bankTransactionDTO.AccountNumber);


            if(bankTransactionDTO.TransactionType == TransactionType.Credit)
            {
                bankAccount.TotalBalance += bankTransactionDTO.Amount;
            } 
            else if(bankTransactionDTO.TransactionType == TransactionType.Debit)
            {
                bankAccount.TotalBalance -= bankTransactionDTO.Amount;

            }

            await _context.BankTransactions.AddAsync(bankTransaction);
            int acn =  await _context.SaveChangesAsync();

            if(acn>0)
                return Ok("Transaction Done !");

            return BadRequest("Error In transaction");
        }

        [HttpPatch]

        public async Task<IActionResult> UpdateTransaction(int id,BankTransactionDTO bankTransactionDTO)
        {
            var transaction = await _context.BankTransactions.FirstOrDefaultAsync(x => x.Id == id);

            _mapper.Map(bankTransactionDTO,transaction);

            int acn = await _context.SaveChangesAsync();

            if (acn > 0)
                return Ok("Transaction Updated !");

            return BadRequest("Error In Updation");
        }

        [HttpDelete]

        public async Task<IActionResult>DeleteTransaction(int id)
        {
            var transaction = await _context.BankTransactions.FirstOrDefaultAsync(_ => _.Id == id);
            _context.BankTransactions.Remove(transaction);
            int acn = await _context.SaveChangesAsync();
            if (acn > 0)
                return Ok("Transaction Removed Successfully !");
            return BadRequest("Error While Removing Transaction");

        }
    }
}
