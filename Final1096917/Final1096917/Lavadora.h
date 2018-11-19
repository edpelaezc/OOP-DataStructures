#pragma once
#include "Electrodomestico.h"
#include <string>
#include <iostream>

using namespace std;
class Lavadora: public Electrodomestico
{
public:
	Lavadora();
	Lavadora(float ePrecio, string eColor, string eConsumo, int ePeso, int lCarga);
	int getCarga();
	void setCarga(int lCarga);
	void toString();
	~Lavadora();
private:
	int carga;
};

