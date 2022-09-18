using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Manoj
//jonaM

//namespace PdfToHtml
//{
//    class ReverseString
//    {

//        public static string StringReverse(string Input)
//        {
//            char[] a = Input.ToCharArray();
//            int b = a.Length;
//            string name = string.Empty;

//            for(int i=b-1;i>=0;--i)
//            {
//                name +=  a[i];
//            }


//            Console.WriteLine("The input string is {0} ",name);
//            return Input;
//        }

//        public static void Main(string[] args)
//        {
//            Console.WriteLine("Enter the string");
//            string name = Console.ReadLine();
//            StringReverse(name);
//        }
//    }
//}


//--------------------------------------------------------------------------------

//Word reverse

//namespace PdfToHtml
//{
//    class ReverseWord
//    {
//        public static string StringReverse(string Input)
//        {
//            Console.WriteLine("The entered string is {0}", Input);
//            string[] splitName = Input.Split(" ");
//            //Console.WriteLine("The entered string is {0}", splitName);
//            string reverse = string.Empty;

//            for(int i= 0;i<=splitName.Length-1;++i)
//            {
//                if(i>=0)
//                {
//                    reverse += ReverseString(splitName[i]) + " ";
//                }
//                else
//                {
//                    ReverseString(splitName[i]);
//                }
//            }

//            Console.WriteLine("Reversed word {0}: ", reverse);
//            return reverse;
//        }

//        public static string ReverseString(string Input)
//        {
//            int b = Input.Length;
//            char[] c = Input.ToCharArray();
//            string name = string.Empty;
//            for (int i =b-1; i >= 0; --i)
//            {
//                name += c[i];
//            }
//            return name;
//        }

//        public static void Main(string[] args)
//        {
//            Console.WriteLine("Enter the string");
//            string name = Console.ReadLine();
//            StringReverse(name);

//        }
//    }
//}


//-----------------------------------------------------------------------------------------------------

//namespace Sort
//{
//    class Sort
//    {

//        public static int[] CallMethod()
//        {
//            int[] a = { 1, 2, 5, 7, 4 };
//            Array.Sort(a);

//            foreach(int i in a)
//            {
//                Console.Write(i + " ");
//            }
//            Array.Reverse(a);
//            Console.WriteLine("Reverse string is");
//            foreach (int i in a)
//            {
//                Console.Write(i + " ");
//            }

//            return a;
//        }
//        public static void Main(string[] args)
//        {
//            CallMethod();
//        }
//    }
//}

//--------------------------------------------------------------------------------

//namespace SortArray
//{
//    class SortArray
//    {
//        public static string CallMethod()
//        {

//            int[] a = {  30,10 ,20};
//            int[] b = Array.Empty<int>();
//            int temp = 0;
//            for(int i = 0;i<a.Length;i++)
//            {
//                for(int j=i+1;j<a.Length;j++)
//                {
//                    if(a[i]>a[j])
//                    {
//                        temp = a[i];
//                        a[i] = a[j];
//                        a[j] = temp;

//                        //swapping without using 3rd variable
//                        //a[i] = a[i] * a[j];
//                        //a[j] = a[i] / a[j];
//                        //a[i] = a[i] / a[j];
//                    }
//                }
//            }
//            foreach(int c in a)
//            {
//                Console.WriteLine(c);

//            }

//            return "true";
//        }

//        public static void Main(string[] args)
//        {
//            CallMethod();
//        }
//    }
//}

//--------------------------------------------------------------------------

//namespace Sort
//{
//    class Sort
//    {

//        public static string[] CallMethod()
//        {
//            string[] a = { "Man", "abh", "Lab"};
//            Array.Sort(a);

//            foreach (string i in a)
//            {
//                Console.Write(i + " ");
//            }
//            Array.Reverse(a);
//            Console.WriteLine("Reverse string is");
//            foreach (string i in a)
//            {
//                Console.Write(i + " ");
//            }

//            return a;
//        }
//        public static void Main(string[] args)
//        {
//            CallMethod();
//        }
//    }
//}

//-------------------------------------------------------------

//namespace Sort
//{
//    class Sort
//    {

//        public static string[] CallMethod()
//        {
//            string[] a = { "Man", "abh", "Lab" };
//            Array.Sort(a);

//            foreach (string i in a)
//            {
//                Console.Write(i + " ");
//            }
//            Array.Reverse(a);
//            Console.WriteLine("Reverse string is");
//            foreach (string i in a)
//            {
//                Console.Write(i + " ");
//            }

//            return a;
//        }
//        public static void Main(string[] args)
//        {
//            CallMethod();
//        }
//    }
//}

//-------------------------------------------

//namespace Sort
//{
//    class Sort
//    {

//        public static string CallMethod()
//        {
//            string a = "Manoj";
//            a = a.ToLower();
//            char[] b = a.ToCharArray();
//            Array.Sort(b);

