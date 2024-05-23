using Calculator.App;
using System.Buffers;
using System.Runtime.CompilerServices;

Console.WriteLine("Task - Delegates:");

bool isContinue = true;
Mathoperations math = new Mathoperations();
Operations operation = null;
while (isContinue)
{
    Console.WriteLine("Calculator:\n1.Summation\n2.Multiplication\n3.Substraction\n4.Division\n0.Exit");
    Console.WriteLine("Operation number:");
    int.TryParse(Console.ReadLine(), out int optionnumber);
    Console.Clear();
    double res1 = new();
    double res2 = new();

    if (optionnumber != 0 && optionnumber <= 4)
    {
        (res1, res2) = InsertData();
    }
    switch (optionnumber)
    {
        case 0:
            isContinue = false;
            break;
        case 1:            
            operation = math.Sum;
            break;
        case 2:
            operation = math.Multiplication;
            break;
        case 3:
            operation = math.Substraction;
            break;
        case 4:
            operation = math.Division;
            break;
        default:
            Console.WriteLine("Invalid option number!");
            break;
    }
    if(operation != null)
    {
        Console.WriteLine(operation(res1, res2));
    }
}

(double, double) InsertData()
{
    Console.WriteLine("Number 1:");
    double.TryParse(Console.ReadLine(), out double usernum1);
    Console.WriteLine("Number 2:");
    double.TryParse(Console.ReadLine(), out double usernum2);
    return (usernum1, usernum2);    
}

public delegate double Operations(double num1, double num2);
