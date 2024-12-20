using FragrantWorld.Mode1s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FragrantWorld.Interface
{
    public interface IProductService
    {
        List<Product> GetProductList();
    }
}
