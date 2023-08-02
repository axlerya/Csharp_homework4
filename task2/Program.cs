int[] GetIntArray(int num) //перевод числа в массив 
{
    List<int> listOfInts = new();
    while(num > 0)
    {
        listOfInts.Add(num % 10);
        num /= 10;
    }
    listOfInts.Reverse();
    int[] arrayNumbersOne = listOfInts.ToArray();
    return arrayNumbersOne;
}

Console.WriteLine("Введите число");
int numberInput = Convert.ToInt32(Console.ReadLine());

int[] arr = GetIntArray(numberInput);
int sum = 0;
for (int i = 0; i < arr.Length; i++)
{
    sum += arr[i];
}

Console.WriteLine(sum);