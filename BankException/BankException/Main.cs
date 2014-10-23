using System;

namespace BankException
{
	class BankException : Exception
	{
		public string msg;
		public BankException(string msg) {
			this.msg = msg;
		}
	}

	class MainClass
	{
		public static void Main (string[] args)
		{
			int withdraw = 500, minBal = 450, bal = 890;
			try {
				bal -= withdraw;
				if(minBal > bal) {
					throw new BankException("Required minimum balance "+ minBal);
				}
				Console.WriteLine("Withdrawn {0}, Balance {1}", withdraw, bal);
			} catch (BankException be) {
				Console.WriteLine("Banking error: {0}", be.msg);
			}
		}
	}
}
