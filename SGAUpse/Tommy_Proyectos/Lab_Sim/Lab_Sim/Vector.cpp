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
	int l; //contador para ingreso de datos del vector o matriz en terminos de filas
	int o; //contador para ingreso de datos del vector o matriz en terminos de columnas
	int n;
	int m; //arreglo de cuadrados
	int p; //arreglo de cuadrados
	double norma;

	cout << "i: Filas" << endl; 
	cout << "j: Columnas" << endl;

	cout << "Ingrese el Valor de i: " << flush;
	cin >> i;
	cout << "i = " << i << endl;
	cout << endl;
	cout << "Ingrese el valor de j: " << flush;
	cin >> j;
	cout << "j = " << j << endl;
	cout << endl;
	cout << "Ingrese su Valor: " << flush;


	Vectores vec;

	vec.setVec2Length(4,3);
	vec.setVec2(0, 0, 3);
	vec.setVec2(0, 1, 12);
	vec.setVec2(0, 2, 9);
	vec.setVec2(1, 0, 63);
	vec.setVec2(1, 1, 1);
	vec.setVec2(1, 2, 6);
	
	
	cout << vec.getVec2(4,1) << endl;


}