using Npgsql;

namespace GarageConsoleApp;

/// <summary>
/// Класс DatabaseRequests
/// содержит методы для отправки запросов к БД
/// </summary>
public static class DatabaseRequests
{
    /// <summary>
    /// Метод GetTypeCarQuery
    /// отправляет запрос в БД на получение списка типов машин
    /// выводит в консоль список типов машин
    /// </summary>
    public static void GetTypeCarQuery()
    {
        // Сохраняем в переменную запрос на получение всех данных и таблицы type_car
        var querySql = "SELECT * FROM type_car";
        // Создаем команду(запрос) cmd, передаем в нее запрос и соединение к БД
        using var cmd = new NpgsqlCommand(querySql, DatabaseService.GetSqlConnection());
        // Выполняем команду(запрос)
        // результат команды сохранится в переменную reader
        using var reader = cmd.ExecuteReader();
        
        // Выводим данные которые вернула БД
        while (reader.Read())
        {
            Console.WriteLine($"Id: {reader[0]} Название: {reader[1]}");
        }
    }
   
    /// <summary>
    /// Метод AddTypeCarQuery
    /// отправляет запрос в БД на добавление типа машины
    /// </summary>
    public static void AddTypeCarQuery(string name)
    {
        var querySql = $"INSERT INTO type_car(name) VALUES ('{name}')";
        using var cmd = new NpgsqlCommand(querySql, DatabaseService.GetSqlConnection());
        cmd.ExecuteNonQuery();
    }
    
    public static void AddCarQuery(int id,string nameCar,string numCar, int numsSeats)//Добавить автомобиль
    {
        var querySql = $"INSERT INTO car(id_type_car, name, state_number, number_passengers) VALUES ('{id}', '{nameCar}', '{numCar}', '{numsSeats}')";
        using var cmd = new NpgsqlCommand(querySql, DatabaseService.GetSqlConnection());
        cmd.ExecuteNonQuery(); 
    }
    public static void AddItineraryQuery(string itinerary)
    {
        var querySql = $"INSERT INTO itinerary(name) VALUES ('{itinerary}')";
        using var cmd = new NpgsqlCommand(querySql, DatabaseService.GetSqlConnection());
        cmd.ExecuteNonQuery(); 
    }
    public static void AddRouteQuery(int idDriver,int idCar, int idItinerary, int passNum)
    {
        var querySql = $"INSERT INTO route(id_driver, id_car, id_itinerary, number_passengers) VALUES ('{idDriver}', '{idCar}', '{idItinerary}', '{passNum}')";
        using var cmd = new NpgsqlCommand(querySql, DatabaseService.GetSqlConnection());
        cmd.ExecuteNonQuery(); 
    }
    
    public static void AddDriverRightsCategoryQuery(int idDrivers, string rightsСategory)//6
    {
        var querySql = $"INSERT INTO route(id_driver, id_rights_category) VALUES ('{idDrivers}', '{rightsСategory}')";
        using var cmd = new NpgsqlCommand(querySql, DatabaseService.GetSqlConnection());
        cmd.ExecuteNonQuery(); 
    }
    
    public static void AddRightsCategoryQuery(string category)//7
    {
        var querySql = $"INSERT INTO route(name) VALUES ('{category}')";
        using var cmd = new NpgsqlCommand(querySql, DatabaseService.GetSqlConnection());
        cmd.ExecuteNonQuery(); 
    }


    /// <summary>
    /// Метод AddDriverQuery
    /// отправляет запрос в БД на добавление водителей
    /// </summary>
    public static void AddDriverQuery(string firstName, string lastName, DateTime birthdate)
    {
        var querySql = $"INSERT INTO driver(first_name, last_name, birthdate) VALUES ('{firstName}', '{lastName}', '{birthdate}')";
        using var cmd = new NpgsqlCommand(querySql, DatabaseService.GetSqlConnection());
        cmd.ExecuteNonQuery();
    }

