#include "Vectores.h"
#include <iostream>
using namespace std;

Vectores::Vectores()
{
	tam = 1;
	Vectorsito[tam] = 1;
	cout << Vectorsito[0] << endl;
	
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



}

int Vectores::setVec1()
{
	c[a][b];

	int i;
	int j;

	for (i = 0; i < a; i++)
	{
		for (j = 0; j < b; j++)
		{
			cin >> c[a][b];

		}

	}
	return c[a][b];
}

int Vectores::getVec()
{

	cout << "Vector es: " << endl;
	cout << c[a][b] << endl;
	

	return  0;
}
