namespace CalculatorEngine
{
	public class Calculator
	{
		//A and B
		public static double Add(double a, double b){
			return a + b;
		}

		public static double Subtract(double a, double b){
			return a - b;
		}

		public static double Multiply(double a, double b){
			return a * b;
		}

		public static double Divide(double a, double b){
			if(b == 0) return double.NaN;
			return a / b;
		}

		public static double Equals(double a, double b){
			return (a == b) ? 1 : 0;
		}

		public static double Pow(double a, double b){
			return Math.Pow(a, b);
		}

		public static double Log(double a, double b){
			if(b <= 0) return double.NaN;
			return Math.Log(a, b);
		}

		public static double Root(double a, double b){
			if(b <= 0) return double.NaN;
			return Math.Pow(a, 1.0 / b);
		}

		//A Only
		public static double Factorial(double a){
			if(a == 0) return 1;
			bool isNegative = a < 0;
			if(isNegative) a *= -1;

			int f = 1;
			for(int i = 1; i <= a; i++){
				f *= i;
			}
			return isNegative ? -f : f;
		}

		public static double Sin(double a){
			return Math.Sin(a);
		}

		public static double Cos(double a){
			return  Math.Cos(a);
		}

		public static double Tan(double a){
			return  Math.Tan(a);
		}

		public static double OneOver(double a){
			if(a == 0) return double.NaN;
			return 1/a;
		}
	}
}
