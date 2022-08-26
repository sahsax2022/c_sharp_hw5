// Задача  36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.


int[] CrArray(int size)
{
    int[] NewArray = new int[size];
    return NewArray;
}

int[] EnterArrayElements(int[] thisArray) 
{  
    for(int i = 0; i < thisArray.Length ; i++)
        thisArray[i] = new Random().Next(-99, 100);
    
    return thisArray;
}

void ShowArraysOddElementsSum(int[] thisArray) 
{  
    Console.Write("[");
    for(int i = 0; i < thisArray.Length ; i++)
    {
        Console.Write(thisArray[i]);
        if(i < thisArray.Length - 1 )
            Console.Write(", ");    
    }
    Console.Write("]"); 

    int OddNumbers = 0;

    for(int i = 0; i < thisArray.Length ; i++)
    {
        if(i % 2 != 0)
            OddNumbers = OddNumbers + thisArray[i];     
    }
    Console.Write($"-> {OddNumbers}");
}

Console.WriteLine("Input array size: ");
int ArSize = Convert.ToInt32(Console.ReadLine());
int[] MyArray = CrArray(ArSize);
Console.WriteLine("Array was created :-) ");
MyArray = EnterArrayElements(MyArray);
ShowArraysOddElementsSum(MyArray);