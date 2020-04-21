using System;
using Tasks;

namespace Test
{
    class Program
    {
        /// <summary>
        /// Function that swap a and b
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        static void swap(ref int a, ref int b)
        {
            var tmp = a;
            a = b;
            b = tmp;
        }

        /// <summary>
        /// Function that implements insertion sort
        /// </summary>
        /// <param name="array">array to sort</param>
        /// <returns>sorted arra</returns>
        static int[] insertionSort(int[] inputArray)
        {
            /*for (var i = 1; i < array.Length; i++)
            {
                var key = array[i];
                var j = i;
                while ((j > 1) && (array[j - 1] > key))
                {
                    swap(ref array[j - 1], ref array[j]);
                    j--;
                }

                array[j] = key;
            }*/


            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (inputArray[j - 1] > inputArray[j])
                    {
                        swap(ref inputArray[j], ref inputArray[j - 1]);
                        /*int temp = inputArray[j - 1];
                        inputArray[j - 1] = inputArray[j];
                        inputArray[j] = temp;*/
                    }
                }
            }

            return inputArray;
        }


        static void Main()
        {
           
            List<string> stringList = new List<string>();
            List<int> intList = new List<int>();
            
            int[] testArr = { 2, 1, 8, 6, 9, 7, 15, 8, 3, 4};

            Console.WriteLine("INT LIST:");

            intList.Add(1);
            intList.Add(2);
            intList.Add(3);

            Console.Write("Add 1, 2, 3 to intList: ");
            foreach (var item in intList)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            intList.Remove(2);
            Console.Write("Delete 2 from intList: ");
            foreach (var item in intList)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            bool f = intList.Contains(3);
            Console.Write(f == true ? "List contain 3" : "List doesn't contain 3");

            Console.Write("Add 4 first in intList: ");
            intList.AppendFirst(4);
            foreach (var item in intList)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            intList.Clear();
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("STRING LIST:");

            stringList.Add("AA");
            stringList.Add("BB");
            stringList.Add("CC");
            stringList.Add("DD");

            Console.Write("Add AA, BB, CC, DD to stringList: ");
            foreach (var item in stringList)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            Console.Write("Delete AA from stringList: ");
            stringList.Remove("AA");
            foreach (var item in stringList)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            bool isPresent = stringList.Contains("CC");
            Console.WriteLine(f == true ? "List contain CC" : "List doesn't contain CC");

            Console.WriteLine("Add WW first in intList:");
            stringList.AppendFirst("WW");
            foreach (var item in stringList)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            stringList.Clear();
            Console.ReadKey();
            Console.Clear();

          
           Console.WriteLine("BINARY TREE:");

           var binaryTree = new Tree<int>();

            binaryTree.Add(8);
            binaryTree.Add(3);
            binaryTree.Add(10);
            binaryTree.Add(1);
            binaryTree.Add(6);
            binaryTree.Add(4);
            binaryTree.Add(7);
            binaryTree.Add(14);
            binaryTree.Add(16);

            binaryTree.PrintTree();

            Console.WriteLine(new string('-', 40));
            binaryTree.Remove(3);
            binaryTree.PrintTree();

            Console.WriteLine(new string('-', 40));
            binaryTree.Remove(8);
            binaryTree.PrintTree();
           

            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("SORT:");
            Console.WriteLine("Array: {0}", string.Join(", ", testArr));
            Console.WriteLine("Sorted array: {0}", string.Join(", ", insertionSort(testArr)));
            Console.ReadKey();
        }
    }
}
