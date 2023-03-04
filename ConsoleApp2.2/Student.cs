namespace ConsoleApp2._2;

public class Student
{
    public string secname = "Решетнев";
    public string bd = "23.10.2004";
    public int gr = 623;
    public int[] score = new[] { 4, 3, 5, 5, 5 };

    public void Edit()
    {
        Console.WriteLine("Желаете внести изменения? (да : 1; нет : 2)");
        int vibor = Convert.ToInt32(Console.ReadLine());
        switch (vibor)
        {
            case 1: 
                Console.WriteLine("Фамилия");
                secname = Console.ReadLine();
                Console.WriteLine("Дата");
                bd = Console.ReadLine();
                Console.WriteLine("Группа");
                gr = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Данные изменены\n");
                    
                goto case 3;
            case 2:
                Console.WriteLine("Хорошо");
                break;
            case 3:
                Console.WriteLine("Проверка");
                Console.WriteLine($"Фамилия: {secname}\nДата: {bd}\nГруппа: {gr}");
                break;
        }
    }
    public void Print() {
        Console.WriteLine($"Фамилия: {secname}\nДата: {bd}\nГруппа: {gr}");
        Console.WriteLine($"Успеваемость:{string.Join(", ", score)}");
    }
}