using System.Collections.Generic;
using System.Linq;
using Advantage.API.Models;

namespace Advantage.API
{
    public class DataSeed
    {
        private readonly ApiContext _ctx;

        public DataSeed(ApiContext ctx)
        {
            _ctx = ctx;
        }

        public void SeedData(int nCustomers, int nOrders)
        {
            if(!_ctx.Customers.Any())
            {
                SeedCustomers(nCustomers);
            }

            if(!_ctx.Orders.Any())
            {
                SeedOrders(nCustomers);
            }

            if(!_ctx.Servers.Any())
            {
                SeedServers(nCustomers);
            }
                _ctx.SaveChanges();
        }

        private void SeedCustomers(int n)
        {
            List<Customer> customers = BuildCustomerList(n);

            foreach(var customer in customers)
            {
                _ctx.Customers.Add(customer);
            }
        }

        private List<Customer> BuildCustomerList(int nCustomers)
        {
            var customers = new List<Customer>();

            var Name = Helpers.MakeCustomersName();

            for(var i = 1; i <= nCustomers; i++)
            {
                customers.Add(new Customer{
                    Id = i,
                    Name = name,
                    Email = email,
                    State = state
                });
            }
            return null;
        }
    }
}