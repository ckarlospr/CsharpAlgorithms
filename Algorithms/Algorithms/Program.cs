
using System.Text;



/*int x = 4, b = 2;
x -= b /= x * b;
Console.WriteLine(x + " " + b);
Console.ReadLine();*/


/*int[] data = {7,3,8,4,1,9,6,2,5,10};
foreach (int i in data) Console.Write($"{i} ");

Boolean sorted = false;
int cnt = data.Length;

while (!sorted)
{
    sorted = true;

    for (int i = 0; i < cnt-1; i++)
    {
        if (data[i] > data[i + 1])
        {
            int d = data[i];
            data[i] = data[i + 1];
            data[i + 1] = d;
            sorted = false; 
        }
    }

    cnt--;
}*/






// insertion sort
/*
for (int i = 1; i < data.Length; i++)
{
    int temp = data[i];
    int j = i-1;
    while(j>=0 && data[j] > temp)
    {
        data[j+1] = data[j];
        data[j] = temp;
        j--;
    }
}
*/


//Console.WriteLine();
//foreach (int i in data) Console.Write(i+" ");




/*string str = "carlosperez";
Console.WriteLine(str);

for (int i = 0; i < str.Length; ++i)
{
    StringBuilder subString = new StringBuilder(str.Length - i);
    for (int j = i; j < str.Length; ++j)
    {
        subString.Append(str[j]);
        Console.Write(subString + " ");
    }
}*/
