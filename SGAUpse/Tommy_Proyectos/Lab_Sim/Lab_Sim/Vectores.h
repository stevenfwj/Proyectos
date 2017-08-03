#ifndef VECTORES_H_
#define VECTORES_H_

#include <iostream>
#include <string.h>
#include <array>


using namespace std;

class Vectores
{
private:

	int a;
	int b;
	int c[1][1];
	array<int, 1>x;


public:
	Vectores();
	
	int Vec();
	void setFilCol(int x, int y);
	void setVec();
	int setVec1();
	int getVec();
	int tam = 0;
	int Vectorsito[1];
	~Vectores();
};

#endif 

