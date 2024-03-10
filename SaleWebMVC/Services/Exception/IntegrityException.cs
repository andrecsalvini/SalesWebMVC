using System;


namespace SaleWebMVC.Services.Exception
{
	public class IntegrityException : ApplicationException
	{
		public IntegrityException(string message) : base(message)
		{

		}
	}
}
