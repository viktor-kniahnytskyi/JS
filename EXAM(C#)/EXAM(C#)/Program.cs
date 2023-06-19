using System;

//Написати код задачі, розмістити його у репозитарії на GitHub. Посилання на нього розмістити в якості відповіді на дану задачу.

//Створити інтерфейс Lamp. Він має містити дані про освітлювальний прилад: тип, виробник, потужність у люменах, вид та кількість освітлювальних елементів. Інтерфейс має включати методи для друку на екрані значень цих даних та зміну потужності. 

//Створити інтерфейс Camera. Він має містити дані про фото прилад: тип, виробник, світлочутливість оптичного об'єктиву. Також інтерфейс має включати методи для друку на екрані значень цих даних та зміну світлочутливості. 

//Створити клас PhotoStudio, який буде наслідувати описані вище інтерфейси. 

//Створити мінімум два екземпляри даного класу.

//Вивести на екран усі характеристики фото та світлового обладнання.

//Змінити значення світлочутливості для одного об'єкту і вивести його на екран.

//Княгницький Віктор KN1-B21.







interface ILamp
{
    string Type { get; set; }
    string Manufacturer { get; set; }
    int Power { get; set; }
    string LightType { get; set; }
    int NumberOfElements { get; set; }

    void PrintDetails();
    void ChangePower(int newPower);
}

interface ICamera
{
    string Type { get; set; }
    string Manufacturer { get; set; }
    int LightSensitivity { get; set; }

    void PrintDetails();
    void ChangeLightSensitivity(int newSensitivity);
}

class PhotoStudio : ILamp, ICamera
{
    public string Type { get; set; }
    public string Manufacturer { get; set; }
    public int Power { get; set; }
    public string LightType { get; set; }
    public int NumberOfElements { get; set; }
    public int LightSensitivity { get; set; }

    public void PrintDetails()
    {
        Console.WriteLine("Деталi про лампу:");
        Console.WriteLine($"Тип: {Type}");
        Console.WriteLine($"Виробник: {Manufacturer}");
        Console.WriteLine($"Потужнiсть: {Power} люменiв");
        Console.WriteLine($"Тип свiтла: {LightType}");
        Console.WriteLine($"Кiлькiсть елементiв: {NumberOfElements}");
        Console.WriteLine();

        Console.WriteLine("Деталi про камеру:");
        Console.WriteLine($"Тип: {Type}");
        Console.WriteLine($"Виробник: {Manufacturer}");
        Console.WriteLine($"Свiтлочутливiсть: {LightSensitivity}");
        Console.WriteLine();
    }

    public void ChangePower(int newPower)
    {
        Power = newPower;
        Console.WriteLine($"Потужнiсть змiнена {Power} люменiв.");
        Console.WriteLine();
    }

    public void ChangeLightSensitivity(int newSensitivity)
    {
        LightSensitivity = newSensitivity;
        Console.WriteLine($"Свiтлочутливiсть змiнено на {LightSensitivity}.");
        Console.WriteLine();
    }
}

class Program
{
    static void Main(string[] args)
    {
        PhotoStudio studio1 = new PhotoStudio();

        Console.WriteLine("Введiть данi для Studio Lamp:");
        Console.Write("Тип: ");
        studio1.Type = Console.ReadLine();
        Console.Write("Виробник: ");
        studio1.Manufacturer = Console.ReadLine();
        Console.Write("Потужнiсть (Люменiв): ");
        studio1.Power = int.Parse(Console.ReadLine());
        Console.Write("Тип свiтла: ");
        studio1.LightType = Console.ReadLine();
        Console.Write("Кiлькiсть елементiв: ");
        studio1.NumberOfElements = int.Parse(Console.ReadLine());

        PhotoStudio studio2 = new PhotoStudio();

        Console.WriteLine("Введiть данi для  Portable Lamp:");
        Console.Write("Тип: ");
        studio2.Type = Console.ReadLine();
        Console.Write("Виробник: ");
        studio2.Manufacturer = Console.ReadLine();
        Console.Write("Потужнiсть (Люменiв): ");
        studio2.Power = int.Parse(Console.ReadLine());
        Console.Write("Тип свiтла: ");
        studio2.LightType = Console.ReadLine();
        Console.Write("Кiлькiсть елементiв: ");
        studio2.NumberOfElements = int.Parse(Console.ReadLine());

        studio1.PrintDetails();
        studio2.PrintDetails();

        Console.WriteLine("Введiть нову свiтлочутливiсть для Studio Lamp:");
        int newSensitivity = int.Parse(Console.ReadLine());
        studio1.ChangeLightSensitivity(newSensitivity);

        Console.ReadLine();
    }
}
