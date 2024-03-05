using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SaleWebMVC.Data;
using SaleWebMVC.Models;

namespace SaleWebMVC.Services
{
	public class SellerService
	{
		private readonly SaleWebMVCContext _context;

		public SellerService(SaleWebMVCContext context)
		{
			_context = context;
		}

		public List<Seller> FindAll()
		{
			return _context.Seller.ToList();
		}

		public void Insert(Seller obj)
		{
			obj.Department = _context.Department.First();
			_context.Add(obj);
			_context.SaveChanges();
		}
	}
}
