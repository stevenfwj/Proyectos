#include "Test1.h"


Test1::Test1()
{
}


Test1::~Test1()
{
}


int Test1::Vec()
{
	return 0;
}

void Test1::setFilCol(int x, int y)
{
	a = x;
	b = y;

	cin >> a >> ", ">> b;

	
}

int Test1::getFilasColumnas()
{

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

