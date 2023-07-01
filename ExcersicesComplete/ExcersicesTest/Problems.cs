using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ExcersicesTest
{
    internal class Problems
    {
        public void CountLetters()
        {
            string data = "  #$&(Carlos    (&/(%&/$Perez345    Ramirez       ";
            data = data.ToLower();
            data = data.Replace(" ", "");

            StringBuilder sb = new StringBuilder();
            foreach (char item in data) 
            {
                if (item >= 'a' && item <= 'z')
                {
                    sb.Append(item);
                }
            }

            /*data = sb.ToString();
            char a = data.GroupBy(x => x).OrderByDescending(x => x.Count()).First().Key;
            int d = data.Count(t => t == a);*/
            
            data = sb.ToString();
            Console.WriteLine(data);
            string dist = new String(data.Distinct().ToArray());
            Hashtable hashtable = new Hashtable();  
            

            //dist = String.Concat(dist.OrderByDescending(x => x));
            
            string lFirst = "";
            int cntFirst = 0;
            string lSec = "";
            int cntSec = 0;

            foreach (char item in dist) 
            {
                Console.WriteLine(item + " - " + data.Count(x => x == item));
                if (data.Count(x => x == item) > cntFirst)
                {
                    lFirst = item.ToString();
                    cntFirst = data.Count(x => x == item);
                }else if (data.Count(x => x == item) > cntSec)
                {
                    lSec = item.ToString();
                    cntSec = data.Count(x => x == item);
                }
            }

            Console.WriteLine("first: " + lFirst);
            Console.WriteLine("count: " + cntFirst);
            Console.WriteLine("Sec: " + lSec);
            Console.WriteLine("count: " + cntSec);
        }

        public Boolean Palindrome(string word)
        {
            Boolean result = true;

            for (int i=0; i<word.Length/2; i++)
            {
                if (word[i] != word[word.Length - 1 - i])
                {
                    result = false;
                    break;
                }
            }

            return result;
        }
        public int Haming(int[] arr1, int[] arr2)
        {
            int result = -1;
            if(arr1.Length == arr2.Length)
            {
                result = 0;
                for (int i = 0; i < arr1.Length; i++)
                {
                    if (arr1[i] != arr2[i])
                    {
                        result++;
                    }
                }
            }

            return result;
            
        }

        public void ReverseWord(string word)
        {
            for (int i=word.Length-1; i>=0; i--)
            {
                Console.Write(word[i]);
            }
        }

        public void ReverseWords(string data)
        {
            String[] words = data.Split(" ");
            String result = "";
            for (int i=words.Length-1; i>=0; i--)
            {
                result += words[i] + " ";
            }
            Console.WriteLine(result);
        }

        public void SubString(string word)
        {//carlos
            //c ca car carl carlo carlos a ar arl arlo arlos r rl rlo rlos l lo los o os s
            string result = "";
            for (int i=0; i<word.Length; i++)
            {
                result += word[i];
                Console.Write(result+ " ");
                for (int j=i+1; j<word.Length; j++)
                {
                    result += word[j];
                    Console.Write(result + " ");
                }
                result = "";
            }

            
        }

        //Reverse ArrayList
        //[4]->[3]->[2]->[1]->null
        //[1]->[2]->[3]->[4]->null
        /*
        public Node ArrayListReverse(Node head)
        {
            Node current = head;
            Node next = null;
            
            while(current != null)
            {   
                Node temp = current.next;
                current.next = next;
                next = current;
                current = temp;
            }
            return next;
         }*/

        //Reverse Tree
        /*
        public void TreeReverse(Tree tree)
        {
            Tree temp = tree.Left;
            tree.left = tree.Right;
            tree.Right = temp;
            TreeReverse(tree.Left);
            TreeReverse(tree.Right);
        }
        */
    }
}