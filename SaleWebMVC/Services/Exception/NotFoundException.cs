using System;

namespace SaleWebMVC.Services.Exception
{
	public class NotFoundException : ApplicationException
	{
		public NotFoundException(string message) : base(message)
		{

		}
	}
}
