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
	/*int Vectorsito[1];
	int tam = 1;
	Vectorsito[100] = 500;
	cout << Vectorsito[99] << endl;*/


	cout << "i: Columnas" << endl; /**/
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

	vec.setVec(5,5,2,87);
	
	vec.setVec1();
	cout << vec.getVec() << endl;
}