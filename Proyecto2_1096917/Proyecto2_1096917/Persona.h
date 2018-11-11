#pragma once
#include <string>

using namespace std;
class Persona
{
public:
	Persona();
	string getName();	
	void setName(string pName);
	~Persona();
private:	
	string name;
};

