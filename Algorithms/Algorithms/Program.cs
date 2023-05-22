
using System.Security.Cryptography.X509Certificates;
using System.Text;


// Distancia de Hamming
string text1 = "patitosw";
string text2 = "paratosa";

int cnt = 0;

if(text1.Length==text2.Length)
{
    for (int i = 0; i < text1.Length; i++)
    {
        if (text1[i] != text2[i]) { cnt++; }
    }
}

Console.WriteLine(cnt);



/*string text = "asdikASGGEdsasaasafhryuop";
char character = 'a';
int n = 0;

n = text.Where(c => c == character).Count();
Console.WriteLine(n);*/



//Reverse a String

/*string word = "carlos";
string result = "carlos";
Console.Write(word);
char[] chars =  word.ToCharArray();
Array.Reverse(chars);
result = new string(chars);
Console.Write(result);*/

//Reverse order words
/*string words = "Carlos Perez";

string[] words2 = words.Split(" ");

Console.WriteLine("\n");
foreach (string word in words2) Console.WriteLine(word);
Console.WriteLine("\n");
for (int i = words2.Length-1; i >= 0; i--)
{
    Console.Write(words2[i] + " ");
}*/


// Is palindrome
/*string data = "anitalavalatin";

char[] chars = data.ToCharArray();
int d = chars.Length;
int ind = d - 1;
Boolean isPalindrome = true;
for (int i = 0; i < d/2; i++)
{
    //Console.WriteLine(i+" - "+chars[i] +"!="+ chars[ind - i]);
    if (chars[i] != chars[ind - i])
    {
        isPalindrome=false;
        break;
    }
}
Console.WriteLine("Is palindrome: "+isPalindrome);*/


//Substring 
/*string data = "Carlos";
//C Ca Car Carl Carlo Carlos a ar arl arlo arlos r rl rlo rlos l lo los o os s
char[] str = data.ToCharArray();
for(int i=0; i<str.Length; i++)
{
    string d = "";
    for (int j=i; j<str.Length; j++)
    {
        d += str[j];
        Console.Write(d+" ");
    }
}*/

//Prime
/*int number = 97;
Boolean isPrime=false;

if (number == 1) isPrime = false;
else if (number==2) isPrime = true;
else if (number % 2 == 0) isPrime = false;
else
{
    isPrime = true;
    var squareRoot = (int)Math.Floor(Math.Sqrt(number));
    for (int i = 3; i <= squareRoot; i += 2)
    {
        if (number % i == 0) isPrime = false;
    }
}
Console.WriteLine("number "+number+" is prime: " +isPrime);*/

/*
List<int> a = new List<int>();

for(int i = 0; i < 100; i++)
{
    a.Add(66);
}*/

/*a.Add(1);
a.Add(2);
a.Add(2);
a.Add(3);
a.Add(1);
a.Add(2);*/

/*a.Sort();
int cnt = 1;
int max = 0;

for (int i = 0; i < a.Count(); i++)
{
    Console.WriteLine(" * ");
    Console.WriteLine(a[i]);
    Console.WriteLine(" * ");
    for (int j = i + 1; j < a.Count(); j++)
    {
        Console.Write(a[i] +" == "+ a[j]+" || "+ (a[1] + 1) +"=="+ a[j]);
        if (a[i] == a[j] || a[i] + 1 == a[j])
        {
            
            cnt++;
            Console.WriteLine("  cnt: " + cnt);
        }
            
        
    }
    if (cnt > max) max = cnt;
    if (cnt == a.Count)
    {
        max = cnt;
        break;
    }
    cnt = 1;
}*/


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
