void Main() {
	"Hello".Dump();
	TryParsing();
	try
	{

	}
	catch(DivideByZeroException e) 
	{
		e.Message.Dump();
	}
	catch(IndexOutOfRangeException e) 
	{
		Console.WriteLine(e.Message);
	}
	catch(Exception e) 
	{
		e.Message.Dump();
	}
	"Final".Dump();
}

void Zero(int x, int y) {
	int z = x / y;
}

void Array() {
	int[] arrayInt = {1,2,3,4};
	int z = arrayInt[4];
}

void Recursive() {
	Recursive();
}

void Parsing() {
	string input = Console.ReadLine();
	int x = int.Parse(input);
	x.Dump();
}

void TryParsing() {
	string input = Console.ReadLine();
	bool status = int.TryParse(input, out int x);
	x.Dump();
}