#include "pch.h"
#include "EFijo.h"


EFijo::EFijo(string eNombre, int eEdad, int eDui, int fAño, int fSueldo, int fComplemento) {
	this->setNombre(eNombre);
	this->setEdad(eEdad);
	this->setDui(eDui);
	año = fAño;
	sueldo = fSueldo;
	complemento = fComplemento;
}

void EFijo::setAño(int fAño) { año = fAño; }

int EFijo::getAño() { return año; }

void EFijo::setSueldo(int fSueldo) { sueldo = fSueldo; }

int EFijo::getSueldo() { return sueldo; }

void EFijo::setComplemento(int fComplemento) { complemento = fComplemento; }

int EFijo::getComplemento() { return complemento; }

EFijo::~EFijo() {}
