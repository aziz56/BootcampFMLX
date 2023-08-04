class Program {
static void Main() //object boxing and unboxing
{
	int a = 9;
	object obj = a; //boxing
	
	int b = (int)obj; //unboxing
	
	Console.WriteLine(b);
	
	int q = (int)ObjectMaker.MyWrapper(5);
	Console.WriteLine(q);
}
}

static class ObjectMaker {
	public static object MyWrapper(int x) {
		object z = x;
		return z;
	}
}

// You can define other methods, fields, classes and namespaces here