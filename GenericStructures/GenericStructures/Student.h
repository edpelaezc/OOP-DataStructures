#pragma once
#include <iostream>
#include <string.h>
#include <string>
#include <stdio.h>
#include <stdlib.h>

class Student
{
public:
	Student();
	Student(int carnet, char *name);
	void toString();
	int getCarnet();
	void setCarnet(int sCarnet);
	char* getName();
	void setName(char *sName);
	~Student();
private:
	int carnet;
	char *name;
};

