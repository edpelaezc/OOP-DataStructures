#include "pch.h"
#include "EFijo.h"


EFijo::EFijo(string eNombre, int eEdad, int eDui, int fA�o, int fSueldo, int fComplemento) {
	this->setNombre(eNombre);
	this->setEdad(eEdad);
	this->setDui(eDui);
	a�o = fA�o;
	sueldo = fSueldo;
	complemento = fComplemento;
}

void EFijo::setA�o(int fA�o) { a�o = fA�o; }

int EFijo::getA�o() { return a�o; }

void EFijo::setSueldo(int fSueldo) { sueldo = fSueldo; }

int EFijo::getSueldo() { return sueldo; }

void EFijo::setComplemento(int fComplemento) { complemento = fComplemento; }

int EFijo::getComplemento() { return complemento; }

EFijo::~EFijo() {}
