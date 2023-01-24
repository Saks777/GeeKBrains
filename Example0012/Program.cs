
/*Совмещение массивов и методов.По умолчанию в массиве 10 элементов.
Определили массив из 10 элементов, 
вызвали метод ФилАррэй который заполнил массив.
Метод ПринтАррэй распечатал массив в рандомном порядке." Ищем индекс числа 4"*/

/*void FillArray(int[] collection)
{
  int length = collection.Length;
  int index = 0;
  while(index < length)
  {
    collection[index] = new Random().Next(1, 10);
    index++;
  }

}

void PrintArray(int[] col)
{
  int count = col.Length;
  int position = 0;
  while(position < count)
  {
    Console.WriteLine(col[position]);
    position++;
  }
}

int [] array = new int [10];

FillArray(array);
PrintArray(array);*/

/* Новая задача. Адаптировать предыдущую задачу с использованием метода.
   Если убрать break то будет определять последнюю в очереди позицию числа, если их несколько.
   "Ищем индекс числа 4"
   Если этого числа нет то будет выдавать -1 */
Console.Clear();
void FillArray(int[] collection)
{

  int length = collection.Length;
  int index = 0;
  while (index < length)
  {
    collection[index] = new Random().Next(1, 10);
    index++;
  }

}

void PrintArray(int[] col)
{
  int count = col.Length;
  int position = 0;
  while (position < count)
  {
    Console.Write($"{col[position]},");
    position++;
  }

}


int IndexOf(int[] collection, int find)
{
  int count = collection.Length;
  int index = 0;
  int position = -1;

  while (index < count)
  {
    if (collection[index] == find)
    {
      position = index;
      break;
    }
    index++;
  }
  return position;

}

int[] array = new int[10];

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.Write(pos + " !!! ");






