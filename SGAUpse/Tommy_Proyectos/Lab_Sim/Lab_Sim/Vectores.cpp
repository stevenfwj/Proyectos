#include "Vectores.h"
#include <iostream>
using namespace std;

Vectores::Vectores()
{
}


Vectores::~Vectores()
{
}


int Vectores::Vec()
{
	return 0;
}


void Vectores::setFilCol(int x, int y)
{
	a = x;
	b = y;


}

void Vectores::setVec()
{
	a;
	b;

	int cont = 0;
	/*	int i;
	int j;*/
	cout << "m: Filas" << endl;
	cout << "m = " << a << endl;
	cout << endl;


	cout << "n: Columnas" << endl;
	cout << "n = " << b << endl;
	cout << endl;


	for (cont = 0; cont < a; cont++)
	{
		for (cont = 0; cont < b; cont++)
		{
			cout << "Valores: " << flush;
			cin >> c[a][b];
			cout << endl;
		}

	};
}

int Vectores::getVec()
{
	cout << "Vector es: " << endl;
	return c[a][b];
}
