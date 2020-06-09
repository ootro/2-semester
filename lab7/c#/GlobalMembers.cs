using System;

public static class GlobalMembers
{
	public static double searchAvgValue(List list) //функція визначенняя кількості елементів, що є більшими за середнє значення
	{
		double avgValue = 0;
		for (int i = 0; i < list.getSize(); i++)
		{
			avgValue += list[i];
		}

		avgValue /= list.getSize();


		int items = 0;
		for (int i = 0; i < list.getSize(); i++)
		{
			if (list[i] > avgValue)
			{
				items += 1;

			}
			else
			{
				items += 0;
			}
		}
		return items;
	}



	static int Main()
	{
		setlocale(LC_ALL, "Ukrainian");
		Console.Write("Пiнчук Артур, IС-93");
		Console.Write("\n");
		List list = new List();
		list.push_back(5);
		list.push_back(10);
		list.push_back(20);
		list.push_back(25);
		list.push_back(30);
		list.push_back(40);
		list.push_back(45);
		list.push_back(50);
		list.push_back(60);
		list.push_back(65);

		for (int i = 0; i < list.getSize(); i++)
		{
			Console.Write(i);
			Console.Write("---");
			Console.Write(list[i]);
			Console.Write("\n");
		}

		Console.Write("Amount of items bigger than AvgValue: ");
//C++ TO C# CONVERTER TODO TASK: The following line was determined to contain a copy constructor call - this should be verified and a copy constructor should be created:
//ORIGINAL LINE: System.Console.Write(searchAvgValue(list));
		Console.Write(searchAvgValue(new List(list)));
		Console.Write("\n");

		for (int i = 0; i < list.getSize(); i += 1)
		{
			list.erase(i);
		}

		Console.Write("List after erasing:");
		Console.Write("\n");

		for (int i = 0; i < list.getSize(); i++)
		{
			Console.Write(list[i]);
			Console.Write(" ");
		}
		return 0;
	}
}