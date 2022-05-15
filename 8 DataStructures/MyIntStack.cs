using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Excercises._8_DataStructures
{
    public class MyIntStack
    {
        private int[] contents;
        private int tos;  // Top of the stack

        public MyIntStack(int capacity)
        {
            contents = new int[capacity];
            tos = -1;
        }
        public void push(int element)
        {
            contents[++tos] = element;
        }

        public int pop()
        {
            return contents[tos--];
        }

        public int peek()
        {
            return contents[tos];
        }

        public Boolean isEmpty()
        {
            return tos < 0;
        }

        public Boolean isFull()
        {
            return tos == contents.Length - 1;
        }
    }
}
