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
	void setTipo(int eTipo);
	int getTipo();
	virtual int calcularSueldo();
	~Empleado();
private:
	string nombre;
	int edad;
	int dui;
	int tipo;
};

