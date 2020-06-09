#include <iostream>
using namespace std;

void countDigits(string string_name) { //функція з визначення кількості цифр у рядку
	string st;
	st = string_name;
	int count = 0;
	for (int i = 0; i < st.size(); i++)
		if (isdigit(st[i])) count++;
	cout << "Number of digits:" << count;

}
int main()
{
	cout << "Arthur Pinchuk, IS-93" << endl;
	string data; //оголошення рядку
	cin >> data; //ініціалізація рядку
	
	void (*function)(string string_name); //вказівник на функцію

	function = countDigits; //ініціалізація вказівника
	function(data); //виклик функції
}

