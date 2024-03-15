/*using System;
 * УП Практическая работа 2.1
ЗАДАНИЕ 1
class MainClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите строку J: ");
        string J = Console.ReadLine();

        Console.WriteLine("Введите строку S: ");
        string S = Console.ReadLine();

        int count = 0;

        foreach (char c in S)
        {
            if (J.Contains(c))
            {
                count++;
            }
        }

        Console.WriteLine(count);
    }
}*/

/*2 ЗАДАНИЕ
using System;
using System.Collections.Generic;

class MainClass
{
    public static void Main(string[] args)
    {
        int[] candidates = { 2, 5, 2, 1, 2 };
        int target = 5;

        List<List<int>> result = Combination(candidates, target);

        foreach (var list in result)
        {
            Console.WriteLine("[" + string.Join(",", list) + "]");
        }
    }

    public static List<List<int>> Combination(int[] candidates, int target)
    {
        Array.Sort(candidates);
        List<List<int>> result = new List<List<int>>();
        Backtrack(result, new List<int>(), candidates, target, 0);
        return result;
    }

    public static void Backtrack(List<List<int>> result, List<int> tempList, int[] candidates, int remaining, int start)
    {
        if (remaining < 0) return;

        else if (remaining == 0) result.Add(new List<int>(tempList));

        else
        {
            for (int i = start; i < candidates.Length; i++)
            {
                if (i > start && candidates[i] == candidates[i - 1]) continue;
                tempList.Add(candidates[i]);
                Backtrack(result, tempList, candidates, remaining - candidates[i], i + 1);
                tempList.RemoveAt(tempList.Count - 1);
            }
        }
    }
}




/*
 3 ЗАДАНИЕ
using System;
using System.Collections.Generic;
class Program
{
    static bool ContainsDuplicate(int[] nums)
    {
        HashSet<int> numSet = new HashSet<int>();
        foreach (int num in nums)
        {
            if (numSet.Contains(num))
            {
                return true;
            }
            numSet.Add(num);
        }
        return false;
    }
    static void Main()
    {
        int[] nums1 = { 1, 2, 3, 4 };
        Console.WriteLine(ContainsDuplicate(nums1)); 
        int[] nums2 = { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 };
        Console.WriteLine(ContainsDuplicate(nums2));
        int[] nums3 = { 1, 2, 3, 1 };
        Console.WriteLine(ContainsDuplicate(nums3)); 
    }
}*/

/*УП Практическая работа 2.2
 * ЗАДАНИЕ 1
 * using System;

internal class Student
{
    public string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string GroupNumber { get; set; }
    public int[] Grades { get; set; }

    public void ChangeLastName(string newLastName)
    {
        LastName = newLastName;
    }
    public void ChangeGroupNumber(string newGroupNumber)
    {
        GroupNumber = newGroupNumber;
    }

    public void DisplayStudentInfo()
    {
        Console.WriteLine($"Информация о студенте:");
        Console.WriteLine($"Фамилия: {LastName}");
        Console.WriteLine($"Дата рождения: {DateOfBirth}");
        Console.WriteLine($"Номер группы: {GroupNumber}");
        Console.WriteLine($"Оценки: {string.Join(", ", Grades)}");
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Введите фамилию студента: ");
        string lastName = Console.ReadLine();
        Console.Write("Введите дату рождения студента (yyyy-MM-dd): ");
        DateTime dateOfBirth = DateTime.Parse(Console.ReadLine());
        Console.Write("Введите номер группы студента: ");
        string groupNumber = Console.ReadLine();
        int[] grades = new int[5];
        Console.WriteLine("Введите оценки студента:");

        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Оценка {i + 1}: ");
            grades[i] = int.Parse(Console.ReadLine());
        }
        Student newStudent = new Student
        {
            LastName = lastName,
            DateOfBirth = dateOfBirth,
            GroupNumber = groupNumber,
            Grades = grades
        };
        Console.WriteLine("\nСтудент успешно создан.");
    }
}

/*using System;
internal class Train
{
    public string Destination { get; set; }
    public int TrainNumber { get; set; }
    public string DepartureTime { get; set; }
  
    public void DisplayTrainInfo()
    {
        Console.WriteLine("Информация о поезде с номером: " + TrainNumber);
        Console.WriteLine("Пункт назначения: " + Destination);
        Console.WriteLine("Время отправления: " + DepartureTime);
    }
}
class Program
{
    static void Main()
    {
        Train[] trains = new Train[2];
        for (int i = 0; i < 2; i++)
        {
            Console.Write($"Введите пункт назначения для поезда {i + 1}: ");
            string destination = Console.ReadLine();
            Console.Write($"Введите номер поезда {i + 1}: ");
            int trainNumber = int.Parse(Console.ReadLine());
            Console.Write($"Введите время отправления для поезда {i + 1}: ");
            string departureTime = Console.ReadLine();
            trains[i] = new Train
            {
                Destination = destination,
                TrainNumber = trainNumber,
                DepartureTime = departureTime
            };
        }
        Console.WriteLine("\nВведите номер поезда для отображения информации:");
        int selectedTrainNumber = int.Parse(Console.ReadLine());
        bool found = false;
        foreach (var train in trains)
        {
            if (train.TrainNumber == selectedTrainNumber)
            {
                train.DisplayTrainInfo();
                found = true;
                break;
            }
        }
        if (!found)
        {
            Console.WriteLine($"Поезд с номером {selectedTrainNumber} не найден.");
        }
    }
}*/