    /// <summary>
    /// Метод GetDriverQuery
    /// отправляет запрос в БД на получение списка водителей
    /// выводит в консоль данные о водителях
    /// </summary>
    public static void GetDriverQuery()
    {
        var querySql = "SELECT * FROM driver";
        using var cmd = new NpgsqlCommand(querySql, DatabaseService.GetSqlConnection());
        using var reader = cmd.ExecuteReader();

        while (reader.Read())
        {
            Console.WriteLine($"Id: {reader[0]} Имя: {reader[1]} Фамилия: {reader[2]} Дата рождения: {reader[3]}");
        }
    }
    /// <summary>
    /// ///////////summary
    /// podymai
    public static void GetCarQuery()
    {
        var querySql = "SELECT * FROM car";
        using var cmd = new NpgsqlCommand(querySql, DatabaseService.GetSqlConnection());
        using var reader = cmd.ExecuteReader();

        while (reader.Read())
        {
            Console.WriteLine($"Id: {reader[0]} Id типа машины: {reader[1]} Название: {reader[2]} Номер машины: {reader[3]} Количество пассажиров: {reader[4]}");
        }
    }
    
    public static void GetItineraryQuery()
    {
        var querySql = "SELECT * FROM itinerary";
        using var cmd = new NpgsqlCommand(querySql, DatabaseService.GetSqlConnection());
        using var reader = cmd.ExecuteReader();

        while (reader.Read())
        {
            Console.WriteLine($"Id: {reader[0]} Название маршрутов: {reader[1]}");
        }
    }
    public static void GetRouteQuery()
    {
        var querySql = "SELECT * FROM route";
        using var cmd = new NpgsqlCommand(querySql, DatabaseService.GetSqlConnection());
        using var reader = cmd.ExecuteReader();

        while (reader.Read())
        {
            Console.WriteLine($"Id: {reader[0]} id водителя: {reader[1]} id машины: {reader[2]} id маршрута: {reader[3]} количество пассажиров: {reader[4]}");
        }
    }
    

    /// <summary>
    /// Метод AddRightsCategoryQuery
    /// отправляет запрос в БД на добавление категорий прав
    /// </summary>
   
    
    // поолучение списка категории прав
    public static void GetRightsCategoryQuery()
    {
        var querySql = "SELECT * FROM rights_category";
        using var cmd = new NpgsqlCommand(querySql, DatabaseService.GetSqlConnection());
        using var reader = cmd.ExecuteReader();

        while (reader.Read())
        {
            Console.WriteLine($"Id: {reader[0]} Категория прав: {reader[1]} ");
        }
    }

    /// <summary>
    /// Метод AddDriverRightsCategoryQuery
    /// отправляет запрос в БД на добавление категории прав водителю
    /// </summary>
    public static void AddDriverRightsCategoryQuery(int driver, int rightsCategory)
    {
        var querySql = $"INSERT INTO driver_rights_category(id_driver, id_rights_category) VALUES ({driver}, {rightsCategory})";
        using var cmd = new NpgsqlCommand(querySql, DatabaseService.GetSqlConnection());
        cmd.ExecuteNonQuery();
    }

    /// <summary>
    /// Метод GetDriverRightsCategoryQuery
    /// отправляет запрос в БД на получение категорий водителей
    /// выводит в консоль информацию о категориях прав водителей
    /// </summary>
    public static void GetDriverRightsCategoryQuery()
    {
        var querySql = "SELECT dr.first_name, dr.last_name, rc.name " +
                       "FROM driver_rights_category " +
                       "INNER JOIN driver dr on driver_rights_category.id_driver = dr.id " +
                       "INNER JOIN rights_category rc on rc.id = driver_rights_category.id_rights_category;";
                      
        using var cmd = new NpgsqlCommand(querySql, DatabaseService.GetSqlConnection());
        using var reader = cmd.ExecuteReader();

        while (reader.Read())
        {
            Console.WriteLine($"Имя: {reader[0]} Фамилия: {reader[1]} Категория прав: {reader[2]}");
        }
    }
}