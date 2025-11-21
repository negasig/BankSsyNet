using BankSsyNet.Server.Data;
using BankSsyNet.Server.NewFolder;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BankSsyNet.Server.Controllers;

[ApiController]
[Route("api/[controller]")]



public class CustomerController : ControllerBase
{
    private readonly BankingDbContext _context;
    public CustomerController(BankingDbContext context)
    {
        _context = context;
    }
    [HttpGet("list")]
    public async Task<ActionResult> GetCustomers()
    {
        var customers = await _context.Customer.ToListAsync();
        return Ok(customers);
    }

    [HttpPost("addcustomer")]
    public async Task<IActionResult> AddCustomer(Customer customer)
    {
        _context.Customer.Add(customer);
        await _context.SaveChangesAsync();
        return Ok(customer);
    }
    [HttpGet("{id}")]
    public ActionResult<IEnumerable<Customer>> getCustomerById(int id){
        var customer = _context.Customer.Find(id);
        if (customer == null)
        {
            return NotFound($"Customer with ID {id} not found");
        }
        return Ok(customer);
        }
    [HttpDelete("{id}")]
    public ActionResult deleteCustomer(int id)
    {
        var cus = _context.Customer.Find(id);
        if (cus == null)
        {
            return NotFound($"Customer with ID {id} not found");
        }
        return Ok($"Customer with ID {id} has been deleted");
    }
}