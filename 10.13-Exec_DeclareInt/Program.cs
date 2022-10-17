using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _10._13_Exec_DeclareInt
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//計算 1 + (2+2) * 3 -1
			int sum = 1 + (2 + 2) * 3 - 1;
			Console.WriteLine("Q1: 1 + (2+2) * 3 -1 ?");
			Console.WriteLine("A1: " + sum);
			Console.WriteLine();

			//求120/7的商以及餘數是多少
			int quotient = 120 / 7;
			int modulo = 120 % 7;
			Console.WriteLine("Q2: 求120/7的商以及餘數是多少?");
			Console.WriteLine("A2-1: 120/7的商是" + quotient);
			Console.WriteLine("A2-2: 120/7的餘數是" + modulo);
			Console.WriteLine();

			//判斷9, 202各是奇數或者偶數
			Console.WriteLine("Q3: 判斷9, 202各是奇數或者偶數?");
			int num1 = 9;
			int num2 = 202;

		
			if (num1 % 2 == 0)
			{
				Console.WriteLine("A3-1: " + num1 + "是偶數。");
			}
			else
			{
				Console.WriteLine("A3-1: " + num1 + "是奇數。");
			}

			if (num2 % 2 == 0)
			{
				Console.WriteLine("A3-2:" + num2 + "是偶數。");
			}
			else
			{
				Console.WriteLine("A3-2:" + num2 + "是奇數。");
			}

			Console.WriteLine();

			//根據兩個變數大小，視需要對調兩個變數的值
			Console.WriteLine("Q4: 根據兩個變數大小，視需要對調兩個變數的值?");
			Console.WriteLine("A4-1(方法一):");

			//方法一
			int a = 9;
			int b = 8;
			Console.WriteLine("第一個變數是: " + a);
			Console.WriteLine("第二個變數是: " + b);

			int temp = a;
			a = b;
			b = temp;
			Console.WriteLine("修改順序後的第一個變數是: " + a);
			Console.WriteLine("修改順序後的第二個變數是: " + b);
			Console.WriteLine();


			//方法二﹔遞增排列
			int ascending = 1; //ascending
			int descending = 2; //descending
			Console.WriteLine("A4-2(方法二):");
			Console.Write("請輸入第一個數字:");
			int number1 = Convert.ToInt32(Console.ReadLine());
			Console.Write("請輸入第二個數字:");
			int number2 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("請輸入想要的排列方式:" + "1. 遞增" + "2. 遞減");
			int method = Convert.ToInt32(Console.ReadLine());

			if (method == ascending && number1 >= number2)
			{
				temp = number1;
				number1 = number2;
				number2 = temp;
				Console.WriteLine("兩數字的遞增順序是" + number1 + "," + number2);
			} else if (method == ascending && number1 < number2)
			{
				Console.WriteLine("兩數字的遞增順序是" + number1 + "," + number2);
			} else if (method == descending && number1 >= number2)
			{
				Console.WriteLine("兩數字的遞減順序是" + number1 + "," + number2);
			} else 
			{
				temp = number1;
				number1 = number2;
				number2 = temp;
				Console.WriteLine("兩數字的遞減順序是" + number1 + "," + number2);
			}

			Console.ReadKey();

		}	
	}
}
