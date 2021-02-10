using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _ProductDal;
        public ProductManager(IProductDal productDal)
        {
            _ProductDal = productDal;
        }

        public IResult Add(Product product)
        {
            if (product.ProductName.Length<2)
            {
                return new ErrorResult("Ürün ismi en az 2 karakter olmalıdır.");
            }

            _ProductDal.Add(product);

            return new SuccessResult("Ürün eklendi.");

        }

        public List<Product> GetAll()
        {
            return _ProductDal.GetAll();
        }
        public List<Product> GetAllByCategoryId(int id)
        {
            return _ProductDal.GetAll(p=>p.CategoryId== id);
        }

        public Product GetById(int productId)
        {
            return _ProductDal.Get(p=> p.ProductId== productId);
        }

        public List<Product> GetByUnitPrice(decimal min, decimal max)
        {
            return _ProductDal.GetAll(p=>p.UnitPrice>=min && p.UnitPrice<=max);
        }
        public List<ProductDetailDto> GetProductDetails()
        {
            return _ProductDal.GetProductDetails();
        }
    }
}
