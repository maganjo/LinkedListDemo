using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDemo
{
	public static class LinkedListHelpers
	{
		public static void removeDuplicate(Node node)
		{
			Node node2 = null;
			Node node1 = node;
			while (node1 != null && node1.next != null)
			{
				node2 = node1;
				int count = 0;
				while (node2 != null && node2.next != null)
				{
					if (node1.data == node2.next.data)
						count++;
					if (count >= 2)
					{
						node2.next = node2.next.next;
						count = 0;
					}
					else
						node2 = node2.next;
				}
				node1 = node1.next;
			}
		}
	}

	public class Node
	{
		public string data;
		public Node next;
		public Node(string _data)
		{
			data = _data;
			next = null;
		}
	}
}
