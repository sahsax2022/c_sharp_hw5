// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.


int[] CrArray(int size)
{
    int[] NewArray = new int[size];
    return NewArray;
}

int[] EnterArrayElements(int[] thisArray) 
{  
    for(int i = 0; i < thisArray.Length ; i++)
        thisArray[i] = new Random().Next(100, 1000);
    
    return thisArray;
}

void ShowArraysEvenElements(int[] thisArray) 
{  
    Console.Write("[");
    for(int i = 0; i < thisArray.Length ; i++)
    {
        Console.Write(thisArray[i]);
        if(i < thisArray.Length - 1 )
            Console.Write(", ");    
    }
    Console.Write("]"); 

    int EvenNumbers = 0;

    for(int i = 0; i < thisArray.Length ; i++)
    {
        if(thisArray[i] % 2 == 0)
        EvenNumbers++;        
    }
     if(EvenNumbers > 0)
        Console.Write($"-> {EvenNumbers}");
}

Console.WriteLine("Input array size: ");
int ArSize = Convert.ToInt32(Console.ReadLine());
int[] MyArray = CrArray(ArSize);
Console.WriteLine("Array was created :-) ");
MyArray = EnterArrayElements(MyArray);
ShowArraysEvenElements(MyArray);