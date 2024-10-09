// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

// Task 1
string name = "John Doe";
int age = 25;
bool isAdmin = true;

Console.WriteLine(name);
Console.WriteLine(age);
Console.WriteLine(isAdmin);

// Task 2
Console.WriteLine("Enter a number");

int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0)
{
    Console.WriteLine("Even");
}
else
{
    Console.WriteLine("Odd");
}

// Task 3
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(i);
}

// Task 4
int[] numArr = { 2, 4, 6, 8, 10 };

int sum = 0;

foreach(int num in numArr)
{
    Console.WriteLine(num);
    sum += num;
}

Console.WriteLine(sum);

// Task 5

void Greet(string name)
{
    Console.WriteLine("Hello " + name + "!");
}

Greet("Alice");