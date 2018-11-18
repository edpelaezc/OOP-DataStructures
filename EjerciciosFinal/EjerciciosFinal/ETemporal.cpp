#include "pch.h"
#include "ETemporal.h"


ETemporal::ETemporal(string eNombre, int eEdad, int eDui, int tIngreso, int tSalida, int sueldo) {
	this->setNombre(eNombre);
	this->setEdad(eEdad);
	this->setDui(eDui);
	ingreso = tIngreso;
	salida = tSalida;
	sueldoMensual = sueldo;
}

void ETemporal::setIngreso(int tIngreso) { ingreso = tIngreso; }

int ETemporal::getIngreso() { return ingreso; }

void ETemporal::setSalida(int tSalida) { salida = tSalida; }

int ETemporal::getSalida() { return salida; }

void ETemporal::setSueldoMensual(int tSueldo) { sueldoMensual = tSueldo; }

int ETemporal::getSueldoMensual() { return sueldoMensual; }

ETemporal::~ETemporal() {}
