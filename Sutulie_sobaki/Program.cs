 // Считать от пользователя данные
int GetNumberByUser(string text)
{
    Console.WriteLine(text + ": ");
    return Convert.ToInt32(Console.ReadLine());
}

// Создание массива
int[] CreateArray(int size)
{
   return new int[size+1]; 
}
 
 
 void FillArray(int[] collection)      // Метод заполнения массива случайными числами от 0 до 1
{
    int length = collection.Length;
    int index = 1;
    collection[0] = 1;
    while (index < length)
    {
        collection[index] = Random.Shared.Next(2); 
        index++;
    }
}

string PrintArray(int[] collection)     // Метод печати массива
{
    string output = String.Empty;
    int size = collection.Length;
    for (int i = 0; i < collection.Length; i++)
    {
        output = output + $"{collection[i]} ";
    }
    return output;
} 

int toDecimal(int[] collection)              //переводим в десятичную из двоичной
{
int count = collection.Length;
int exponent = collection.Length - 1; 
int result = 0;
for (int i = 0; i < collection.Length; i++)
{
    if (collection[i] == 1)
    {
        result += Convert.ToInt32(Math.Pow(2, exponent));
    }
    exponent--;
}
return result;
}

string GoodPrint(int[] collection, int dec)     //Красиво печатаем результат
{
    return $"{String.Join("", collection)} >> {dec}";
}

int countByUser = GetNumberByUser("Введите N");
int[] array = CreateArray(countByUser);
FillArray(array);                     // Вызов метода заполнения  массива
PrintArray(array);                    // Вызов метода печати массива
int result = toDecimal(array);        //кладем результат конвертации в int
string decNumber = PrintArray(array); // делаем строку из результата распечатки
Console.WriteLine(decNumber);            
Console.WriteLine(GoodPrint(array, result));


