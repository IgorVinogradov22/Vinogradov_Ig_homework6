//Составить частотный словарь элементов двумерного массива.

Console.WriteLine("Введите число строк массива ");
int a =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов массива ");
int b =Convert.ToInt32(Console.ReadLine());

//Создать двумерный массив. 

int[,] Create (int a, int b)
{
    int[,]arr = new int [a,b];
    for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        arr[i, j] = new Random().Next(0, 10);
                    }
                    
                }
                return arr;

}

//Вывод массива в консоль.

void PrintArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]}");
        }
        Console.WriteLine();
    }
}

//Подсчитать одинаковые элементы двумерного массива.

int SearchElement (int[,]arr, int num)
{
    int count = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
          if (arr[i,j] == num)  count++;
        }
    }
    return count;
}

bool Check (int[]list, int num)
{
    bool res = true;
    for (int i = 0; i < list.Length; i++)
    {
       if (list[i] == num) res = false; 
    }
    return res;
}

void PrintList (int[] namelist, int[]countlist)
{
    for (int i = 0; i < countlist.Length; i++)
    {
        if (countlist[i] !=0)
        
        Console.WriteLine($"Число {namelist[i]} в массиве встерчается {countlist[i]} раз");
        
    }
}

int [,]array = Create(a,b);
PrintArr(array);

//Создать массив со значениями элементов и их количеством.

int[]nameElement= new int [array.GetLength(0) * array.GetLength(1)];

int[]countElement= new int [array.GetLength(0) * array.GetLength(1)];

int countlist = 0;
int countnull = 0;

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (Check (nameElement, array [i,j]))
        {
            nameElement [countlist] = array[i,j];
            countElement[countlist] = (SearchElement(array, array[i,j]));
            countlist ++;
        }
        //Подсчет нулей.
        if (array[i,j] == 0) countnull++;
    }   
}

//Добавить в список количество нулей в массиве.

countElement[countlist] = countnull++;
PrintList(nameElement, countElement);




















