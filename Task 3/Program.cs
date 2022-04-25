// Напишите программу, которая будет выдавать
//название дня недели по заданному номеру.
//3 -> Среда
//5 -> Пятница
string dayWeek = Console.ReadLine();
if(dayWeek == "1") Console.WriteLine("понедельник");
else if(dayWeek == "2") Console.WriteLine("вторник");
else if(dayWeek == "3") Console.WriteLine("среда");
else if(dayWeek == "4") Console.WriteLine("четверг");
else if(dayWeek == "5") Console.WriteLine("пятница");
else if(dayWeek == "6") Console.WriteLine("суббота");
else if(dayWeek == "7") Console.WriteLine("воскресенье");
else Console.WriteLine("Ошибка ввода !");
