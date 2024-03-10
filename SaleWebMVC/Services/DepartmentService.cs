using SaleWebMVC.Data;
using SaleWebMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SaleWebMVC.Services
{
	public class DepartmentService
	{
		private readonly SaleWebMVCContext _context;

		public DepartmentService(SaleWebMVCContext context)
		{
			_context = context;
		}

		//Essa configuração serve para informar ao compilador que essa será assíncrona 
		public async Task<List<Department>> FindAllAsync()
		{
			return await _context.Department.OrderBy(x => x.Name).ToListAsync();

		}
	}
}
