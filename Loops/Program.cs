
int number = 20;


//do
//{
//    Console.WriteLine(number);
//    number--;


//} while (number >= 0);

static void ForLoop()
{
    for (int i = 100; i >= 0; i = i - 2)
    {
        Console.WriteLine(i);
    }
    Console.WriteLine("Finished!");
}

static void WhileLoop()
{
    int number = 100;
    while (number >= 0)
    {
        Console.WriteLine(number);
        number--;
    }

    Console.WriteLine("Now number is {0}", number);
}


//string[] students = new string[3] { "Engin", "Derin", "Salih" };

//foreach (string student in students)
//{
//    Console.WriteLine(student);
//}


Console.Write("Bir sayı giriniz : ");
int sayi = int.Parse(Console.ReadLine());


Console.WriteLine(Asalmi(sayi));




static bool Asalmi(int n)
{
    bool asal = true;
    for (int i = 2; i < n; i++)
    {
        if (n % i == 0)
        {
            asal = false;
        }
        
    }

    return asal;

}



Console.ReadLine();