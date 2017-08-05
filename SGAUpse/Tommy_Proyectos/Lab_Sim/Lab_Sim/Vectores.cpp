#include "Vectores.h"
#include <iostream>
using namespace std;

Vectores::Vectores()
{

}


Vectores::~Vectores()
{
}


void Vectores::setFilCol(int x, int y)
{
	a = x;
	b = y;


}


int Vectores::setVec1()
{
	c[a][b];


	int i;
	int j;


	if ((a > 0) && (b > 0))
	{

		for (i = 0; i < a; i++)
		{
			for (j = 0; j < b; j++)
			{
				cout << "Ingrese el Valor: " << flush;
				cin >> c[i][j];

				cout << "Valor: " << c[i][j] << endl;
			}

		}
	}
	cout << endl;
	return 000;
}


int Vectores::getVec()
{


	cout << "Ingrese la fila que desea buscar: " << flush;
	cin >> a;
	cout << endl;
	cout << "Ingrese la columna que desea buscar: " << flush;
	cin >> b;
	cout << endl;
	cout << endl;

	cout << "Vector es: " << endl;
	cout << c[a][b] << endl;

	return  0;
}


int Vectores::setVec2Length(int x, int y) //establece la longitud del vector
{
	a = x;
	b = y;

	d[x][y];

	return x, y;
}

void Vectores::setVec2(int x, int y, int z) //establece el vector
{
	a = x;
	b = y;
	g = z;
	d[a][b]=g;
}


float Vectores::getVec2(int x, int y) //aquí se busca un valor pre-asignado
{
	a = x;
	b = y;

	return d[a][b];
}
