// Final1096917.cpp : Este archivo contiene la función "main". La ejecución del programa comienza y termina ahí.
//

#include "pch.h"
#include <iostream>
#include "Electrodomestico.h"
#include "Lavadora.h"
#include "Television.h"

using namespace std;
int main() {    
	FILE *archivo;
	char caracter;
	string cadena = "";
	string atributos[7];
	archivo = fopen("informacion.txt", "r");
	int cont = 0;

	if (archivo == NULL) {
		cout << "Error en apertura de archivo";
	}
	else {
		caracter = fgetc(archivo);
		while (caracter != EOF) {
			if (caracter != '\n') {
				if (caracter != '|') {
					cadena += caracter;
					caracter = fgetc(archivo);
				}
				else {
					atributos[cont] = cadena;
					cadena = "";
					caracter = fgetc(archivo);
					cont++;
				}
			}
			else {
				atributos[cont] = cadena;
				cadena = "";				
				//inicializar electrodomestico con su constrcutor e ingresarlo a la lista enlazda.
				if (atributos[0] == "Lavadora") {
					Lavadora aux = *new Lavadora(stof(atributos[1].c_str()), atributos[2], atributos[3], atoi(atributos[4].c_str()), atoi(atributos[5].c_str()));
				}				
				else {
					Television aux = *new Television(stof(atributos[1].c_str()), atributos[2], atributos[3], atoi(atributos[4].c_str()), atoi(atributos[5].c_str()), atributos[6]);
				}
				cont = 0;
				caracter = fgetc(archivo);
			}
		}
	}
	fclose(archivo);
}