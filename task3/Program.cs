int[] arr = Console.ReadLine()
                .Split(',', ' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

Console.Write("[");
Console.Write(string.Join(", ", arr));
Console.Write("]");
