#include "pch.h"
#include "EFijo.h"


EFijo::EFijo(string eNombre, int eEdad, int eDui, int eTipo, int fA�o, int fSueldo, int fComplemento) {
	this->setNombre(eNombre);
	this->setEdad(eEdad);
	this->setDui(eDui);
	this->setTipo(eTipo);
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

int EFijo::calcularSueldo() {
	int numeroA�os = 2018 - a�o;
	int bonificacion = complemento * numeroA�os;
	return sueldo + bonificacion;
}

EFijo::~EFijo() {}
