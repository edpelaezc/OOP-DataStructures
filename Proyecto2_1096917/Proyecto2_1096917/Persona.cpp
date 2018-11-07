#include "pch.h"
#include "Persona.h"
#include <iostream>

using namespace std;
Persona::Persona()
{
}

char* Persona::getName()
{
	return name;
}
void Persona::setName(char pName[])
{
	name = pName;
}
int Persona::getAge()
{
	return age;
}
void Persona::setAge(int pAge)
{
	age = pAge;
}

/*void Persona::toString()
{	
	cout << "[Name]: ";
	for (size_t i = 0; i < sizeof(name); i++)
	{
		cout << name[i];
	}
	cout << ", [Age]: " + age;
}*/

Persona::~Persona()
{
}
