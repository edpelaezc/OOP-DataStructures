#pragma once
#include <string>
class Persona
{
public:
	Persona();
	int getAge();
	char* getName();
	void setAge(int pAge);
	void setName(char pName[]);
	//void toString();
	~Persona();
private:
	int age;
	char *name;
};