/*using System;

class NumbersHandler
{
    private int number1;
    private int number2;

    public void SetNumbers(int num1, int num2)
    {
        number1 = num1;
        number2 = num2;
    }

    public void DisplayNumbers()
    {
        Console.WriteLine($"Первое число: {number1}");
        Console.WriteLine($"Второе число: {number2}");
    }

    public int CalculateSum()
    {
        return number1 + number2;
    }

    public int FindMax()
    {
        return Math.Max(number1, number2);
    }
}

class Program
{
    static void Main()
    {
        NumbersHandler handler = new NumbersHandler();

        Console.Write("Введите первое число: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите второе число: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        handler.SetNumbers(num1, num2);

        int sum = handler.CalculateSum();
        Console.WriteLine($"Сумма чисел: {sum}");

        int max = handler.FindMax();
        Console.WriteLine($"Наибольшее число: {max}");
    }
}

4 ЗАДАНИЕ
/*using System;
class Counter
{
    private int value;
    public Counter()
    {
        value = 0;
    }
    public Counter(int startValue)
    {
        value = startValue;
    }
    public int Value
    {
        get { return value; }
    }
    public void Increment()
    {
        value++;
    }
    public void Decrement()
    {
        value--;
    }
}
class Program
{
    static void Main()
    {
        Counter counter1 = new Counter(); // Counter with default value
        Counter counter2 = new Counter(10); // Counter with custom value
        Console.WriteLine("Начальное значение счетчика 1: " + counter1.Value);
        Console.WriteLine("Начальное значение счетчика 2: " + counter2.Value);
        counter1.Increment();
        counter2.Decrement();
        Console.WriteLine("Значение счетчика 1 после увеличения: " + counter1.Value);
        Console.WriteLine("Значение счетчика 2 после уменьшения: " + counter2.Value);
    }
}
5 ЗАДАНИЕ
using System;

class SuperClass
{
    public int Property1 { get; set; }
    public string Property2 { get; set; }

    public SuperClass(int sign1, string sign2)
    {
        Property1 = sign1;
        Property2 = sign2;
    }
    public SuperClass()
    {
        Property1 = 0;
        Property2 = "Default";
    }
    ~SuperClass()
    {
        Console.WriteLine("Объект удален.");
    }
    public void DisplayProperties()
    {
        Console.WriteLine($"Недвижимость 1: {Property1}");
        Console.WriteLine($"Недвижимость 2: {Property2}");
    }
}
class Program
{
    static void Main()
    {
        SuperClass myObject1 = new SuperClass(10, "ПРИВЕТ");
        myObject1.DisplayProperties();
        SuperClass myObject2 = new SuperClass();
        myObject2.DisplayProperties();
    }
}

УП Практическая работа 2.3
/*using System;

class Worker
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public double Rate { get; set; }
    public int Days { get; set; }

    public double GetSalary()
    {
        return Rate * Days;
    } 
}

class Program
{
    static void Main()
    {
        Worker worker = new Worker();
        Console.WriteLine("Введите имя сотрудника:");
        worker.Name = Console.ReadLine();
        Console.WriteLine("Введите фамилию сотрудника:");
        worker.Surname = Console.ReadLine();
        Console.WriteLine("Введите ставку за день:");
        worker.Rate = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите количество отработанных дней:");
        worker.Days = int.Parse(Console.ReadLine());
        Console.WriteLine(worker.Name + " " + worker.Surname + " заработал/а " + worker.GetSalary());
    }
}*/

