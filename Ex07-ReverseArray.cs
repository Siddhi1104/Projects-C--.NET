using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments
{
    class Ex07_ReverseArray
    {
        static List<int> lst = new List<int>();

        public static List<int> CalledFunction()
        {
            int size = Utilities.GetInteger("Enter the size of array: ");
            for(int i=0;i<size;i++)
            {
                int item = Utilities.GetInteger("Enter the element: ");
                lst.Add(item);
            }
            return lst;
        }

        public static void result()
        {
            List<int> list = CalledFunction();
            for(int i = list.Count -1; i>=0; i--)
            {
                Console.WriteLine(list[i]);
            }
        }


        static void Main()
        {
            Ex07_ReverseArray.result();
        }
    }
}
