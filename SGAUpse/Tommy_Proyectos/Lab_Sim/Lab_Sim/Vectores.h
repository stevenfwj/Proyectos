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
	float d[1][1] = {};
	int e;
	int f;
	float g;

public:
	Vectores();
	
	//int Vec(int x, int y, float z);
	void setFilCol(int x, int y);
	void setVec();
	int setVec1();
	int getVec();
	
	int setVec2Length(int x, int y); //establece la longitud del vector
	void setVec2(int x, int y, int z); //establece el vector
	float getVec2(int x, int y); //aquí se busca un valor pre-asignado
	

	~Vectores();
};

#endif 

