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
			Queue queue = new Queue(3);

			queue.Enqueue(56);
			queue.Enqueue(30);
			queue.Enqueue(70);
			Console.WriteLine("\n");

			var tc1 = queue.Dequeue();
			Console.WriteLine("Dequeue : " + tc1);
			Console.WriteLine("\n");

			var tc2 = queue.Dequeue();
			Console.WriteLine("Dequeue : " + tc2);
			Console.WriteLine("\n");

			var tc3 = queue.Dequeue();
			Console.WriteLine("Dequeue : " + tc3);
			Console.WriteLine("\n");


			/*
			Console.WriteLine("Welcome Creating Queue");
			Queue queue = new Queue(3);

			//Adding Elemt into Queue
			queue.Enqueue(56);
			queue.Enqueue(30);
			queue.Enqueue(70);
			
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
			*/

		}
		/*

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
		*/

		// Creating Queue class
		public class Queue
		{

			int capacity;
			int[] obj;
			int front = -1, rear = -1;

			// Creating Queue method
			public Queue(int capacity)
			{
				this.capacity = capacity;
				obj = new int[capacity];
			}

			// Creating Enqueue method to insert the element into the Queue
			public bool Enqueue(int data)
			{
				if (rear == capacity - 1)
				{
					Console.WriteLine("Que is Full");
					return false;
				}
				if (rear == -1)
					front++;
				obj[++rear] = data;
				Console.WriteLine(data);
				return true;
			}
			// Creating Denqueue method to Remove the element from the Queue
			public int Dequeue()
			{
				if (front == -1)
				{
					Console.WriteLine("queue is empty");
					return default(int);
				}
				int ob = obj[front++];
				if (front > rear)
					front = rear = -1;
				return ob;
			}


		}
	}
}	
