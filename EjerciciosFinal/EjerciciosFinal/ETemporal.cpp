#include "pch.h"
#include "ETemporal.h"

ETemporal::ETemporal() {}

ETemporal::ETemporal(string eNombre, int eEdad, int eDui, int eTipo, int tIngreso, int tSalida, int sueldo) {
	this->setNombre(eNombre);
	this->setEdad(eEdad);
	this->setDui(eDui);
	this->setTipo(eTipo);
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

int ETemporal::calcularSueldo() {
	return sueldoMensual;
}

ETemporal::~ETemporal() {}
