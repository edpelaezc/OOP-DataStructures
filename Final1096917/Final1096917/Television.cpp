#include "pch.h"
#include "Television.h"


Television::Television(int ePrecio, string eColor, string eConsumo, int ePeso, int tResolucion, bool tSintonizador) {
	this->setPrecioBase(ePrecio);
	this->setColor(eColor);
	this->setConsumo(eConsumo);
	this->setPeso(ePeso);
	resolucion = tResolucion;
	sintonizador = tSintonizador;
}

int Television::getResolucion() { return resolucion; }
void Television::setResolucion(int tResolucion) { resolucion = tResolucion; }
bool Television::getSintonizador() { return sintonizador; }
void Television::setSintonizador(bool tSintonizador) { sintonizador = tSintonizador; }
void Television::toString() {
	cout << "[Precio]: " << getPrecioBase() << "[Color]: " << getColor() << "[Consumo energetico]: " << getConsumo()
		<< "[Peso]: " << getPeso() << "[Resolucion]: " << resolucion << "[Sintonizador]: " << sintonizador << endl;
}

Television::~Television() {}
