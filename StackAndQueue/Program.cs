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

			var tc1 = stack.Peek();
			Console.WriteLine("Peek :" + tc1);
			Console.WriteLine("\n");

			var tc2 = stack.Pop();
			Console.WriteLine("Pop :" + tc2);

			var tc3 = stack.Peek();
			Console.WriteLine("Peek :" + tc3);
			Console.WriteLine("\n");

			var tc4 = stack.Pop();
			Console.WriteLine("Pop :" + tc4);

			var tc5 = stack.Peek();
			Console.WriteLine("Peek :" + tc5);
			Console.WriteLine("\n");

			var tc6 = stack.Pop();
			Console.WriteLine("Pop :" + tc6);

			var tc7 = stack.Peek();
			Console.WriteLine("Peek :" + tc7);


		}
		// Craeting Stack class
		public class Stack
		{
			int capacity;
			int[] obj;
			int top = -1;

			public  Stack(int capacity)
			{
				this.capacity = capacity;
				obj = new int[capacity];
			}


			//Creating method to push data into stack
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

			// Creating Pop() method to remove the latest added element from the stack
			public int Pop()
			{
				if (top == -1)
				{
					Console.WriteLine("Stack Underflow");
					return default(int);
				}
				return obj[top--];
			}

			// Creating Peek() method to return th leatest added elemet in the stack
			public int Peek()
			{
				if (top == -1)
				{
					Console.WriteLine("Stack is UnderFlow");
					return (int)default;
				}
				return obj[top];
			}

		}
	}
}
