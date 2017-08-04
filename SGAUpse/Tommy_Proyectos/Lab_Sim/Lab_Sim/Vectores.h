#ifndef VECTORES_H_
#define VECTORES_H_

#include <iostream>
#include <string.h>
#include <array>


using namespace std;

class Vectores
{
private:

	
	


public:
	Vectores();
	int a;
	int b;
	int c[1][1];
	//int Vec(int x, int y, float z);
	void setFilCol(int x, int y);
	void setVec();
	int setVec1();
	int getVec();
	float multVect();
	
	~Vectores();
};

#endif 

