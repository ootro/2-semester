#include <iostream>
#include <vector>
using namespace std;


class Line //клас-рядок
{
private:
	vector<char> line; //вектор рядку 
public:

	Line(char* str) //об'єкту рядку
	{
		for (int i = 0; i < strlen(str); i++) //цикл для додавання рядків в кінці тексту
			line.push_back(str[i]); //власне додавання рядків
		line.push_back('\n'); //перенесення на новий рядок
	}

	void Clear()  //видалення рядка
	{
		while (line.size() != 0) //умова для видалення про те, що рядок не пустий
			line.pop_back(); //видалення
	}

	unsigned short CountSpace() //підрахунок пробілів
	{
		unsigned short count = 0; //лічильник 
		for (int i = 0; i < line.size(); i++)
			if (line[i] == ' ')
				count++;
		return count;
	}

	unsigned short GetSize()  //довжина рядку 
	{
		unsigned short size = 0;
		for (int i = 0; i < line.size(); i++)
			size++;
		return size;
	}

	int GetCount() //знаходження кількісті символів у рядку
	{
		int count = 0;
		for (int i = 0; i < line.size(); i++)
			count++;
		return count - 1;
	}

	int GetNumberCount() //пошук чисел в рядку
	{
		int count = 0; //лічильник чисел
		for (int i = 0; i < line.size(); i++)
			if (int(line[i]) - 48 >= 0 && int(line[i]) - 48 <= 9)
				count++;
		return count;
	}

	void Print() //виведення рядку
	{
		for (int i = 0; i < line.size(); i++)
			cout << line[i];
	}
};

class Text //клас-контейнер
{
private:
	vector<Line> text; //вектор тексту
public:
	void Init(vector<Line>& text)
	{
		this->text = text;
	}

	void AddLine(Line str) //додавання рядків до тексту
	{
		text.push_back(str);
	}

	void Clear() //очищення тексту
	{
		for (int i = 0; i < text.size(); i++) //проходження по усьому тексту
			text[i].Clear();
	}

	void DeleteLine(unsigned short number) //видалення конкретного рядку
	{
		text[number].Clear();
	}

	void SearchLongLine() //знаходження найдовшого рядку
	{
		unsigned short max = text[0].GetSize(); //присвоєння максимальної довжини рядка першому рядку
		unsigned short index = 0; //індекс в тексті

		for (int i = 1; i < text.size(); i++)
		{
			if (text[i].GetSize() > max) //умова максимальності
			{
				max = text[i].GetSize(); //присвоєння нового максимуму
				index = i; //зміна індексу
			}
		}
		cout << "The longest row #" << index + 1 << ": ";
		text[index].Print(); //виведення максимального рядку

	}

	int GetCount() //знаходження кількості символів у рядку без пробілів
	{
		int count = 0; //лічильник символів
		for (int i = 0; i < text.size(); i++)
			count += text[i].GetCount() - text[i].CountSpace(); //нове значення для лічильника (загальна к-ть символів - к-ть пробілів)
		return count;
	}

	int GetNumberCount() //знаходження кількості чисел у тексті
	{
		int count = 0; //лічильник чисел
		for (int i = 0; i < text.size(); i++)
			count += text[i].GetNumberCount();
		return count;
	}

	float GetPercent(Text text) //знаходження відсотку чисел у тексті
	{
		float percent = (100 * text.GetNumberCount()) / float(text.GetCount()); 
		return percent;
	}

	void Print() //виведення тексту
	{
		for (int i = 0; i < text.size(); i++)
			text[i].Print();
	}
};

int main()
{
	setlocale(LC_ALL, "Russian");
	cout << "Пiнчук Артур, Варiант №5, IС-93" << endl;
	char** tmp = new char* [255]; //вказівник для введення символів
	for (int i = 0; i < 255; i++)
		tmp[i] = new char[255];

	int k = 0;
	vector<Line> str; //створення рядка
	cout << "Enter text: \n";
	Text text; //створення тексту
	while (true)
	{
		cin.getline(tmp[k], 255); //зчитування рядку
		if (tmp[k][0] == '.') //умова закінчення введення
			break;
		str.push_back(tmp[k]); //додавання рядку до кінця тексту
		k++; //збільшення лічильника індексів
	}
	text.Init(str); //переведення рядків у текст

	for (int i = 0; i < 255; i++)
		delete[] tmp[i];

	cout << "Get the amount of characters #1\n";
	cout << "The amount of all characters: " << text.GetCount() << endl;

	cout << "\nGet the percent of numbers #2\n";
	cout << "Percent of numbers: " << text.GetPercent(text) << "%" << endl;

	cout << "\nGet the longest row #3\n";
	text.SearchLongLine();


	char* ch = new char[255];
	cout << "\nAdding the line #4\n";
	cout << "Enter the line: ";
	cin.getline(ch, 255);
	Line line(ch);
	delete[] ch;
	text.AddLine(line);
	cout << "Text with new row:\n";
	text.Print();

	cout << "\nDelete the line #5\n";
	unsigned short number;
	cout << "\nEnter line's number: ";
	cin >> number;
	text.DeleteLine(number - 1);
	text.Print();

	cout << "\nClear text #6\n";
	text.Clear();
	cout << "The text is cleared\n";
	text.Print();

	return 0;
}