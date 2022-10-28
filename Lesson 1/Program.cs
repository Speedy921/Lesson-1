using System.Collections.Specialized;
using System.Runtime.Intrinsics.X86;

Console.WriteLine("*****Fun with Basic Data Types**** \n");
LocalVarDeclarations();

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
