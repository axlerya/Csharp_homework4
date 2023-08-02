Console.WriteLine("Введите два числа");
int numberInputOne = Convert.ToInt32(Console.ReadLine());
int numberInputTwo = Convert.ToInt32(Console.ReadLine());
int x = (int)Math.Pow(numberInputOne, numberInputTwo);
Console.WriteLine($"Число {numberInputOne} в степени {numberInputTwo} = {x}");