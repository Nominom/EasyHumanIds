using System;
using EasyHumanIds;

namespace TestingSuite
{
	class Program
	{
		static void Main (string[] args) {
			Console.WriteLine("Hello World!");
			Random r = new System.Random();

			for(int i=0; i< 100;i++) {
				Console.WriteLine(HumanIds.Generate(r));
			}
		}
	}
}
