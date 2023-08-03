class Parent {
	public void ParentMethod() {
		Console.WriteLine("parent");
	}
	public void ParentMethod2() {
		Console.WriteLine("Parent2");
	}
}
class Child : Parent
{
	public void ChildMethod() {
		Console.WriteLine("child method");
	}
}
void Main() {
	Parent parent = new Parent();
	Child child = new Child();
	
	child.ParentMethod();
	child.ParentMethod2();
	child.ChildMethod();
	
	Parent parent2 = child;
	parent2.ParentMethod();
	parent2.ParentMethod2();
	parent2.ChildMethod();
	
}