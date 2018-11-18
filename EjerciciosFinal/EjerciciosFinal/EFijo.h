#pragma once
#include <string>
#include "Empleado.h"

using namespace std;
class EFijo: public Empleado
{
public:
	EFijo();
	EFijo(string eNombre, int eEdad, int eDui, int eTipo, int fAño, int fSueldo, int fComplemento);
	void setAño(int fAño);
	int getAño();
	void setSueldo(int fSueldo);
	int getSueldo();
	void setComplemento(int fComplemento);
	int getComplemento();
	int calcularSueldo();
	~EFijo();
private:
	int año;
	int sueldo;
	int complemento;
};

