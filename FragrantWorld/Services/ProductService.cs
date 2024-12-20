using FragrantWorld.DatabaseContext;
using FragrantWorld.Interface;
using FragrantWorld.Mode1s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FragrantWorld.Services
{
    public class ProductService : IProductService
    {
        private readonly AppDbContext _context;

        public ProductService(AppDbContext context)
        {
            _context = context;
        }
        public List<Product> GetProductList()
        {
            return _context.Products.ToList();
        }
    }
}
