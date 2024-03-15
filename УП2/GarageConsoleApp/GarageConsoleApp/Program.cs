namespace GarageConsoleApp;

using System;
using System.Data.SqlClient;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("1. Добавить тип транспортного средства");
            Console.WriteLine("2. Добавить водителя");
            Console.WriteLine("3. Добавить автомобиль");
            Console.WriteLine("4. Добавить маршрут");
            Console.WriteLine("5. Добавить рейс");
            Console.WriteLine("6. Добавить категорию прав водителю");
            Console.WriteLine("7. Добавить категорию прав");
            Console.WriteLine("8. Просмотреть тип транспортного средства");
            Console.WriteLine("9. Просмотреть водителя");
            Console.WriteLine("10. Просмотреть автомобиль");
            Console.WriteLine("11. Просмотреть маршрут");
            Console.WriteLine("12. Просмотреть рейс");
            Console.WriteLine("13. Просмотреть категорию прав водителю");
            Console.WriteLine("14. Просмотреть категорию прав");
            Console.WriteLine("0. Выход");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Введите тип машины:");
                    string typeCar = Console.ReadLine();
                    DatabaseRequests.AddTypeCarQuery(typeCar);
                    break;

                case "2":
                    Console.WriteLine("Введите имя водителя:");
                    string name = Console.ReadLine();
                    Console.WriteLine("Введите фамилию водителя:");
                    string surname = Console.ReadLine();
                    Console.WriteLine("Введите дату рождения водителя:");
                    DateTime dateOfBirth = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", null);
                    DatabaseRequests.AddDriverQuery(name, surname, dateOfBirth);
                    break;
                
                case "3"://Добавить автомобиль
                    Console.WriteLine("Введите id типа машины:");
                    int idTypeCar = int.Parse(Console.ReadLine()); //поменять;
                    Console.WriteLine("Введите название авто:");
                    string nameCar = Console.ReadLine();
                    Console.WriteLine("Введите номер машины");
                    string numCar = Console.ReadLine();
                    Console.WriteLine("Введите вместимость машины:");
                    int numsSeats = int.Parse(Console.ReadLine());
                    DatabaseRequests.AddCarQuery(idTypeCar, nameCar, numCar, numsSeats);
                    break;
                
                case "4":
                    Console.WriteLine("Введите маршрут автомобиля:");
                    string itinerary = Console.ReadLine();
                    DatabaseRequests.AddItineraryQuery(itinerary);
                    break;
                
                case "5":
                    Console.WriteLine("Введите id водитея:");
                    int idDriver = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите id машины:");
                    int idCar = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите id маршрута:");
                    int idItinerary = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите количество пассажиров:");
                    int passNum = int.Parse(Console.ReadLine());
                    DatabaseRequests.AddRouteQuery(idDriver, idCar, idItinerary, passNum);
                    break;
                
                case "6":
                    Console.WriteLine("Введите id водителя:");
                    int idDrivers = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите id категории прав:");
                    string rightsСategory = Console.ReadLine();
                    DatabaseRequests.AddDriverRightsCategoryQuery(idDrivers, rightsСategory); 
                    break;
                
                case "7":
                    Console.WriteLine("Введите название категорию прав:");
                    string category = Console.ReadLine();
                    DatabaseRequests.AddRightsCategoryQuery(category);
                    break;
                
                case "8":
                    // Вызовем метод для получения данных о типах автомобилей
                    DatabaseRequests.GetTypeCarQuery();
                    Console.WriteLine();
                    break;

                case "9"://Просмотреть водителя
                    DatabaseRequests.GetDriverQuery();
                    Console.WriteLine();
                    break;
                
                case "10"://Просмотреть автомобиль
                    DatabaseRequests.GetCarQuery();
                    Console.WriteLine();
                    break;
                
                case "11"://Просмотреть маршрут
                    DatabaseRequests.GetItineraryQuery();
                    Console.WriteLine();
                    break;
                
                case "12"://Просмотреть рейс
                    DatabaseRequests.GetRouteQuery();
                    Console.WriteLine();

                    break;
                case "13"://Просмотреть категорию прав водителю
                    DatabaseRequests.GetDriverRightsCategoryQuery();
                    Console.WriteLine();
                    break;
                
                case "14":// Добавить категорию прав
                    DatabaseRequests.GetRightsCategoryQuery();
                    Console.WriteLine();
                    break;
                
                case "0":
                    return;
                
                default:
                    Console.WriteLine("Неверный ввод");
                    break;

            }

        }
    }
}
