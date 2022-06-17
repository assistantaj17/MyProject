using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft_New_Project.String_Demo
{
    internal class Count_Word
    {
        static void Main(string[] args)
        {
            string s1 = "India is My Country";
            int count = 1;
            for(int i=0;i<s1.Length;i++)
            {
                if(s1[i]==' ')
                {
                    count++;
                }
            }
            Console.WriteLine(count+" Word in String");
        }
    }

    class Pattern_String
    {
        static void Main(string[] args)
        {
            string s = "I LIke India Country";
            for(int i=0;i<s.Length;i++)
            {

            }
        }
    }
}
