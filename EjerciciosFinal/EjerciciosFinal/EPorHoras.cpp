#include "pch.h"
#include "EPorHoras.h"


EPorHoras::EPorHoras(string eNombre, int eEdad, int eDui, int hPrecio, int hHorasTrabajadas) {
	this->setNombre(eNombre);
	this->setEdad(eEdad);
	this->setDui(eDui);
	precio = hPrecio;
	horasTrabajadas = hHorasTrabajadas;
}

void EPorHoras::setPrecio(int hPrecio) { precio = hPrecio; }
int EPorHoras::getPrecio() { return precio; }
void EPorHoras::setHorasTrabajadas(int hHorasTrabajadas) { horasTrabajadas = hHorasTrabajadas; }
int EPorHoras::getHorasTrabajadas() { return horasTrabajadas; }

EPorHoras::~EPorHoras() {}
