#ifndef TEST1_H_
#define TEST1_H_

#include <iostream>
#include <string.h>
#include <array>

using namespace std;

class Test1
{
private:
	
	int a;
	int b;
	int c[1][1];


public:
	Test1();
	
	int Vec();
	void setFilCol(int x, int y);
	int getFilasColumnas();
	



	~Test1();
};

#endif 