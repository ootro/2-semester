#include <iostream>
#include <vector>

using namespace std;

class Shape {

};

class Elipse : public Shape {
public:
	int half1;
	int half2;
	Elipse(int a, int b) {

		half1 = a;
		half2 = b;
	}
	int elipse_area(int half1, int half2)
	{
		int elipse_area = 3.14 * half1 * half2;
		return elipse_area;
	}
	Elipse() {}
};

class Circle : public Elipse {
public:
	int radius;
	Circle(int a) {
		radius = a;
		Elipse(radius, radius);
	}
	int area() {
		int area = 3.14 * radius * radius;
		return area;
	}

};


int main() {
	Circle object1 = Circle(5);
	cout << object1.area() << endl;
	cout << object1.elipse_area(object1.radius, object1.radius) << endl;


}