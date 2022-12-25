
string KeyboardInput()
{
    string ki = Console.ReadLine();
    if (ki=="")
    {
        return ki="null";
    }
    else
    {
        return ki;
    }
}

int GetNewLengthMassiv(string[] massiv)
{
    int sizeNewMass = 0;
    for(int k = 0 ;k < massiv.Length; k++)
    {
        if(massiv[k].Length <=3)
        {
            sizeNewMass++;
        }
    }
    return sizeNewMass;
}


string[] FillArray(int size)
{
    string[] arr = new string[size];
    for(int i = 0; i < arr.Length; i++)
    {
        Console.Write($"Введите значение № {i+1} > ");
        arr[i] = KeyboardInput()  /*Console.ReadLine()*/ /*new Random().Next(-9,10)*/;
    }
    return arr;
}

string[] NewArray(string[] massiv)
{
    string[]  NewArr = new string[GetNewLengthMassiv(massiv)];
    int l = 0;
    {
        for(int j = 0; j < massiv.Length; j++)
        
        {
            if(massiv[j].Length <= 3 )
            {
                NewArr[l]=massiv[j];
                //Console.WriteLine($"{array[j]} > {NewArr[l]} > {l}");
                l++;
            }
        }return NewArr;
    }
}



Console.Write("Введите длину массива: ");
int num = Convert.ToInt32(Console.ReadLine());
string[] array = FillArray(num);
Console.WriteLine();
Console.Write($"Ваш массив > ");
Console.WriteLine(string.Join(", ", array));


Console.Write($"Новый массив > ");
Console.WriteLine(string.Join(", ", NewArray(array)));

