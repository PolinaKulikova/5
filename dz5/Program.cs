int[] array = { 3, 2, 1, 4, 5, 6, 3, 1 };                         // Ввела массив вручную, чтобы проверить метод умножения
int count = array.Length / 2;


int[] multiplication(int[] array)
{
        for (int i = 0; i < array.Length / 2; i++)                // Не понимаю, почему цикл не останавливается на i = 4
        {
             array[i] = array[i] * array[array.Length - 1 - i];
        }
        return array;

    }


void PrintArray(int[] collection)     // Метод печати массива
{
    int count = collection.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(collection[position]);
        position++;
    }
}


int[] resultOfmultiplication = multiplication(array);
PrintArray(array);

