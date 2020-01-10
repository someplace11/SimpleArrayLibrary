using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayLibrary
{
    public class Arrays
    {
        public int[] arr;
        public int len;
        private int indexSpot = 0;
        public int orgLen;

        public Arrays(int size)
        {
            orgLen = size;
            len = size;
            arr = new int[len];
        }

        public int[] insert(int num)
        {
            if (indexSpot < orgLen)
            {
                arr[indexSpot] = num;
                indexSpot++;
            }
            else
            {
                len++;
                int[] newArr = new int[len];
                for (int i = 0; i < len - 1; i++)
                {
                    newArr[i] = arr[i];
                }
                newArr[len - 1] = num;
                arr = newArr;
            }

            return arr;
        }

        public int[] removeAt(int num)
        {
            int j = 0;
            len--;
            int[] newArr = new int[len];
            for(int i = 0 ; i < len; i++)
            {
                if(arr[j] != arr[num])
                {
                    newArr[i] = arr[j];
                    j++;
                }
                else
                {
                    j++;
                    newArr[i] = arr[j];
                    j++;
                }
            }

            arr = newArr;

            return arr;
        }

        public void print()
        {
            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine("\n");
        }

        public void printIndex()
        {
            Console.WriteLine(indexSpot);
        }
    }
}
