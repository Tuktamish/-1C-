class LabWork
{
    // 1. Сумма знаков
    public int sumLastNums(int x)
    {
        int lastDigit = x % 10; // Последняя цифра
        int secondLastDigit = (x / 10) % 10; // Предпоследняя цифра
        return lastDigit + secondLastDigit;
    }

    // 2. Есть ли позитив
    public bool isPositive(int x)
    {
        return x > 0;
    }

    // 3. Большая буква
    public bool isUpperCase(char x)
    {
        return x >= 'A' && x <= 'Z';
    }

    // 4. Делитель
    public bool isDivisor(int a, int b)
    {
        return (b != 0) && (a % b == 0 || b % a == 0);
    }

    // 5. Многократный вызов
    public int lastNumSum(int a, int b)
    {
        return (a % 10) + (b % 10);
    }

    // 6. Безопасное деление
    public double safeDiv(int x, int y)
    {
        if (y == 0)
            return 0;
        return (double)x / y;
    }

    // 7. Строка сравнения
    public string makeDecision(int x, int y)
    {
        if (x > y) return $"{x} > {y}";
        if (x < y) return $"{x} < {y}";
        return $"{x} == {y}";
    }

    // 8. Тройная сумма
    public bool sum3(int x, int y, int z)
    {
        return (x + y == z) || (x + z == y) || (y + z == x);
    }

    // 9. Возраст
    public string age(int x)
    {
        string suffix;
        if (x % 100 >= 11 && x % 100 <= 14)
        {
            suffix = "лет";
        }
        else if (x % 10 == 1)
        {
            suffix = "год";
        }
        else if (x % 10 >= 2 && x % 10 <= 4)
        {
            suffix = "года";
        }
        else
        {
            suffix = "лет";
        }
        return $"{x} {suffix}";
    }

    // 10. Вывод дней недели
    public void printDays(string day)
    {
        string[] days = { "понедельник", "вторник", "среда", "четверг", "пятница", "суббота", "воскресенье" };
        int index = Array.IndexOf(days, day.ToLower());

        if (index == -1)
        {
            Console.WriteLine("Это не день недели");
            return;
        }

        for (int i = index; i < days.Length; i++)
        {
            Console.WriteLine(days[i]);
        }
    }

    // 11. Числа наоборот
    public string reverseListNums(int x)
    {
        string result = "";
        for (int i = x; i >= 0; i--)
        {
            result += i + " ";
        }
        return result.Trim();
    }

    // 12. Степень числа
    public int pow(int x, int y)
    {
        int result = 1;
        for (int i = 0; i < y; i++)
        {
            result *= x;
        }
        return result;
    }

    // 13. Одинаковость
    public bool equalNum(int x)
    {
        int lastDigit = x % 10;
        x /= 10;

        while (x > 0)
        {
            if (x % 10 != lastDigit)
            {
                return false;
            }
            x /= 10;
        }
        return true;
    }

    public void leftTriangle(int x)
    {
        for (int i = 1; i <= x; i++)
        {
            Console.WriteLine(new string('*', i));
        }
    }

    // 15. Угадайка
    public void guessGame()
    {
        Random random = new Random();
        int randomNumber = random.Next(0, 10);
        int attempts = 0;
        int userGuess = -1;

        Console.WriteLine("Введите число от 0 до 9:");

        while (userGuess != randomNumber)
        {
            userGuess = int.Parse(Console.ReadLine());
            attempts++;

            if (userGuess < 0 || userGuess > 9)
            {
                Console.WriteLine("Пожалуйста, введите число от 0 до 9:");
                continue;
            }

            if (userGuess == randomNumber)
            {
                Console.WriteLine("Вы угадали!");
            }
            else
            {
                Console.WriteLine("Вы не угадали, введите число от 0 до 9:");
            }
        }

        Console.WriteLine($"Вы отгадали число за {attempts} попытки(ок).");
    }

    public int findLast(int[] arr, int x)
    {
        for (int i = arr.Length - 1; i >= 0; i--)
        {
            if (arr[i] == x)
            {
                return i;
            }
        }
        return -1; // Если элемент не найден
    }

    // 17. Добавление в массив
    public int[] add(int[] originalArray, int x, int pos)
    {
        // Проверка корректности позиции
        if (pos < 0 || pos > originalArray.Length)
        {
            throw new ArgumentOutOfRangeException("Position is out of range.");
        }

        int[] newArray = new int[originalArray.Length + 1];

        for (int i = 0; i < pos; i++)
        {
            newArray[i] = originalArray[i];
        }

        newArray[pos] = x;

        for (int i = pos; i < originalArray.Length; i++)
        {
            newArray[i + 1] = originalArray[i];
        }

        return newArray;
    }

    public void reverse(int[] arr)
    {
        int left = 0;
        int right = arr.Length - 1;

        while (left < right)
        {
            // Меняем местами элементы
            int temp = arr[left];
            arr[left] = arr[right];
            arr[right] = temp;

            left++;
            right--;
        }
    }
    public int[] concat(int[] arr1, int[] arr2)
    {
        int[] result = new int[arr1.Length + arr2.Length];
        Array.Copy(arr1, result, arr1.Length);
        Array.Copy(arr2, 0, result, arr1.Length, arr2.Length);
        return result;
    }
    // 20. Удалить негатив
    public int[] deleteNegative(int[] inputArray)
    {
        int count = 0;

        // Подсчет количества положительных элементов
        foreach (int number in inputArray)
        {
            if (number >= 0)
            {
                count++;
            }
        }

        int[] resultArray = new int[count];
        int index = 0;

        // Заполнение нового массива положительными элементами
        foreach (int number in inputArray)
        {
            if (number >= 0)
            {
                resultArray[index++] = number;
            }
        }

        return resultArray;
    }

    static void Main(string[] args)
    {
        LabWork labWork = new LabWork();

        Console.WriteLine("Выберите задачу:\n" +
                     "Задание 1:\n" +
                     "1 - 2 Сумма знаков\n" +
                     "2 - 4 Есть ли позитив\n" +
                     "3 - 6 Большая буква\n" +
                     "4 - 8 Делитель\n" +
                     "5 - 10 Многократный вызов\n" +
                     "Задание 2:\n" +
                     "6 - 2 Безопасное деление\n" +
                     "7 - 4 Строка сравнения\n" +
                     "8 - 6 Тройная сумма\n" +
                     "9 - 8 Возраст\n" +
                     "10 - 10 Вывод дней недели\n" +
                     "Задание 3:\n" +
                     "11 - 2 Числа наоборот\n" +
                     "12 - 4 Степень числа\n" +
                     "13 - 6 Одинаковость\n" +
                     "14 - 8 Левый треугольник\n" +
                     "15 - 10 Угадайка\n" +
                     "Задание 4:\n" +
                     "16 - 2 Поиск последнего значения\n" +
                     "17 - 4 Добавление в массив\n" +
                     "18 - 6 Реверс\n" +
                     "19 - 8 Объединение\n" +
                     "20 - 10 Удалить негатив");

        int choice;
        if (int.TryParse(Console.ReadLine(), out choice))
        {
            switch (choice)
            {
                case 1:
                    Console.Write("Введите число: ");
                    int sumInput = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Сумма последних знаков: {labWork.sumLastNums(sumInput)}");
                    break;
                case 2:
                    Console.Write("Введите число: ");
                    int posInput = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Положительное: {labWork.isPositive(posInput)}");
                    break;
                case 3:
                    Console.Write("Введите символ: ");
                    char upperInput = Console.ReadKey().KeyChar;
                    Console.WriteLine($"\nБольшая буква: {labWork.isUpperCase(upperInput)}");
                    break;
                case 4:
                    Console.Write("Введите два числа (a b): ");
                    int a = int.Parse(Console.ReadLine());
                    int b = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Делитель: {labWork.isDivisor(a, b)}");
                    break;
                case 5:
                    Console.Write("Введите два числа (a b): ");
                    int a2 = int.Parse(Console.ReadLine());
                    int b2 = int.Parse(Console.ReadLine());
                    int resultSum = labWork.lastNumSum(a2, b2);
                    Console.WriteLine($"Сумма единиц: {resultSum}");
                    break;
                case 6:
                    Console.Write("Введите два числа (x y): ");
                    int x = int.Parse(Console.ReadLine());
                    int y = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Результат деления: {labWork.safeDiv(x, y)}");
                    break;
                case 7:
                    Console.Write("Введите два числа (x y): ");
                    int x2 = int.Parse(Console.ReadLine());
                    int y2 = int.Parse(Console.ReadLine());
                    Console.WriteLine(labWork.makeDecision(x2, y2));
                    break;
                case 8:
                    Console.Write("Введите три числа (x y z): ");
                    int x3 = int.Parse(Console.ReadLine());
                    int y3 = int.Parse(Console.ReadLine());
                    int z3 = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Можно сложить: {labWork.sum3(x3, y3, z3)}");
                    break;
                case 9:
                    Console.Write("Введите возраст: ");
                    int ageInput = int.Parse(Console.ReadLine());
                    Console.WriteLine(labWork.age(ageInput));
                    break;
                case 10:
                    Console.Write("Введите день недели: ");
                    string dayInput = Console.ReadLine();
                    labWork.printDays(dayInput);
                    break;
                case 11:
                    Console.Write("Введите число: ");
                    int reverseInput = int.Parse(Console.ReadLine());
                    string result = labWork.reverseListNums(reverseInput);
                    Console.WriteLine(result);
                    break;
                case 12:
                    Console.Write("Введите основание и степень (x y): ");
                    int baseNum = int.Parse(Console.ReadLine());
                    int exponent = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Результат: {labWork.pow(baseNum, exponent)}");
                    break;
                case 13:
                    Console.Write("Введите число: ");
                    int equalInput = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Все знаки одинаковы: {labWork.equalNum(equalInput)}");
                    break;
                case 14:
                    Console.Write("Введите высоту треугольника: ");
                    int triangleHeight = int.Parse(Console.ReadLine());
                    labWork.leftTriangle(triangleHeight);
                    break;
                case 15:
                    labWork.guessGame();
                    break;
                case 16:
                    Console.Write("Введите размер массива: ");
                    int size = int.Parse(Console.ReadLine());
                    int[] arr = new int[size];

                    Console.WriteLine("Введите элементы массива:");
                    for (int i = 0; i < size; i++)
                    {
                        arr[i] = int.Parse(Console.ReadLine());
                    }

                    Console.Write("Введите число для поиска: ");
                    int searchValue = int.Parse(Console.ReadLine());

                    int lastIndex = labWork.findLast(arr, searchValue);
                    Console.WriteLine($"Индекс последнего вхождения: {lastIndex}");
                    break;
                case 17:
                    Console.Write("Введите размер массива: ");
                    int originalSize = int.Parse(Console.ReadLine());
                    int[] originalArray = new int[originalSize];

                    Console.WriteLine("Введите элементы массива:");
                    for (int i = 0; i < originalSize; i++)
                    {
                        originalArray[i] = int.Parse(Console.ReadLine());
                    }

                    Console.Write("Введите значение для добавления: ");
                    int addValue = int.Parse(Console.ReadLine());
                    Console.Write("Введите позицию для добавления: ");
                    int position = int.Parse(Console.ReadLine());

                    int[] newArr = labWork.add(originalArray, addValue, position);
                    Console.WriteLine("Новый массив: " + string.Join(", ", newArr));
                    break;
                case 18:
                    Console.Write("Введите размер массива: ");
                    int reverseArraySize = int.Parse(Console.ReadLine());
                    int[] reverseArray = new int[reverseArraySize];

                    Console.WriteLine("Введите элементы массива:");
                    for (int i = 0; i < reverseArraySize; i++)
                    {
                        reverseArray[i] = int.Parse(Console.ReadLine());
                    }

                    labWork.reverse(reverseArray);
                    Console.WriteLine("Массив после реверса: " + string.Join(", ", reverseArray));
                    break;
                case 19:
                    Console.Write("Введите размер первого массива: ");
                    int size1 = int.Parse(Console.ReadLine());
                    int[] arr1 = new int[size1];

                    Console.WriteLine("Введите элементы первого массива:");
                    for (int i = 0; i < size1; i++)
                    {
                        arr1[i] = int.Parse(Console.ReadLine());
                    }

                    Console.Write("Введите размер второго массива: ");
                    int size2 = int.Parse(Console.ReadLine());
                    int[] arr2 = new int[size2];

                    Console.WriteLine("Введите элементы второго массива:");
                    for (int i = 0; i < size2; i++)
                    {
                        arr2[i] = int.Parse(Console.ReadLine());
                    }

                    int[] concatenatedArray = labWork.concat(arr1, arr2);
                    Console.WriteLine("Объединенный массив: " + string.Join(", ", concatenatedArray));
                    break;
                case 20:
                    Console.Write("Введите размер массива: ");
                    int inputsize = int.Parse(Console.ReadLine());
                    int[] inputArray = new int[inputsize];  

                    Console.WriteLine("Введите элементы массива:");
                    for (int i = 0; i < inputsize; i++)
                    {
                        inputArray[i] = int.Parse(Console.ReadLine());
                    }

                    int[] positiveArray = labWork.deleteNegative(inputArray);  
                    Console.WriteLine("Массив без негативных чисел: " + string.Join(", ", positiveArray));
                    break;

                default:
                    Console.WriteLine("Неверный выбор.");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Ошибка: Введите корректный номер задачи.");
        }
    }
}
