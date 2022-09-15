// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.


int[] array = new int[5];  
FillArray(array);
PrintArray(array); 
Console.WriteLine();
System.Console.WriteLine(GetSum(array));


int GetSum(int[] array)
{   
    int result = 0; 
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)
        {
            result++;
        }
    }
    
    return result; 
}   

void FillArray(int[] array)
{
    int length = array.Length; 
    int index = 0; 
    while(index < length)
    {
        array[index] = new Random().Next(100, 999); 
        index++; 
    }
}

void PrintArray(int[] array)
{
    int length = array.Length; 
    int index = 0; 
    while(index < length)
    {
        Console.Write($"{array[index]}, ");  
        index++;      
    }
}



