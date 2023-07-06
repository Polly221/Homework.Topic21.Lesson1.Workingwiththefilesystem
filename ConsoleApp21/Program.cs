using System.IO;

Console.Write("Введите путь к первому файлу: ");
string firstFilePath = Console.ReadLine()! + ".txt";
FileInfo firstFileInfo = new FileInfo(firstFilePath);

Console.Write("Введите содержимое первого файла: ");
string contentFirstFile = Console.ReadLine()!;
await File.WriteAllTextAsync(firstFilePath, contentFirstFile);

Console.WriteLine("Файл успешно записан");

Console.Write("Введите путь ко второму файлу: ");
string secondFilePath = Console.ReadLine()! + ".txt";
FileInfo secondFileInfo = new FileInfo(secondFilePath);

Console.Write("Введите содержимое второго файла: ");
string contentSecondFile = Console.ReadLine()!;
await File.WriteAllTextAsync(secondFilePath, contentSecondFile);

Console.Write("Введите путь к третьему файлу: ");
string thirdFilePath = Console.ReadLine()! + ".txt";
FileInfo thirdFileInfo = new FileInfo(thirdFilePath);

Console.Write("Введите содержимое третьего файла: ");
string contentThirdFile = Console.ReadLine()!;
await File.WriteAllTextAsync(thirdFilePath, contentThirdFile);

Console.Write($"Содержимое первого файла: {contentFirstFile}");