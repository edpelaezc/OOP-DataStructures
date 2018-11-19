#pragma once
#include <string>

using namespace std;
class Electrodomestico
{
public:
	Electrodomestico();
	int getPrecioBase();
	void setPrecioBase(int ePrecio);
	string getColor();
	void setColor(string eColor);
	string getConsumo();
	void setConsumo(string eConsumo);
	int getPeso();
	void setPeso(int ePeso);
	~Electrodomestico();
private:
	int precioBase;
	string color;
	string consumo;
	int peso;
};

