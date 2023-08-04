void Main() { //dynamic 
	//Remove the type safety 
	//Dont use it because its inefficient
	
	int a = 9;
	dynamic b = a;
	Console.WriteLine(b); //9
	
	b = "Hello";
	Console.WriteLine(b); // "Hello"
}