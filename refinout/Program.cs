void UpdateValue(ref int value)
{
    value = 10;
}

int number = 5;
UpdateValue(ref number);
Console.WriteLine(number); // Output: 10