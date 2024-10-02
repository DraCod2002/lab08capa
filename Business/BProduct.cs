using Data;
using Entity;
using System.Collections.Generic;

namespace Business
{
    public class BProduct
    {
        // Método para obtener todos los productos
        public List<Products> Get()
        {
            DProduct dProduct = new DProduct();
            return dProduct.Get();
        }

        // Método para buscar productos por nombre
        public List<Products> GetProductsByName(string name)
        {
            DProduct dProduct = new DProduct();
            return dProduct.GetProductsByName(name);
        }
    }
}
