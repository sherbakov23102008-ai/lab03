using System;
using System.Text;

int number = 305419896;
Console.WriteLine($"Число: {number}");
Console.WriteLine($"Hex: 0x{number:X8}");
Console.WriteLine("Байты числа: " + BitConverter.ToString(BitConverter.GetBytes(number)));
Console.WriteLine("Little-endian: " + BitConverter.IsLittleEndian);

foreach (int value in new[] { 1, 256, 65536 })
    Console.WriteLine($"{value} -> {BitConverter.ToString(BitConverter.GetBytes(value))}");

foreach (string value in new[] { "ABC", "Привет" })
{
    byte[] bytes = Encoding.UTF8.GetBytes(value);
    Console.WriteLine($"{value}: символов {value.Length}, байтов UTF-8 {bytes.Length}, байты {BitConverter.ToString(bytes)}");
}

Console.WriteLine("Латинская A: " + BitConverter.ToString(Encoding.UTF8.GetBytes("A")));
Console.WriteLine("Кириллическая А: " + BitConverter.ToString(Encoding.UTF8.GetBytes("А")));

string originalText = "Привет";
Console.WriteLine("Восстановленный текст: " + Encoding.UTF8.GetString(Encoding.UTF8.GetBytes(originalText)));
int restored = BitConverter.ToInt32(BitConverter.GetBytes(number));
Console.WriteLine("Восстановленное число: " + restored);
Console.WriteLine("41-42-43 как UTF-8: " + Encoding.UTF8.GetString(new byte[] { 0x41, 0x42, 0x43 }));
