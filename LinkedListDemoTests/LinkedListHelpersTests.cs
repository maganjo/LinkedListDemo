using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinkedListDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace LinkedListDemo.Tests
{
	[TestClass()]
	public class LinkedListHelpersTests
	{
		[TestMethod()]
		public void removeDuplicateTest()
		{
			Node node = new Node("E");
			node.next = new Node("B");
			node.next.next = new Node("E");
			node.next.next.next = new Node("E");
			node.next.next.next.next = new Node("B");
			node.next.next.next.next.next = new Node("A");
			node.next.next.next.next.next.next = new Node("B");
			LinkedListHelpers.removeDuplicate(node);
			string json = new JavaScriptSerializer().Serialize(node);
			Console.WriteLine(json);

			Node testNode = new Node("E");
			testNode.next = new Node("B");
			testNode.next.next = new Node("E");
			testNode.next.next.next = new Node("B");
			testNode.next.next.next.next = new Node("A");

			json = new JavaScriptSerializer().Serialize(node);
			Console.WriteLine(json);
			Assert.AreEqual<Node>(testNode, node);
			//Assert.Fail();
		}
	}
}