#include <iostream>
#include <iomanip>
#include <string.h>
#define _USE_MATH_DEFINES
#include <math.h>
#include "Vectores.h"

using namespace std;


int main()
{
	int i;
	int j;

	cout << "i: Columnas" << endl;
	cout << "j: filas" << endl;

	cout << "Ingrese el Valor de i: " << flush;
	cin >> i;
	cout << "i = " << i << endl;
	cout << endl;
	cout << "Ingrese el valor de j: " << flush;
	cin >> j;
	cout << "j = " << j << endl;
	Vectores vec;
	vec.setFilCol(i,j);
	vec.setVec();
	cout << vec.getVec() << endl;
}