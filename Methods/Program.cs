

static void Add()
{
    Console.WriteLine("Added!!!");
}

static int Add2( int number1=20, int number2= 30)
{

    var result = number1 + number2;
    return result;

}

//int number1 = 20;
//int number2 = 100;

//Console.WriteLine(Add2(20, 30));
//Console.WriteLine(Add3(ref number1, number2));   
//Console.WriteLine(number1);   




static int Add3(ref int number1 , int number2)
{
    number1 = 30;
    return number1 + number2;
}


static int Multiply(int number1, int number2)
{
    return number1 * number2;
}

static int Multiply1(int number1, int number2, int number3)
{
    return number1 * number2 * number3;
}



static int Add4 (params int[] numbers)
{
    return numbers.Sum();
}


//Console.WriteLine(Multiply(2, 4));
//Console.WriteLine(Multiply1(2, 4, 5));
Console.WriteLine(Add4(1,3,5,7));

Console.ReadLine();