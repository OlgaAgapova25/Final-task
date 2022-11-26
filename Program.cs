// написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно задать с клавиатуры либо ввести на старте выполнения алгоритма. 

Console.Clear();
Main();

void Main()
{
string[] initialArray = {"1234", "-2", "w d", ":-)"};
string[] newArray = new string[initialArray.Length];
int limitForNumberOfSymbols = 3;
newArray = ArrayLimitedSymbolsNumber(initialArray, newArray, limitForNumberOfSymbols);
PrintArray(newArray);
}

string[] ArrayLimitedSymbolsNumber (string[] initialArray, string[] newArray, int numberOfSymbols)
{
int count = 0;
for (int i = 0; i < initialArray.Length; i++)
{
    if (initialArray[i].Length <= numberOfSymbols)
    {
        newArray[count] = initialArray[i];
        count++;
    }
}
Array.Resize(ref newArray, count);
return newArray;
}

void PrintArray(string[] array)
{
int count = array.Length;
for (int i = 0; i < count-1; i++)
{
    Console.Write($"{array[i]}, ");
}
Console.Write(array[count-1]);
}