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
	cout << "[LAVADORA]-" << "[Precio base]:" << getPrecioBase() << "; [Color]:" << getColor() << "; [Consumo energetico]:" << getConsumo() 
		 << "; [Peso]:" << getPeso() << "; [Carga]:" << carga << "; [Precio final]:" << calcularPrecio() << endl;
}

float Lavadora::calcularPrecio() {
	float response = getPrecioBase();
	
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

	if (carga > 30) {
		response += 50;
	}
	
	return response;
}

Lavadora::~Lavadora() {}
