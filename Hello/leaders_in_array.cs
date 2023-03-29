using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
   public class Array
    {
        public void printleader(int [] arr,int size) 
        { 
            for(int i=0; i<size; i++)
            {
                int j;
                for (j = i + 1; j < size; j++)
                {
                    if (arr[i] <= arr[j]) 
                    {
                        break;
                    }
                        
                }
                if (j == size)
                {
                   Console.Write(arr[i] + " ");
                }
                   
            }
        }
    }
}
