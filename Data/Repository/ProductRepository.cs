using BookShhoping.ApplicationDb.Repository.IRepository;
using BookShoping.Model;
using BookShoping_App.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShhoping.ApplicationDb.Repository
{
    public class ProductRepository:Repository<Product>,IProductRepository
    {
        private readonly ApplicationDbContext _context;
        public ProductRepository(ApplicationDbContext context):base(context)
        {
            _context = context;
        }
    }
}
