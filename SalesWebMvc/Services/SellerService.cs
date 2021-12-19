using SalesWebMvc.Data;
using SalesWebMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Services
{
    public class SellerService
    {
        private readonly SalesWebMvcContext _context;

        public SellerService(SalesWebMvcContext context)
        { _context = context; }

        //isso vai acessar minha fonte de dados dos vendedores, e fazer uma lista:
        public List<Seller> FindAll()
        { return _context.Seller.ToList(); }


    }
}
