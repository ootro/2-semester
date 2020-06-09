#include <iostream>

using namespace std;

void increase(int* x) {
	int bit = 1, counter = 0;
	while (bit != 0) {
		bit = (*x >> counter) & 1;
		*x = *x ^ (1 << counter);
		counter++;
	}
}

bool compare(int a, int b) {
	int bitA, bitB;
		for (int i = 0; i <= 31; i++) {
			bitA = (a >> i) & 1;
			bitB = (b >> i) & 1;
			cout << bitA << " " << bitB << endl;
			if (bitA != bitB)
				return 0;
		}
	return 1;
}


void main() {
	setlocale(LC_ALL, "Rus");
	cout << "Роботу виконав студент групи IС-93 факультету iнформатики та обчислювальної технiки Пiнчук Артур" << endl;
	int a = 63, b = -18, c = 92;
	increase(&a);
	cout << a << endl << endl;
	bool res = compare(b, c);
	cout << res << endl;


	system("pause");
}