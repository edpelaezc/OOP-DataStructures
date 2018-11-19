#include "pch.h"
#include "Television.h"

Television::Television() {}

Television::Television(float ePrecio, string eColor, string eConsumo, int ePeso, int tResolucion, string tSintonizador) {
	this->setPrecioBase(ePrecio);
	this->setColor(eColor);
	this->setConsumo(eConsumo);
	this->setPeso(ePeso);
	resolucion = tResolucion;
	if (tSintonizador == "si") {
		sintonizador = true;
	}
	else {
		sintonizador = false;
	}
}

int Television::getResolucion() { return resolucion; }

void Television::setResolucion(int tResolucion) { resolucion = tResolucion; }

bool Television::getSintonizador() { return sintonizador; }

void Television::setSintonizador(bool tSintonizador) { sintonizador = tSintonizador; }

void Television::toString() {
	cout << "[TELEVISION]-" << "[Precio base]:" << getPrecioBase() << "; [Color]:" << getColor() << "; [Consumo energetico]:" << getConsumo()
		<< "; [Peso]:" << getPeso() << "; [Resolucion]:" << resolucion << "; [Sintonizador]:" << sintonizador << "; [Precio final]:" << calcularPrecio() << endl;
}

int Television::calcularPrecio() {
	int response = getPrecioBase();

	//verificar el consumo energetico y sumarle al precio base las siguientes cantidaddes
	if (getConsumo() == "A") { response += 100; }
	else if (getConsumo() == "B") { response += 80; }
	else if (getConsumo() == "C") { response += 60; }
	else if (getConsumo() == "D") { response += 40; }
	else if (getConsumo() == "E") { response += 20; }
	else { response += 10; }

	//verificar el peso del electrodomestico y sumarle al precio base las siguientes cantidaddes
	if (getPeso() >= 0 && getPeso() < 20) { response += 10; }
	else if (getPeso() >= 20 && getPeso() < 40) { response += 50; }
	else if (getPeso() >= 40 && getPeso() < 60) { response += 80; }
	else { response += 100; }

	if (resolucion > 40) {
		response = (0.30 * response) + response;
	}

	if (sintonizador) {
		response += 30;
	}

	return response;
}

Television::~Television() {}
