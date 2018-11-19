#pragma once
#include <string>
#include <iostream>

using namespace std;
class Electrodomestico
{
public:
	Electrodomestico();
	float getPrecioBase();
	void setPrecioBase(float ePrecio);
	string getColor();
	void setColor(string eColor);
	string getConsumo();
	void setConsumo(string eConsumo);
	int getPeso();
	void setPeso(int ePeso);
	~Electrodomestico();
private:
	float precioBase;
	string color;
	string consumo;
	int peso;
};

