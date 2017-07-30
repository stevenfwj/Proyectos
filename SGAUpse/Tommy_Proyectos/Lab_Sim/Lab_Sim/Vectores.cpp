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

int Vectores::getFilasColumnas()
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
			cout << "Valor: " << c[a][b] << endl;
		}

	};

	return a, b, c[a][b];
}

int Vectores::getVec()
{

	

	return c[a][b];
}
