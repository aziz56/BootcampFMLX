// See https://aka.ms/new-console-template for more information
class Program {
	static void Main () {
		Calculator calculator = new Calculator ();
		int hasil = calculator.Add(3, 4);
	}
}

class Calculator {
	public int Add(int x,int y) {
		return x + y;
	}
}
	