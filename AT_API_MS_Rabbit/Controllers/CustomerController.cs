using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Models.Entities;
using Data;
using Microsoft.AspNetCore.Mvc;
using Shared.Requests.Customers;

namespace AT_API_MS_Rabbit.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : Controller
    {
        [HttpPost]
        public async Task<IActionResult> RegisterCustomer(RegisterCustomer request)
        {
            if (!ModelState.IsValid)
            {
                return View(request);
            }
                

            var customer = new Customer()
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                CPF = request.CPF,
                Phone = request.Phone
            };

            var connection = new MongoAcess();
            await connection.Customers.InsertOneAsync(customer);
            return Ok();
        }
    }
}
