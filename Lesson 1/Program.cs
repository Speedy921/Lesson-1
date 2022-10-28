using System.Collections.Specialized;
using System.Data;
using System.Runtime.Intrinsics.X86;

Console.WriteLine("*****Fun with Basic Data Types**** \n");
LocalVarDeclarations();
DefaultDeclarations();
NewingDataTypes();
ObjectFunctionality();

static void LocalVarDeclarations()
{
    Console.WriteLine("=> Data Declaration:");
    //локальные переменые обьявляются и инициализируются так:
    //типДанных имяПеременной = начальноеЗначение;

    int myInt = 0;

    string myString;

    myString = "This is my character data";
    //обьявить три переменный типа bool в одной строке.
    bool b1 = true, b2 = false, b3 = b1;
    //Использовать тип данных System.Boolean
    //для обьявления булевской переменной
    System.Boolean b4 = false;
    Console.WriteLine("Your data: {0}, {1}, {2}, {3}, {4}, {5},", myInt, myString, b1, b2, b3, b4);

    Console.WriteLine();
}

static void DefaultDeclarations() //литерал Default присваивает стандартное значение типа данных
{
    Console.WriteLine("=> Default Declarations:");
    int myInt = default;
}

static void NewingDataTypes()
{
    // стандартный конструктор
    // позволяет создавать переменную исп ключевое слово new
    // что устанавливает переменную в ее стандартное положение
    Console.WriteLine("=>Using new to create variables:");
    
    bool b = new (); // устанавливает в false
    int i = new (); // устанавливает в 0
    double d = new (); // устанавливает в 0.0
    DateTime dt = new (); // устанавливает в 1/1/0001 12:00:00 АM

    Console.WriteLine("{0}, {1}, {2}, {3}", b, i, d, dt);
    Console.WriteLine();
}

static void ObjectFunctionality()
{
    Console.WriteLine("=>System.Object Functionality:");
    //Ключевое слово int языкка C# - это в действительности сокращение для
    //типа System.Int32 который наследует от System.Object следующтие члены
    Console.WriteLine("12.GetHashCode() = {0}", 12.GetHashCode());
    Console.WriteLine("12.Equals(23) = {0}", 12.Equals(23));
    Console.WriteLine("12.ToString() = {0}", 12.ToString());
    Console.WriteLine("12.GetType() = {0}", 12.GetType());
    Console.WriteLine();
}