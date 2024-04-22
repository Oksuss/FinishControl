//Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
//длина которых меньше, либо равна 3 символам. 
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
string[] MyString;
Console.WriteLine("Введите массив строк через запятую"); 
string stroka = Console.ReadLine(); 
MyString = stroka.Split(',');
var result = new string[MyString .Length];
var realSize = 0;
foreach (var value in MyString )
{
    if (value.Length <= 3)
    {
        result[realSize] = value;
        realSize++;
    }
}