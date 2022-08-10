// [TASK - 1]
/*
- Создать консольное приложение:
    -Приложение должно создавать массив целых чисел, размер которого должен задавать пользователь с клавиатуры.
*/




 int input = Convert.ToInt32(Console.ReadLine());

int[] array = new int[input];


//int[] array = { 55, 77, 95, 23, 12, 44, 86, 34, 9, 73 };

// [TASK - 2]
/*
- Массив необходимо заполнить произвольными целыми числами (для генерации чисел нужно использовать     Random rand = new Random();
int value = rand.Next(-100, 100);). Сгенерированный массив необходимо вывести на экран

// TASK2-1*
NB!
* Выполнить сортировку элементов массива по убыванию и вывести результат на экран,
  без использования методов класса Array.

[55, 77, 95, 23, 12, 44, 86, 34, 9, 73]

*/




for (int i = 0; i < array.Length - 1; i++)
{
    Random rand = new Random();
    int value = rand.Next(-100, 100);

    array[i] = value;

}




int verify = 0;

for (int i = 0; i < array.Length; i++)
{
    for (int j = 0; j < array.Length - 1; j++)
    {
        if (array[j] < array[j + 1])
        {
            verify = array[j + 1];
            array[j + 1] = array[j];
            array[j] = verify;
        }
    }


}




Console.WriteLine("[{0}]", string.Join(", ", array));


// [TASK - 3]
/*
- С помощью математических операций, условий и циклов на консоль необходимо вывести наибольшее значение в массиве,
 наименьшее значение в массиве, общую сумму всех элементов, среднее арифметическое всех элементов.
 Вычисленные значения необходимо вывести на экран
- Программа должна ожидать нажатия клавиши клавиатуры для завершения работы программы.


/*
int biggestNum = 0;
int smallestNum = 0;
int arraySum = 0;
float arrayAvg = 0;

for (int i = 0; i < array.Length - 1; i++)
{
    if (biggestNum < array[i]) biggestNum = array[i];               // Получаем самое большое число

    if (smallestNum > array[i]) smallestNum = array[i];             // Получаем самое мальенькое число

    arraySum += array[i];                                           // получаем сумму всех элементов в массиве.

    arrayAvg = (float)arraySum / (float)input;                      // Получаем арифметическое среднее массива 
}

Console.WriteLine($"Наибольшое число: {biggestNum}  Наименьшее число: {smallestNum}  Сумма массива: {arraySum}  арифметическое средняя: {arrayAvg}$");
Console.ReadLine();
*/








//[TASK - 4]
/*
- Создать программу-переводчик, которая знает 10 английских слов.
Пользователь должен ввести слово на английском, программа выводит перевод на русском.
В случае если слова нет, то нужно вывести на консоль сообщение "Слово не было найдено".
Для решения задачи можно использовать класс Dictionary<string, string> и методы этого класса, такие как ContainsKey()....
*/

/*
Dictionary<string, string> vocabulary = new Dictionary<string, string>(){
    {"Car", "Машина"},
    {"Person", "Человек"},
    {"Love", "Любовь"},
    {"Future", "Будущие"},
    {"Might", "Мощь"},
    {"Keyboard", "Клавиатура"},
    {"Beer", "Пиво"},
    {"Vodka", "Водка"},
    {"Whisky", "Виски"},
    {"Dog", "Собака"},

    {"car", "Машина"},
    {"person", "Человек"},
    {"love", "Любовь"},
    {"future", "Будущие"},
    {"might", "Мощь"},
    {"keyboard", "Клавиатура"},
    {"beer", "Пиво"},
    {"vodka", "Водка"},
    {"whisky", "Виски"},
    {"dog", "Собака"}
};

while (true)
{
    string word = Console.ReadLine();
    if (vocabulary.ContainsKey(word))
    {
        Console.WriteLine(vocabulary[word]);
    }
    else Console.WriteLine("Слово не было найдено");

}
*/


// TASK2-1*
/*
NB!
* Выполнить сортировку элементов массива по убыванию и вывести результат на экран,
  без использования методов класса Array.

*/



































































































































