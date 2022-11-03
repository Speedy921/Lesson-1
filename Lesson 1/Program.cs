using System.Collections.Specialized;
using System.Data;
using System.Runtime.Intrinsics.X86;
using System.Numerics;
using System.Runtime.CompilerServices;

Console.WriteLine("*****Fun with Basic Data Types**** \n");
LocalVarDeclarations();
DefaultDeclarations();
NewingDataTypes();
ObjectFunctionality();
DatatypeFunctionality();
CharFunctionality();
ParseFromStrings();
BooleanFunctionality();
ParseFromStringsWithTryParse();
UseDatesAndTimes();
UseBigInteger();

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

static void DatatypeFunctionality() //члены числовых типов данных Min Max
{
    Console.WriteLine("=>Data type Functionality:");
    Console.WriteLine("Max of int:{0}", int.MaxValue);
    Console.WriteLine("Min of int:{0}", int.MinValue);
    Console.WriteLine("Max of double:{0}", double.MaxValue);
    Console.WriteLine("Min of double:{0}", double.MinValue);
    Console.WriteLine("double.Epsilon :{0}", double.Epsilon);
    Console.WriteLine("double.PositiveInfinity:{0}", double.PositiveInfinity);
    Console.WriteLine("double.NegativityInfinity:{0}", double.NegativeInfinity);
    Console.WriteLine();
}

static void CharFunctionality() //члены System.Char, проверка является ли символ цифрой буквой, знаком пунктуации
{
    Console.WriteLine("=> cahr type Functionality:");
    char myChar = 'a';
    Console.WriteLine("char.IsDigit('a'):{0}", char.IsDigit(myChar));
    Console.WriteLine("char.IsLetter('a'):{0}", char.IsLetter(myChar));
    Console.WriteLine("char.IsWhiteSpace('Hello There, 5'): {0}", char.IsWhiteSpace("Hello There", 5));
    Console.WriteLine("char.IsWhiteSpace('Hello There, 6'): {0}", char.IsWhiteSpace("Hello There", 6));
    Console.WriteLine("char.IsPunctuation('?'):{0}", char.IsPunctuation('?'));
    Console.WriteLine();
        

}

static void ParseFromStrings()
{
    Console.WriteLine("=>Data type parsing:");
    bool b = bool.Parse("True");
    Console.WriteLine("Value of b: {0}", b); //вывод значения в
    double d = double.Parse("99,884");
    Console.WriteLine("Value of d: {0}", d); //вывод значения d
    int i = int.Parse("8");
    Console.WriteLine("Value of i: {0}", i); //вывод значения i
    char c = char.Parse("w");
    Console.WriteLine("Value of c: {0}", c); //вывод значения с
    Console.WriteLine();

}

static void BooleanFunctionality()
{
    Console.WriteLine("=>Boolean Fuctionality:");// System.Boolean
    Console.WriteLine("bool.FasleString: {0}", bool.FalseString);
    Console.WriteLine("bool.TrueString: {0}", bool.TrueString);

}

static void ParseFromStringsWithTryParse()
{
    Console.WriteLine("=>Data type parsing with TryParse:");
    if (bool.TryParse("True", out bool b))
    {
        Console.WriteLine("Value of b: {0}", b); //вывод значения b
    }
    else 
    {
        Console.WriteLine("Default value of b: {0}", b); // вывод стандартного значения b
    }
    string value = "Hello";
    if (double.TryParse(value, out double d))
    {
        Console.WriteLine("Value of d:", d);
    }
    else
    {
        //преобразование выходного значения в дабл потерпело неудачу
        // переменной было присвоено стандартное значение.
        Console.WriteLine("Failed to convert the input ({0}) to a double and the variable was assigned the default {1}", value, d);

    }

    Console.WriteLine();
}

static void UseDatesAndTimes()
{
    Console.WriteLine("=> Dates and Times ");

    //этот конструктор принимает год, месяц и день
    DateTime dt = new DateTime(2015, 10, 17);

    //какой это день месяца
    Console.WriteLine("The day of {0} is {1}", dt.Date, dt.DayOfWeek);

    //сейчас месяц декабрь
    dt = dt.AddMonths(2);
    Console.WriteLine("Daylight savings: {0}", dt.IsDaylightSavingTime());

    //этот конструктор принимает часы, минуты и секунды
    TimeSpan ts = new TimeSpan(4, 30, 0);

    //вычесть 15 минут из текущего значения TimeSpan и вывести результат
    Console.WriteLine(ts.Subtract(new TimeSpan(0,15,0)));
}

static void UseBigInteger()
{
    Console.WriteLine("=> Use BigInteger:");
    BigInteger biggy = BigInteger.Parse("999999999999999999999999999999999999999999");
    Console.WriteLine( "Value of biggy is {0}", biggy); //значение biggy
    Console.WriteLine("Is biggy an even value?: {0}", biggy.IsEven); // biggy - четное?
    Console.WriteLine("Is biggy a power of two?: {0}", biggy.IsPowerOfTwo); // biggy - степень 2?
    BigInteger reallyBig = BigInteger.Multiply(biggy, BigInteger.Parse("8888888888888888888888888888888888888888888888888"));
    Console.WriteLine("Valeue of reallyBig is {0}",reallyBig); // занчение reallyBig
}