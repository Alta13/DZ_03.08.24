using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Task1
{
    /*Задание 1.
Напишите метод, который отображает квадрат из
некоторого символа. Метод принимает в качестве параметра: длину стороны квадрата, символ.*/
    static void Main()
    {
        Console.WriteLine("Введите длину стороны квадрата:");
        int length = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите символ для отображения квадрата: ");
        char symbol = Console.ReadKey().KeyChar;

        Console.WriteLine("\n");
        DrawSquare(length, symbol);

        Console.ReadKey();
    }

    static void DrawSquare(int length, char symbol)
    {
        for (int i = 0; i < length; i++)
        {
            for (int j = 0; j < length; j++)
            {
                Console.Write(symbol + " ");
            }
            Console.WriteLine();
        }
    }
}

class Task2
/*Задание 2.
Напишите метод, который проверяет является ли
переданное число «палиндромом». Число передаётся в
качестве параметра. Если число палиндром нужно вернуть из метода true, иначе false.
Палиндром — число, которое читается одинаково как
справа налево, так и слева направо. Например:
1221 — палиндром;
3443 — палиндром;
7854 — не палиндром.*/
{
    static void Main()
    {
        Console.WriteLine("Введите число для проверки:");
        int number = Convert.ToInt32(Console.ReadLine());
        bool isPalindrome = CheckPalindrome(number);

        if (isPalindrome)
        {
            Console.WriteLine($"Число {number} является палиндромом");
        }
        else
        {
            Console.WriteLine($"Число {number} НЕ является палиндромом");
        }

        Console.ReadKey();
    }

    static bool CheckPalindrome(int number)
    {
        int originalNumber = number;
        int reversedNumber = 0;

        while (number > 0)
        {
            int remainder = number % 10;
            reversedNumber = reversedNumber * 10 + remainder;
            number = number / 10;
        }

        return originalNumber == reversedNumber;
    }
}

class Task3
{
    /*Задание 3.
    Напишите метод, фильтрующий массив на основании
    переданных параметров. Метод принимает параметры:
    оригинальный_массив, массив_с_данными_для_фильтрации.
    Метод возвращает оригинальный массив без элементов, которые есть в массиве для фильтрации.
    Например:
    1 2 6 - 1 88 7 6 — оригинальный массив;
    6 88 7 — массив для фильтрации;
    1 2 - 1 — результат работы метода.*/
    static int[] FilterArray(int[] originalArray, int[] filterArray)
    {
        List<int> result = new List<int>();

        foreach (int number in originalArray)
        {
            if (!filterArray.Contains(number))
            {
                result.Add(number);
            }
        }

        return result.ToArray();
    }

    static void Main(string[] args)
    {
        int[] originalArray = { 1, 2, 6, -1, 88, 7, 6 };
        int[] filterArray = { 6, 88, 7 };

        int[] filteredArray = FilterArray(originalArray, filterArray);

        Console.WriteLine("Оригинальный массив:");
        Console.WriteLine(string.Join(" ", originalArray));

        Console.WriteLine("Массив для фильтрации:");
        Console.WriteLine(string.Join(" ", filterArray));

        Console.WriteLine("Получившийся массив после фильтрации:");
        Console.WriteLine(string.Join(" ", filteredArray));

        Console.ReadKey();
    }
}

class Website
{
    /*Задание 4.
    Создайте класс «Веб-сайт». Необходимо хранить в
    полях класса: название сайта, путь к сайту, описание
    сайта, ip адрес сайта. Реализуйте методы класса для ввода
    данных, вывода данных, реализуйте доступ к отдельным
    полям через методы класса. */

    private string siteName;
    private string siteUrl;
    private string siteDescription;
    private string siteIpAddress;

    public void SetSiteName(string name)
    {
        siteName = name;
    }

    public string GetSiteName()
    {
        return siteName;
    }

    public void SetSiteUrl(string url)
    {
        siteUrl = url;
    }

    public string GetSiteUrl()
    {
        return siteUrl;
    }

    public void SetSiteDescription(string description)
    {
        siteDescription = description;
    }

    public string GetSiteDescription()
    {
        return siteDescription;
    }

    public void SetSiteIpAddress(string ipAddress)
    {
        siteIpAddress = ipAddress;
    }

    public string GetSiteIpAddress()
    {
        return siteIpAddress;
    }

    public void InputData()
    {
        Console.WriteLine("Введите название сайта:");
        siteName = Console.ReadLine();

        Console.WriteLine("Введите путь к сайту:");
        siteUrl = Console.ReadLine();

        Console.WriteLine("Введите описание сайта:");
        siteDescription = Console.ReadLine();

        Console.WriteLine("Введите IP адрес сайта:");
        siteIpAddress = Console.ReadLine();
    }

