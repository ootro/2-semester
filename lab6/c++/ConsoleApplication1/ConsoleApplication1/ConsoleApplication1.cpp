#include <iostream>
#include <cmath>
#include <exception>
using namespace std;

class Expression //клас-вираз
{
private:
	float a, c, d; //оголошуємо змінні
public:
	Expression() //базовий конструктор
	{
		a = 0;
		c = 0;
		d = 1;
	}
	Expression(float a, float c, float d) //конструктор
	{
		this->a = a;
		this->c = c;
		this->d = d;
	}

	float getResult() //пошук результату
	{
		if (d <= 0) //умова того, що аргумент d повинен бути невід'ємним
			throw invalid_argument("d<=0\n");
		if (c + a == 1) //умова того, що сума с і а повинна не дорівнювати 1
			throw invalid_argument("c+a=1\n");
		return (2 * c - d * sqrt(42 / d)) / (c + a - 1);
	}

	Expression operator+(const Expression& other) //перевантаження оператору +
	{
		return Expression(this->a + other.a, this->c + other.c, this->d + other.d);
	}

	Expression operator-(const Expression& other) //перевантаження оператору -
	{
		return Expression(this->a - other.a, this->c - other.c, this->d - other.d);
	}

	Expression operator*(const Expression& other) //перевантаження оператору *
	{
		return Expression(this->a * other.a, this->c * other.c, this->d * other.d);
	}

	Expression operator/(const Expression& other) //перевантаження оператору /
	{
		if (other.a == 0 || other.c == 0 || other.d == 0) //умова ділення на нуль 
			throw exception("Division by zero\n");
		else
			return Expression(this->a / other.a, this->c / other.c, this->d / other.d);
	}
};

int main()
{
	setlocale(LC_ALL, "Ukrainian");

	cout << "Пiнчук Артур, IC-93" << endl;

	const int size = 6; //ініціалізуємо розмір масиву
	int i = 0; //лічильник 
	Expression arr[size]; //створюємо масив елементів класу
	arr[0] = Expression(1, 3, 42); //ініціалізуємо елементи
	arr[1] = Expression(2, -1, 41);
	arr[2] = arr[0] - arr[1];
	arr[3] = arr[1] + arr[2];
	arr[4] = arr[2] * arr[3];
	try 
	{
		arr[5] = arr[3] / arr[4];
	}
	catch (const exception& ex)
	{
		cout << ex.what();
	}
	while (i < size)
	{
		try
		{
			for (i; i < size; i++)
				cout << "arr[" << i << "] = " << arr[i].getResult() << endl;
		}
		catch (const invalid_argument& ex)
		{
			cout << ex.what();
		}
		i++;
	}

	return 0;
}