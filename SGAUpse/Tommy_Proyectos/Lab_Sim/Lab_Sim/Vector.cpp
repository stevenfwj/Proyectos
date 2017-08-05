#include <iostream>
#include <iomanip>
#include <string.h>
#define _USE_MATH_DEFINES
#include <math.h>
#include "Vectores.h"

using namespace std;


int main()
{
	int i; //valor de las filas
	int j; //valor de las columnas
	int k; //Dato asignado en una posición del vector o matriz


	/*cout << "i: Filas" << endl; 
	cout << "j: Columnas" << endl;

	cout << "Ingrese el Valor de i: " << flush;
	cin >> i;
	cout << "i = " << i << endl;
	cout << endl;
	cout << "Ingrese el valor de j: " << flush;
	cin >> j;
	cout << "j = " << j << endl;
	cout << endl;
	cout << "Ingrese su Valor: " << flush;*/


	Vectores vec;

	vec.setVec2Length(1,2);
	vec.setVec2(0, 0, 12);
	vec.setVec2(0, 1, 16);
	
	
	
	cout << vec.getVec2(6,0) << endl;

	float norma;

	norma = sqrt(pow(vec.getVec2(0, 1), 2) + pow(vec.getVec2(0,0), 2));

	cout << norma << endl;
	

}