#include "pch.h"
#include "Electrodomestico.h"


Electrodomestico::Electrodomestico() {}

float Electrodomestico::getPrecioBase() { return precioBase; }

void Electrodomestico::setPrecioBase(float ePrecio) { precioBase = ePrecio; }

string Electrodomestico::getColor() { return color; }

void Electrodomestico::setColor(string eColor) { 
	if (eColor == "-") { 
		color = "azul"; 
	}
	else {
		color = eColor; 
	}
}

string Electrodomestico::getConsumo() { return consumo; }

void Electrodomestico::setConsumo(string eConsumo) { consumo = eConsumo; }

int Electrodomestico::getPeso() { return peso; }

void Electrodomestico::setPeso(int ePeso) { peso = ePeso; }

float Electrodomestico::calcularPrecio() { return precioBase; }

Electrodomestico::~Electrodomestico() {}
