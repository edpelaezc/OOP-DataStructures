#include "pch.h"
#include "ETemporal.h"


ETemporal::ETemporal(string eNombre, int eEdad, int eDui, string tIngreso, string tSalida) {
	this->setNombre(eNombre);
	this->setEdad(eEdad);
	this->setDui(eDui);
	ingreso = tIngreso;
	salida = tSalida;
}

void ETemporal::setIngreso(string tIngreso) { ingreso = tIngreso; }

string ETemporal::getIngreso() { return ingreso; }

void ETemporal::setSalida(string tSalida) { salida = tSalida; }

string ETemporal::getSalida() { return salida; }

ETemporal::~ETemporal() {}
