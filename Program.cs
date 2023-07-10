

using WebApi_DaData;

Console.WriteLine("Введите ИНН Организации для проверки");
Console.WriteLine("'q' или 'quit' для выхода");

string inputVal = Console.ReadLine()
    .ToLower();

DaDataHelper daData = new DaDataHelper();

while (inputVal != "q" && inputVal != "quit")
{
    var info = daData.GetInfoForINN(inputVal).Result;

    Console.WriteLine(info);

    inputVal = Console.ReadLine()
    .ToLower();


}

Console.WriteLine("До Свидания, Пользователь.");