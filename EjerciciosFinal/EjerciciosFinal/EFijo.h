#pragma once
#include <string>
#include "Empleado.h"

using namespace std;
class EFijo: public Empleado
{
public:
	EFijo();
	EFijo(string eNombre, int eEdad, int eDui, int eTipo, int fA�o, int fSueldo, int fComplemento);
	void setA�o(int fA�o);
	int getA�o();
	void setSueldo(int fSueldo);
	int getSueldo();
	void setComplemento(int fComplemento);
	int getComplemento();
	int calcularSueldo();
	~EFijo();
private:
	int a�o;
	int sueldo;
	int complemento;
};

