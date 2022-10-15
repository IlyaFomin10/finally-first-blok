// Написать программу, которая из имеющегося массива строк формирует массив из строк
// длина которых меньше либо равна 3 символа.

string [] array = {"корова", "24", "пирог", "на", "трава"};

string [] NewArray3letters (string [] array)
{
    int k = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < 4)
        {
            k = k + 1;
        }    
    }
    int j = 0;
    string [] newArray = new string [k];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < 4)
        {
            newArray[j] = array[i];
            j = j + 1;
        }
    }
    return newArray;
} 
