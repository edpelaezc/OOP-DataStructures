#include "pch.h"
#include "Lavadora.h"

Lavadora::Lavadora() {}

Lavadora::Lavadora(float ePrecio, string eColor, string eConsumo, int ePeso, int lCarga) {
	this->setPrecioBase(ePrecio);
	this->setColor(eColor);
	this->setConsumo(eConsumo);
	this->setPeso(ePeso);
	carga = lCarga;
}

int Lavadora::getCarga() { return carga; }

void Lavadora::setCarga(int lCarga) { carga = lCarga; }

void Lavadora::toString() {	
	cout << "[LAVADORA]-" << "[Precio]: " << getPrecioBase() << "; [Color]: " << getColor() << "; [Consumo energetico]: " << getConsumo() 
		 << "; [Peso]: " << getPeso() << "; [Carga]: " << carga << endl;
}

Lavadora::~Lavadora() {}
