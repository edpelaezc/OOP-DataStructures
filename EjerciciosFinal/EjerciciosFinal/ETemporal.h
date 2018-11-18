#pragma once
#include <string>
#include "Empleado.h"

using namespace std;
class ETemporal: public Empleado
{
public:
	ETemporal(string eNombre, int eEdad, int eDui, string tIngreso, string tSalida);
	void setIngreso(string tIngreso);
	string getIngreso();
	void setSalida(string tSalida);
	string getSalida();
	~ETemporal();
private:
	string ingreso;
	string salida;
};

