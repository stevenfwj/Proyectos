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
	cin >> i;
	cin >> j;
	Vectores vec;
	vec.setFilCol(i,j);
	cout << vec.getVec() << endl;
}