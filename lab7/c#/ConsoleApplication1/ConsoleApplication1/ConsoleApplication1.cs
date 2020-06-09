public class List
{
	public List() //конструктор списку
	{
		size = 0;
		head = null;
	}

	public int getSize() //пошук довжини списку
	{
		return size;
	}

	public void push_back(double data) //функція для додавання елементу до кінця списку
	{
		if (head == null)
		{
			head = new Node(data);
		}
		else
		{
			Node current = this.head;
			while (current.NextPointer != null)
			{
				current = current.NextPointer;
			}
			current.NextPointer = new Node(data);
		}

		size++;
	}

	public void erase(int index) //функція для видалення елементів з кінця списку
	{

		if (index == 0) //видалення "голови" списку
		{
			Node tmp = head;
			head = head.NextPointer;
			tmp = null;
			size--;
		}

		else //видалення одного з елементів списку, які не є "головою"
		{
			Node previous = this.head;
			for (int i = 0; i < index - 1; i++)
			{
				previous = previous.NextPointer;
			}

			Node toDelete = previous.NextPointer;
			previous.NextPointer = toDelete.NextPointer;
			toDelete = null;
			size--;
		}

	}

	public double this[int index] //перевантаження оператору для використання індексування елементів списку
	{
		get
		{
			int counter = 0;
			Node current = this.head;
			while (current != null)
			{
				if (counter == index)
				{
					return current.data;
				}
				current = current.NextPointer;
				counter++;
			}
		}
		set
		{
			current.data = value;
		}
	}

	private class Node //допоміжний клас з покажчиками на елементи списку
	{
		public Node NextPointer;
		public double data;
		public Node(double data, Node NextPointer = null)
		{
			this.data = data;
			this.NextPointer = NextPointer;
		}
	}

	private Node head;
	private int size;

}