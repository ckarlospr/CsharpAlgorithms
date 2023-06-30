using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ExcersicesTest
{
    internal class Problems
    {
        public void CountLetters(string data)
        {
            //string data = "  #$&(Carlos    (&/(%&/$Perez345    Ramirez       ";
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

        public void ReverseWord()
        {

        }

        public void ReverseWords()
        {

        }

        public void SubString()
        {

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