// Proyecto2_1096917.cpp : Este archivo contiene la función "main". La ejecución del programa comienza y termina ahí.
//

#include "pch.h"
#include "BinaryTree.h"
#include "BinaryTree.cpp"
#include <iostream>

using namespace std;
int main()
{    
	int opt = 0;
	cout << "SEGUNDO PROYECTO \nClasificacion para el juego de las estrellas." << endl;

	do {
		cout << "\nsSELECCIONE UNA OPCION" << endl;
		cout << "1. MANEJO DE DATOS" << endl;
		cout << "2. REPORTE ESTADISTICAS" << endl;
		cout << "3. SIMULACION"<< endl;
		cin >> opt;

		switch (opt)
		{
		case 1: {
		}break;

		case 2: {
		}break;

		case 3: {
		}break;

		default:
			cout << "GRACIAS POR USAR EL PROGRAMA" << endl;
			break;
		}

	} while (opt != 0);
}