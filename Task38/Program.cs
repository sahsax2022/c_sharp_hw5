// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.


double[] CrArray(int size)
{
    double[] NewArray = new double[size];
    return NewArray;
}

double[] EnterArrayElements(double[] thisArray) 
{  
    for(int i = 0; i < thisArray.Length ; i++)
        thisArray[i] = new Random().NextDouble() * 100;
    
    return thisArray;
}

void ShowDifferenceMinMaxElements(double[] thisArray) 
{  
    double max = 0.0;
    double min= thisArray[0];

    Console.Write("[");
    for(int i = 0; i < thisArray.Length ; i++)
    {
        if(thisArray[i] > max)
            max =  thisArray[i];

        if(thisArray[i] < min)
            min =  thisArray[i];       
        
        Console.Write(thisArray[i]);
        if(i < thisArray.Length - 1 )
            Console.Write(", ");    
    }
    Console.Write("]"); 
    Console.Write($"-> Min + Max = {min + max}");
}

Console.WriteLine("Input array size: ");
int ArSize = Convert.ToInt32(Console.ReadLine());
double[] MyArray = CrArray(ArSize);
Console.WriteLine("Array was created :-) ");
MyArray = EnterArrayElements(MyArray);
ShowDifferenceMinMaxElements(MyArray);