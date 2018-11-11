#include "pch.h"
#include "Persona.h"
#include <iostream>

using namespace std;
Persona::Persona()
{
}

string Persona::getName()
{
	return name;
}
void Persona::setName(string pName)
{
	name = pName;
}

Persona::~Persona()
{
}