    public void Show()
    {
        Console.WriteLine($"Название сайта: {siteName}");
        Console.WriteLine($"Путь к сайту: {siteUrl}");
        Console.WriteLine($"Описание сайта: {siteDescription}");
        Console.WriteLine($"IP адрес сайта: {siteIpAddress}");
    }
}
class Task4
{
    static void Main()
    {
        Website myWebsite = new Website();

        myWebsite.InputData();
        Console.WriteLine("\nВведённые данные:");
        myWebsite.Show();

        Console.ReadKey();
    }
}

class Journal
{
    /*Задание 5.
    Создайте класс «Журнал». Необходимо хранить в
    полях класса: название журнала, год основания, описание журнала, контактный телефон, контактный e-mail.
    Реализуйте методы класса для ввода данных, вывода
    данных, реализуйте доступ к отдельным полям через
    методы класса.*/
    private string journalName;
    private int foundationYear;
    private string description;
    private string contactPhone;
    private string contactEmail;

    public void SetJournalName(string name)
    {
        journalName = name;
    }

    public string GetJournalName()
    {
        return journalName;
    }

    public void SetFoundationYear(int year)
    {
        foundationYear = year;
    }

    public int GetFoundationYear()
    {
        return foundationYear;
    }

    public void SetDescription(string desc)
    {
        description = desc;
    }

    public string GetDescription()
    {
        return description;
    }

    public void SetContactPhone(string phone)
    {
        contactPhone = phone;
    }

    public string GetContactPhone()
    {
        return contactPhone;
    }

    public void SetContactEmail(string email)
    {
        contactEmail = email;
    }

    public string GetContactEmail()
    {
        return contactEmail;
    }

    public void InputData()
    {
        Console.WriteLine("Введите название журнала:");
        journalName = Console.ReadLine();

        Console.WriteLine("Введите год создания:");
        foundationYear = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите описание журнала:");
        description = Console.ReadLine();

        Console.WriteLine("Введите контактный телефон:");
        contactPhone = Console.ReadLine();

        Console.WriteLine("Введите Email:");
        contactEmail = Console.ReadLine();
    }

    public void DisplayData()
    {
        Console.WriteLine($"Название журнала: {journalName}");
        Console.WriteLine($"Год создания: {foundationYear}");
        Console.WriteLine($"Описание журнала: {description}");
        Console.WriteLine($"Контактный телефон: {contactPhone}");
        Console.WriteLine($"Email: {contactEmail}");
    }
}

class Task5
{
    static void Main()
    {
        Journal myJournal = new Journal();
        myJournal.InputData();
        Console.WriteLine("\nОписание журнала:");
        myJournal.DisplayData();

        Console.ReadKey();
    }
}

class Store
{
    /*Задание 6.
   Создайте класс «Магазин». Необходимо хранить в
   полях класса: название магазина, адрес, описание профиля магазина, контактный телефон, контактный e-mail.
   Реализуйте методы класса для ввода данных, вывода
   данных, реализуйте доступ к отдельным полям через
   методы класса.*/

    private string name;
    private string address;
    private string description;
    private string phoneNumber;
    private string email;

    public void SetName(string name)
    {
        this.name = name;
    }

    public string GetName()
    {
        return name;
    }

    public void SetAddress(string address)
    {
        this.address = address;
    }

    public string GetAddress()
    {
        return address;
    }

    public void SetDescription(string description)
    {
        this.description = description;
    }

    public string GetDescription()
    {
        return description;
    }

    public void SetPhoneNumber(string phoneNumber)
    {
        this.phoneNumber = phoneNumber;
    }

    public string GetPhoneNumber()
    {
        return phoneNumber;
    }

    public void SetEmail(string email)
    {
        this.email = email;
    }

    public string GetEmail()
    {
        return email;
    }

    public void InputData()
    {
        Console.WriteLine("Введите сведения о магазине:");
        Console.Write("Название магазина: ");
        name = Console.ReadLine();

        Console.Write("Адрес магазина: ");
        address = Console.ReadLine();

        Console.Write("Описание профиля магазина: ");
        description = Console.ReadLine();

        Console.Write("Контактный телефон: ");
        phoneNumber = Console.ReadLine();

        Console.Write("Email: ");
        email = Console.ReadLine();
    }

    public void Show()
    {
        Console.WriteLine($"Название магазина: {name}");
        Console.WriteLine($"Адрес магазина: {address}");
        Console.WriteLine($"Описание магазина: {description}");
        Console.WriteLine($"Номер телефона: {phoneNumber}");
        Console.WriteLine($"Email: {email}");
    }
}

class Task6
{
    static void Main()
    {
        Store store = new Store();
        store.InputData();
        Console.WriteLine("\nО Магазине:");
        store.Show();

        Console.ReadKey();
    }
}

