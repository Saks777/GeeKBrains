/*Имеется одномерный массив array из n элементов, требуется
найти элемент массива, равный find
1. Установить счетчик index в позицию 0
2. Если array [index] = find, алгоритм завершил работу
успешно.
3. Увеличить index на 1
4. Если index < n, то перейти к шагу 2. В противном случае
алгоритм завершил работу безуспешно.*/

//                         Начало Задачи

/*int [] array = {1, 5, 8, 10, 25, 45, 88, 150 };

int n = array.Length;
int find = 150;

int index = 0;
while (index < n)
{
  if (array[index] == find)
  {
    Console.WriteLine($" Number of index is:" + index);
  }
    index++;

}*/

//              Способ если в массиве 2 одинаковых числа

int [] array = {1, 5, 8, 10, 25, 150, 45, 88, 150 };

int n = array.Length;
int find = 150;

int index = 0;
while (index < n)
{
  if (array[index] == find)
  {
    Console.WriteLine($" Number of index is:" + index);
    break;
  }
    index++;

}