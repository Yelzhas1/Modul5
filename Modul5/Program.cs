using System;

class MainClass
{
    static string ShowColor(string name, int age)
    {
        Console.WriteLine("{0},{1} лет \nнапишите свой любимый цвет на английском с маленькой буквы", name, age);
        var color = Console.ReadLine();

        switch (color)
        {
            case "red":
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is red!");
                break;

            case "green":
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is green!");
                break;
            case "cyan":
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is cyan!");
                break;
            default:
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine("Your color is yellow!");
                break;
        }
        return color;
    }

    public static void Main(string[] args)
    {
        //var (name, age) = ("Евгения", 27);

        //Console.WriteLine("Мое имя: {0}", name);
        //Console.WriteLine("Мой возраст: {0}", age);

        //Console.Write("Введите имя: ");
        //name = Console.ReadLine();
        //Console.Write("Введите возрас с цифрами:");
        //age = Convert.ToInt32(Console.ReadLine());

        //Console.WriteLine("Ваше имя: {0}", name);
        //Console.WriteLine("Ваш возраст: {0}", age);


        //var favcolors = new string[3];
        //for (int i = 0; i < favcolors.Length; i++)
        //{
        //    favcolors[i] = ShowColor(name, age);
        //}

        //Console.WriteLine("Ваши любимые цвета:"); 
        //foreach (var color in favcolors)
        //{
        //    Console.WriteLine(color);
        //}

        //var array = GetArrayFromConsole();
        //var sortedarray = SortArray(array);
        //ShowArray(array, true);

        //var somename = "Mike";
        //Console.WriteLine(somename);
        //GetName(ref somename);
        //Console.WriteLine(somename);
        //Console.ReadLine();

        //var myage = 26;
        //Console.WriteLine(myage);
        //ChangeAge(myage);
        //Console.WriteLine(myage);
        //Console.ReadLine();

        //var arr = new int[] { 1, 2, 3 };
        //BigDataOperation(in arr);

        //Console.WriteLine(arr[0]);

        //Console.WriteLine("Напишите что-то");
        //var str = Console.ReadLine();

        //Console.WriteLine("Укажите глубину эха");
        //var deep = int.Parse(Console.ReadLine());

        //Echo(str, deep);

        //Console.ReadKey();

        //Console.WriteLine(Factorial(20));
        
        Console.WriteLine(PowerUp(2,3));
    }

    static int[] GetArrayFromConsole()//ref int num
    {
        var result = new int[5];

        for (int i = 0; i < result.Length; i++)
        {
            Console.WriteLine("Введите элемент массива номер {0}", i + 1);
            result[i] = int.Parse(Console.ReadLine());
        }

        return result;
    }

    static void SortArray(in int[] array, out int[] sorteddesc, out int[] sortedasc)
    {
        sorteddesc = SortArrayDesc(array);
        sortedasc = SortArrayAsc(array);
    }

    static void ShowArray(int[] array, bool Sort = false)
    {
        var temp = array;
        if (Sort)
        {
            //temp = SortArray(array);
        }
        foreach (var i in temp)
        {
            Console.WriteLine(i);
        }

    }

    static void GetName(ref string name)
    {
        Console.WriteLine("Введите имя");
        name = Console.ReadLine();

    }

    static void ChangeAge(int age)
    {
        {
            Console.WriteLine("Введите сколько вам лет");
            age = Convert.ToInt32(Console.ReadLine());
        }
    }

    static void BigDataOperation(in int[] arr)
    {
        arr[0] = 4;
    }

    static int[] SortArrayDesc(int[] result)
    {
        int temp = 0;
        for (int i = 0; i < result.Length; i++)
            for (int j = i + 1; j < result.Length; j++)
                if (result[i] < result[j])
                {
                    temp = result[i];
                    result[i] = result[j];
                    result[j] = temp;
                }
        for (int i = 0; i < result.Length; i++)
        {
            Console.WriteLine(result[i]);
        }
        return result;
    }

    static int[] SortArrayAsc(int[] result)
    {
        int temp = 0;
        for (int i = 0; i < result.Length; i++)
            for (int j = i + 1; j < result.Length; j++)
                if (result[i] > result[j])
                {
                    temp = result[i];
                    result[i] = result[j];
                    result[j] = temp;
                }
        for (int i = 0; i < result.Length; i++)
        {
            Console.WriteLine(result[i]);
        }
        return result;
    }

    static void Echo(string saidworld, int deep)
    {
        var modif = saidworld;
        if (modif.Length > 2)
        {
            modif = modif.Remove(0, 2);
        }

        Console.BackgroundColor = (ConsoleColor)deep;
        Console.WriteLine("..." + modif);

        if (deep > 1)
        {
            Echo(modif, deep - 1);
        }
    }

    static decimal Factorial(int x)
    {
        if (x == 0)
        {
            return 1;
        }
        else
        {
            return x * Factorial(x - 1);
        }
    }

    private static int PowerUp(int N, byte pow)
    {
        if (pow == 0)
        {
            return 1;
        }
        else
        {
            if (pow == 1)
            {
                return N;
            }
            else
            {
                return N * PowerUp(N, --pow);
            }
        }
    }
}