//            Console.Write(b);
//            return a;
//        }
//        public static void Main(string[] args)
//        {
//            CallMethod();
//        }
//    }
//}

//namespace StringWordSort
//{
//    class Sort
//    {

//        public static string CallMethod()
//        {
//            string[] a = { "Manoj", "Sagi", "Anu" };

//            //Array.Sort(a);

//            //foreach (var i in a)
//            //{
//            //    Console.WriteLine(i.ToLower());
//            //}

//           var myArray = Array.ConvertAll(a, x => x.ToLower());
//            foreach (var i in myArray)
//            {
//                Console.WriteLine(i);
//            }

//            return "true";
//        }
//        public static void Main(string[] args)
//        {
//            CallMethod();
//        }
//    }
//}


//---------------------------------------------------------

//namespace stringArraySort
//{
//    class B
//    {
//        public static void Main(string[] args)
//        {
//            string[] names = { "Flag", "Next", "Cup", "Burg", "Yatch", "Nest" };
//            string name = string.Empty;
//            Console.WriteLine("Sorted Strings : ");

//            for (int i = 0; i < names.Length; i++)
//            {
//                int c = 0;
//                for (int j = 1; j < names.Length; j++)
//                {
//                    if (j > i)
//                    {
//                        if (names[i][c] != names[j][c])
//                        {
//                            if (names[i][c] > names[j][c])
//                            {
//                                name = names[i];
//                                names[i] = names[j];
//                                names[j] = name;
//                            }
//                        }
//                        else
//                        {
//                            c = c + 1;
//                        }
//                    }
//                }
//                Console.WriteLine(names[i]);
//            }
//        }
//    }
//}

//-----------------------------------------------------------------------------


//namespace NoZero
//{
//    class A
//    {
//        public static string CallMethod()
//        {
//            int[] a = { 1 ,2,2, 1, 1 };
//            int[] b = new int[a.Length];

//            int g = 0;
//            for (int i = a.Length - 1; i >= 0; --i)
//            {
//                for (int j = i - 1; j >= 0; --j)
//                {
//                    //if (g != a[i] && a[i] == a[j])
//                    //{
//                    //    b[i] = a[i];
//                    //    if (b[i] != a[i])
//                    //    {
//                    //        g = a[i];
//                    //        a[i] = 0;
//                    //        break;
//                    //    }
//                    //}
//                    if((a[i]==a[j]) && (b[i]!=a[i]) && g!=a[i])
//                    {
//                        a[i] = 0;
//                        b[i] = a[i];
//                        g++;
//                        break;
//                    }
//                    else
//                    {
//                        b[i] = a[i];
//                    }

//                }
//            }
//            foreach(var v in b)
//            {
//                Console.Write(v);
//            }



//            return "true";
//        }

//        public static void Main(string[] args)
//        {
//            CallMethod();
//        }
//    }
//}

//namespace A
//{
//    class B
//    {
//        static void Main(string[] args)
//        {
//            int[] a = { 1, 1, 2, 2, 1, 1 };
//            List<int> b = new List<int>();
//            var count = 0;
//            for (int i = a.Count() - 1; i > -1; i--)
//            {
//                if (!(b.Contains(a[i])))
//                {
//                    count = 0;
//                    foreach (var item in a)
//                    {
//                        if (item == a[i])
//                        {
//                            count++;
//                        }
//                    }
//                    if (count > 1)
//                    {
//                        b.Add(a[i]);
//                        a[i] = 0;



//                    }
//                }

//            }



//            foreach (var item in a)
//            {
//                Console.WriteLine(item);



//            }



//        }
//    }

//}


//namespace Duplicate
//{
//    class B
//    {

//        public static string CallMethod()
//        {
//            int[] a = { 1, 3, 4, 3, 2, 5 ,2};
//            List<int> b = new List<int>();
//            for(int i=0; i< a.Length-1;i++)
//            {
//                for(int j=i+1;j<a.Length;j++)
//                {

//                    if(a[i]==a[j])
//                    {

//                        b.Add(a[i]);
//                    }
//                }
//            }
//            foreach(var i in b)
//            {
//                Console.WriteLine(i + " ");
//            }
//            return "true";
//        }
//        public static void Main()
//        {
//            CallMethod();
//        }
//    }
//}


namespace DuplicateName
{
    class B
    {

        public static string CallMethod()
        {
            string[] a = { "abc", "abc","def" ,"e","def"};
            List<string> b = new List<string>();
            for (int i = 0; i < a.Length - 1; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {

                    if (a[i] == a[j])
                    {

                        b.Add(a[i]);
                        break;
                    }
                }
            }
            foreach (var i in b)
            {
                Console.WriteLine(i + " ");
            }
            return "true";
        }
        public static void Main()
        {
            CallMethod();
        }
    }
}
