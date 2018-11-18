#pragma once
#include <string>
#include "Empleado.h"

using namespace std;
class ETemporal: public Empleado
{
public:
	ETemporal();
	ETemporal(string eNombre, int eEdad, int eDui, int eTipo, int tIngreso, int tSalida, int sueldo);
	void setIngreso(int tIngreso);
	int getIngreso();
	void setSalida(int tSalida);
	int getSalida();
	void setSueldoMensual(int tSueldo);
	int getSueldoMensual();
	int calcularSueldo();
	~ETemporal();
private:
	int ingreso;
	int salida;
	int sueldoMensual;
};

