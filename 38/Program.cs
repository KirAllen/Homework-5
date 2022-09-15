// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

int[] array = new int[10];  
FillArray(array);
PrintArray(array); 
Console.WriteLine();
System.Console.WriteLine(GetDifference(array));


int GetDifference(int[] array)
{   
    int result = 0; 
    int min = array[0]; 
    int max = array[0]; 
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > max)
        {
            max = array[i];
        }
        else if(array[i] < min)
        {
            min = array[i]; 
        }
    }
    result = max - min; 
    return result; 
}   

void FillArray(int[] array)
{
    int length = array.Length; 
    int index = 0; 
    while(index < length)
    {
        array[index] = new Random().Next(1, 99); 
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




