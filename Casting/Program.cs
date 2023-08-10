class Parent {
	public void ParentMethod () {
		Console.WriteLine("Parent");
	}
}

class Child : Parent {
	public void ChildMethod() {
		Console.WriteLine("Child");
	}
}

void Main() {
	Parent parent2 = new Parent(); //AB
	Child child2 = (Child)parent2; //ABCD <- AB
	child2.ParentMethod(); // child.A
	child2.ChildMethod(); //child.C
}