/* using System;
  class Worker
  {
      private string name;
      private string surname;
      private double rate;
      private int days;
      public void SetName(string name)
      {
          this.name = name;
      }
      public string GetName()
      {
          return name;
      }
      public void SetSurname(string surname)
      {
          this.surname = surname;
      }
      public string GetSurname()
      {
          return surname;
      }
      public void SetRate(double rate)
      {
          this.rate = rate;
      }
      public double GetRate()
      {
          return rate;
      }
      public void SetDays(int days)
      {
          this.days = days;
      }
      public double GetSalary()
      {
          return rate * days;
      }
  }
  class Program
  {
      static void Main()
      {
          Worker worker = new Worker();
          Console.WriteLine("Введите имя сотрудника:");
          worker.SetName(Console.ReadLine());
          Console.WriteLine("Введите фамилию сотрудника:");
          worker.SetSurname(Console.ReadLine());
          Console.WriteLine("Введите ставку за день:");
          worker.SetRate(double.Parse(Console.ReadLine()));
          Console.WriteLine("Введите количество отработанных дней:");
          worker.SetDays(int.Parse(Console.ReadLine()));
          Console.WriteLine(worker.GetName() + " " + worker.GetSurname() + " заработал/а " + worker.GetSalary());
      }
  }*/


/*using System;

class Calculation
{
    public string calculationLine { get; set; }

    public void SetCalculationLine(string newLine)
    {
        calculationLine = newLine;
    }

    public void SetLastSymbolCalculationLine(char symbol)
    {
        calculationLine += symbol;
    }

    public string GetCalculationLine()
    {
        return calculationLine;
    }

    public char GetLastSymbol()
    {
        if (!string.IsNullOrEmpty(calculationLine))
        {
            return calculationLine[calculationLine.Length - 1];
        }
        return '\0'; // Return null character if calculationLine is empty
    }

    public void DeleteLastSymbol()
    {
        if (!string.IsNullOrEmpty(calculationLine))
        {
            calculationLine = calculationLine.Remove(calculationLine.Length - 1);
        }
    }
}

class Program
{
    static void Main()
    {
        Calculation calc = new Calculation();
        Console.WriteLine("Введите строку:");
        calc.SetCalculationLine(Console.ReadLine());

        Console.WriteLine("Введите символ для добавления:");
        char symbol = Console.ReadLine()[0];
        calc.SetLastSymbolCalculationLine(symbol);

        Console.WriteLine("Результат: " + calc.GetCalculationLine());
    }
}

УП Практическая работа 2.4

using System;

class Program
{
    static int RomanToInt(string s)
    {
        int result = 0;
        int prevValue = 0;

        foreach (char c in s)
        {
            int value = 0;

            switch (c)
            {
                case 'I':
                    value = 1;
                    break;
                case 'V':
                    value = 5;
                    break;
                case 'X':
                    value = 10;
                    break;
                case 'L':
                    value = 50;
                    break;
                case 'C':
                    value = 100;
                    break;
                case 'D':
                    value = 500;
                    break;
                case 'M':
                    value = 1000;
                    break;
            }

            if (value > prevValue)
            {
                result -= 2 * prevValue;
            }

            result += value;
            prevValue = value;
        }

        return result;
    }

    static void Main()
    {
        Console.WriteLine("Введите римское число:");
        string romanNumber = Console.ReadLine();
        Console.WriteLine($"Римское число {romanNumber} равно {RomanToInt(romanNumber)} в арабском формате.");
    }
}
*/


