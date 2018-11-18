#pragma once
#include <string>

using namespace std;
class Empleado
{
public:
	Empleado();
	void setNombre(string eNombre);
	string getNombre();
	void setEdad(int eEdad);
	int getEdad();
	void setDui(int eDui);
	int getDui();
	~Empleado();
private:
	string nombre;
	int edad;
	int dui;
};

