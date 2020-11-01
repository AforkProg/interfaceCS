using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab
{
    interface IArray
    {
        void Add(int newValue);
        int Find(int index);
        void Remove(int index);
        void Update(int index, int newValue);
    }
    class lab : IArray
    {
        int[] myArray;
        int size = 0;
        public void Add(int newValue)
        {
            size++;
            int[] tempArray = myArray;
            myArray = new int[size];
            myArray[size - 1] = newValue;
            for (int a = 0; a < size - 1; a++)
                myArray[a] = tempArray[a];
        }
        public int Find(int index)
        {
            for (int a = 0; a < size; a++)
            {
                if (a == index - 1)
                {
                    return myArray[a];
                }
                if (a == size - 1)
                {
                    return 0;
                }
            }
            return 0;
        }
        public void Remove(int index)
        {
            if (size == 0)
                Console.Write("Remove(): There is nothing to remove. sad but true YEAAAH\n");
            else if (index < 0 || index > size)
                Console.Write("Remove(): There is wrong index. sad but true YEAAAH\n");
            else
            {
                size--;
                int[] tempArray = myArray;
                myArray = new int[size];
                for (int a = 0; a < size; a++)
                {
                    if (a == index - 1)
                        break ;
                    myArray[a] = tempArray[a];
                }
                for (int a = index; a < size + 1; a++)
                {
                    myArray[a - 1] = tempArray[a];
                }
            }
        }
        public void Update(int index, int newValue)
        {
            if (index <= size || index > 0)
                myArray[index - 1] = newValue;
            else
                Console.Write("Update(): There is no your index. sad but true YEAAAAAAH\n");
        }
        public void Show()
        {
            for (int a = 0; a < size; a++)
                Console.Write("index: " + (a + 1) + " number: " + myArray[a] + "\n");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            lab lab = new lab();
            Console.Write("Hi boiz\n\n");
            lab.Add(5);
            lab.Add(228);
            lab.Add(53);
            lab.Add(15);
            lab.Add(4215);
            Console.Write("Find() result: " + lab.Find(1) + "\n");
            lab.Show();
            lab.Update(3, 322);
            lab.Remove(6);
            lab.Show();
        }
    }
}
