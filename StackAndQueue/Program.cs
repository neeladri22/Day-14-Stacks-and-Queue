using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    internal class Program
    {
		static void Main(string[] args)
		{
			Stack stack = new Stack(3);
			stack.Push(56);
			stack.Push(30);
			stack.Push(70);

		}
		
		public class Stack
		{
			int capacity;
			int[] obj;
			int top = -1;
			public Stack(int capacity)
			{
				this.capacity = capacity;
				obj = new int[capacity];
			}

			//Creating method to push data 
			public bool Push(int data)
			{
				if (top == capacity - 1)
				{
					Console.WriteLine("Stack overFlow");
					return false;
				}
				obj[++top] = data;
				Console.WriteLine(data);
				return true;
			}

		}
	}
}
