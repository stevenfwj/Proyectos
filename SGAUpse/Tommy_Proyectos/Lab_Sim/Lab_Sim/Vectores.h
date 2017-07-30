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


public:
	Vectores();
	
	int Vec();
	void setFilCol(int x, int y);
	void setVec();
	int getVec();
	~Vectores();
};

#endif 

