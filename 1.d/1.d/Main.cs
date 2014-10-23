using System;

namespace d
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int[] A = {12,5,6,4,0,13,18,17,1,9}; //any 10 values
			int[] B = {7,1,2,0,3,8,9}; //any 7 values
			for (int i = 0; A.Length >i; i ++) {
				try {
					Console.WriteLine ("{0} / {1} = {2}", A [i], B [i], A [i] / B [i]);
				} catch (DivideByZeroException dbz) {
					Console.WriteLine ("Cannot divide {0} by {1}", A [i], B [i]);
				} catch (IndexOutOfRangeException ior) {
					Console.WriteLine ("Cannot continue further, reached end of array...");
					break;
				}
			}
		}
	}
}
