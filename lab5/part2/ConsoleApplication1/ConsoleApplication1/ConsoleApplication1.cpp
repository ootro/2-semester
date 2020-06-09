#include <iostream>
#include <cmath>
using namespace std;
class Figure //абстрактний клас Фігура
{
public:
	float virtual getArea() = 0;

	float virtual getLength() = 0;
};

class Circle : public Figure //похідний клас Коло
{
private:
	float radius; //оголошуємо змінну радіусу
public:
	Circle(float radius) //конструктор
	{
		this->radius = radius; //вказівник 
	}

	float getLength() override
	{
		return 2 * 3.14 * radius; //формула обчислення довжини кола
	}

	float getArea() override
	{
		return 3.14 * pow(radius, 2); //формула обчислення площі кола
	}
};

class Elipse : public Figure
{
private:
	float a, b; //оголошуємо значення піввісей еліпса
public:
	Elipse(float a, float b) //конструктор з вказівниками
	{
		this->a = a;
		this->b = b;
	}

	float getLength() override
	{
		return 3.14 * (a + b); //формула обчислення довжини еліпса
	}

	float getArea() override
	{
		return 3.14 * a * b; //формула обчислення площі еліпса
	}

};

int main()
{
	setlocale(LC_ALL, "Ukrainian");
	Circle a(5); //створюємо об'єкт Коло з радіусом 5
	Elipse b(3, 5); //створюємо об'єкт Еліпс з півосями 3 та 5
	cout << "Довжина кола: " << a.getLength() << endl;
	cout << "Площа кола: " << a.getArea() << endl;
	cout << "Довжина елiпса: " << b.getLength() << endl;
	cout << "Площа еліпса: " << b.getArea() << endl;
	return 0;
}