
using System.Runtime.InteropServices;

string[] Students = new string[3] { "Engin", "Derin", "Salih" };

string[] Students2 = { "Engin", "Derin", "Salih" };

//foreach (var student in Students2)
//{
//    Console.WriteLine(student);
//}


string[,] regions = new string[5, 3]
{
    {"İstanbul","İzmit","Yalova" },
    {"Ankara","Konya","Kırıkkale" },
    {"Antalya","Adana","Mersin" },
    {"Rize","Trabzon","Samsun" },
    {"İzmir","Muğla","Manisa" }

};

for (int i = 0; i <= regions.GetUpperBound(0); i++)
{
    for (int j = 0; j <= regions.GetUpperBound(1); j++)
    {

        Console.WriteLine(regions[i, j]);

    }
    Console.WriteLine("********");
}


Console.ReadLine();