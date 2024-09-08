using System;
using System.Linq;
class Program
    {
    static void Main(string[] args)
    {
        ShowUserInformation(GetUserData());
    }

    static (string Name, string LastName, int Age, bool IsPetOwner, int PetCount, string[] PetNames, int ColorCount, string[] FavoriteColors) GetUserData() //
{
        (string Name, string LastName, int Age, bool IsPetOwner, int PetCount, string[] PetNames, int ColorCount, string[] FavoriteColors) User; //, string[] FavoriteColors

        Console.Write("Ваше имя: ");
        User.Name = Console.ReadLine();

        Console.Write("Ваше фамилия: ");
        User.LastName = Console.ReadLine();

        string num = "";
        int intNum = 0;
        Age(ref intNum, num);
        //static void Age()
        //{   
        //    Console.Write("Введите возраст с цифрами:");
        //    //User.Age = Convert.ToInt32(Console.ReadLine());
        //    num = Console.ReadLine();
        //    if (CheckNum(num, out int correctNum))
        //    {
        //        if (correctNum > 0)
        //        {
        //            intNum = correctNum;
        //        }
        //    }
        //}
        User.Age = intNum;

        string IsPetOwner;
        Console.Write("У вас есть питомец? Ответьте да или нет: ");
        IsPetOwner = Console.ReadLine().ToLower();

        User.IsPetOwner = false;

        if (IsPetOwner == "да")
        {
            User.IsPetOwner = true;
            //Console.Write("Сколько у вас питомцев? ");
            //PetCount = Convert.ToInt32(Console.ReadLine());
            PetCount(ref intNum, num);
        }

        User.PetCount = intNum;
        User.PetNames = PetNames(intNum);

        //Console.Write("Сколько у вас любимых цветов? ");
        //User.ColorCount = Convert.ToInt32(Console.ReadLine());
        ColorCount(ref intNum, num);
        User.ColorCount = intNum;

        User.FavoriteColors = FavoriteColors(intNum);
        return User;
    }

    static string[] PetNames(int intNum)
    {
        var result = new string[intNum];
        for (int i = 0; i < intNum; i++)
        {
            Console.WriteLine("Введите название питомцa номер {0}", i + 1);
            result[i] = Console.ReadLine();
        }
        return result;
    }

    static string[] FavoriteColors(int intNum)
    {
        var result = new string[intNum];
        for (int i = 0; i < intNum; i++)
        {
            Console.WriteLine("Любимый цвет номер {0}", i + 1);
            result[i] = Console.ReadLine();
        }
        return result;
    }

    static bool CheckNum(string num, out int correctNum)
    {
        if (int.TryParse(num, out int intNum))
        {
            correctNum = intNum;
            return true;
        }
        correctNum = 0;
        return false;
    }

    static int Age(ref int intNum, string num)
    {
        Console.Write("Введите возраст с цифрами: ");
        //User.Age = Convert.ToInt32(Console.ReadLine());
        num = Console.ReadLine();
        if (CheckNum(num, out int correctNum))
        {
            if (correctNum > 0)
            {
                intNum = correctNum;
            }
            else
            {
                return Age(ref intNum, num);
            }
        }
        else
        {
            return Age(ref intNum, num);
        }

        return intNum;
    }

    static int PetCount(ref int intNum, string num)
    {
    Console.Write("Сколько у вас питомцев? ");
    num = Console.ReadLine();
    if (CheckNum(num, out int correctNum))
    {
        if (correctNum > 0)
        {
            intNum = correctNum;
        }
        else
        {
            return PetCount(ref intNum, num);
        }
    }
    else
    {
        return PetCount(ref intNum, num);
    }

    return intNum;
    }

    static int ColorCount(ref int intNum, string num)
    {
        Console.Write("Сколько у вас любимых цветов? ");
        num = Console.ReadLine();
        if (CheckNum(num, out int correctNum))
        {
            if (correctNum > 0)
            {
                intNum = correctNum;
            }
            else
            {
                return ColorCount(ref intNum, num);
            }
        }
        else
        {
            return ColorCount(ref intNum, num);
        }

        return intNum;
    }

    static void ShowUserInformation((string Name, string LastName, int Age, bool IsPetOwner, int PetCount, string[] PetNames, int ColorCount, string[] FavoriteColors) User) 
    {

        Console.WriteLine("Имя: {0}", User.Name);
        Console.WriteLine("Фамилия: {0}", User.LastName);
        Console.WriteLine("Возраст: {0}", User.Age);
        if (User.IsPetOwner)
        {
            Console.WriteLine("Владеет питомцем");
            Console.WriteLine("Количество питомцев: {0}", User.PetCount);
            Console.Write("Клички питомцев: ");
            for (int i = 0; i < User.PetNames.Length; i++)
            {
                Console.Write("{0} ", User.PetNames[i]);
            }
        }
        else
        {
            Console.WriteLine("Не владеет питомцем");
        }
        Console.WriteLine("\nКоличество любимых цветов: {0}", User.ColorCount);
        Console.Write("Любимые цвета: ");
        for (int i = 0; i < User.FavoriteColors.Length; i++)
        {
            Console.Write("{0} ", User.FavoriteColors[i]);
        }
    }
}
