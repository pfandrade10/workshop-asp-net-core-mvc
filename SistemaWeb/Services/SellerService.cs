using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SistemaWeb.Models;


namespace SistemaWeb.Services
{
    public class SellerService 
    {
        private readonly SistemaWebContext _context;

        public SellerService(SistemaWebContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }
    }
}
