
#include <iostream>
#include <vector>

using namespace std;

class String //клас Рядок
{
public:
	string data; //оголошуємо рядок
	int counter() {
		int count = data.length(); //лічильник довжини рядку
		return count;
	}
	String() {} //конструктор за замовчуванням

};

class CharString : public String //клас Буквений рядок
{
public:

	CharString(string a) //конструктор похідного класу
	{
		data = a;
	}

};

int main()
{
	cout << "Pinchuk Arthur, IS-93" << endl;
	CharString string1 = CharString("This is the first string!");
	cout << string1.data << endl;
	int length1 = string1.counter();
	cout << "It's length: " << length1 << endl;
	CharString string2 = CharString("This is the second string!");
	cout << string2.data << endl;
	int length2 = string2.counter();
	cout << "It's length: " << length2 << endl;
	CharString string3 = CharString("This is the third string!");
	cout << string3.data << endl;
	int length3 = string3.counter();
	cout << "It's length: " << length3 << endl;

	if (length1 > length2 && length3) {
		cout << "The first string is the longest!" << endl;
	}
	else if (length2 > length1 && length3) {
		cout << "The second string is the longest!" << endl;
	}
	else if (length3 > length1 && length2) {
		cout << "The third string is the longest!" << endl;
	}


}