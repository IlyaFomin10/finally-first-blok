// Написать программу, которая из имеющегося массива строк формирует массив из строк
// длина которых меньше либо равна 3 символа.

string [] array = {"корова", "24", "пирог", "на", "ППП", "трава"};

void OutputNewArray3letters (string [] array)
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
    for (int l = 0; l < array.Length; l++)
    {
        if (array[l].Length < 4)
        {
            newArray[j] = array[l];
            j = j + 1;
        }
    }
    Console.Write("newArray = [");
    for (int n = 0; n < newArray.Length - 1; n++)
    {
        Console.Write($"{newArray[n]}, ");
    }
    Console.Write($"{newArray[newArray.Length - 1]}]");
}

OutputNewArray3letters(array);