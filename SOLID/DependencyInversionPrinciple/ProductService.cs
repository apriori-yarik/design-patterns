using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple
{
    public class ProductService
    {
        // ProductService does not depend on the actual implementation of storage.Add() method
        public void AddProduct(IStorage storage, Product product)
        {
            storage.Add(product);
        }
    }
}
