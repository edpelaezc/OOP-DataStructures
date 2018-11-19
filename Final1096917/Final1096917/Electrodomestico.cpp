#include "pch.h"
#include "Electrodomestico.h"


Electrodomestico::Electrodomestico() {}

int Electrodomestico::getPrecioBase() { return precioBase; }

void Electrodomestico::setPrecioBase(int ePrecio) { precioBase = ePrecio; }

string Electrodomestico::getColor() { return color; }

void Electrodomestico::setColor(string eColor) { color = eColor; }

string Electrodomestico::getConsumo() { return consumo; }

void Electrodomestico::setConsumo(string eConsumo) { consumo = eConsumo; }

int Electrodomestico::getPeso() { return peso; }

void Electrodomestico::setPeso(int ePeso) { peso = ePeso; }

Electrodomestico::~Electrodomestico() {}
