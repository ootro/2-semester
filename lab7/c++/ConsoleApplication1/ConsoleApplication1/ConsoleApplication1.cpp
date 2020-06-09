#include <iostream>
using namespace std;

class List
{
public:
	List() //конструктор списку
	{
		size = 0;
		head = nullptr;
	}

	int getSize() //пошук довжини списку
	{
		return size;
	}

	void push_back(double data) //функція для додавання елементу до кінця списку
	{
		if (head == nullptr)
		{
			head = new Node(data);
		}
		else
		{
			Node* current = this->head;
			while (current->NextPointer != nullptr)
			{
				current = current->NextPointer;
			}
			current->NextPointer = new Node(data);
		}

		size++;
	}

	void erase(int index) //функція для видалення елементів з кінця списку
	{

		if (index == 0) //видалення "голови" списку
		{
			Node* tmp = head;
			head = head->NextPointer;
			delete tmp;
			size--;
		}
		
		else //видалення одного з елементів списку, які не є "головою"
		{
			Node* previous = this->head;
			for (int i = 0; i < index - 1; i++)
				previous = previous->NextPointer;

			Node* toDelete = previous->NextPointer;
			previous->NextPointer = toDelete->NextPointer;
			delete toDelete;
			size--;
		}
		
	}

	double& operator[](const int index) //перевантаження оператору для використання індексування елементів списку
	{
		int counter = 0;
		Node* current = this->head;
		while (current != nullptr)
		{
			if (counter == index)
				return current->data;
			current = current->NextPointer;
			counter++;
		}
	}

private:
	class Node //допоміжний клас з покажчиками на елементи списку 
	{
	public:
		Node* NextPointer;
		double data;
		Node(double data, Node* NextPointer = nullptr)
		{
			this->data = data;
			this->NextPointer = NextPointer;
		}
	};

	Node* head;
	int size;

};

double searchAvgValue(List list) //функція визначенняя кількості елементів, що є більшими за середнє значення 
{
	double avgValue = 0;
	for (int i = 0; i < list.getSize(); i++)
		avgValue += list[i];

	avgValue /= list.getSize();
	

	int items = 0;
	for (int i = 0; i < list.getSize(); i++)
		if (list[i] > avgValue)
		{
			items += 1;
				
		}
		else 
		{
			items += 0;
		}
	return items;
}



int main()
{
	setlocale(LC_ALL, "Ukrainian");
	cout << "Пiнчук Артур, IС-93" << endl;
	List list;
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
		cout << i << "---" << list[i] << endl;

	cout << "Amount of items bigger than AvgValue: " << searchAvgValue(list) << endl;

	for (int i = 0; i < list.getSize(); i += 1)
		list.erase(i);

	cout << "List after erasing:" << endl;

	for (int i = 0; i < list.getSize(); i++)
		cout << list[i] << " ";
	return 0;
}