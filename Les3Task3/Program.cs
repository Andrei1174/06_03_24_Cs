
void ZeroEvenElements(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            arr[i] = 0;
        }
    }
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i]+" ");
    }

    // foreach (var item in arr)  // // можно так 
    // {
    //     Console.Write(item+" ");
    // }
}

int[] mas = [1, 2, 3, 4, 5, 6];
ZeroEvenElements(mas);
PrintArray(mas);

