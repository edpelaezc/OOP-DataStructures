// CStructures.cpp : Este archivo contiene la función "main". La ejecución del programa comienza y termina ahí.
//

#include "pch.h"
#include <iostream>
#include "MyLinkedListC.h"
#include "CircularLinkedList.h"
#include "DoubleLinkedList.h"
#include "BinaryTree.h"
#include <string.h>
#include <string>
#include <stdio.h>

using namespace std;
int main()
{
	//Ejercicio 1		
	/*DoubleLinkedList *myList = new DoubleLinkedList();
	string cadena = "";
	char caracter;
	cout << "INGRESE LA CADENA A ANALIZAR: " << endl;
	getline(cin, cadena, '\n');
	for (size_t i = 0; i < cadena.length() - 2; i++)
	{
		caracter = cadena[i];
		if (caracter != ' ') {
			myList->addLast(caracter);
		}		
	}
	char pivote = cadena[cadena.length() - 2];
	char buscar = cadena[cadena.length() - 1];

	myList->showElements(myList->searchPivot(pivote));
	cout << "\nEl caracter a buscar es: " << buscar << endl;
	cout << "\nCOINCIDENCIAS DEL ULITMO CARACTER: " << endl;
	cout << "Del lado izquierdo: " << myList->leftSearch(pivote, buscar) << endl;
	cout << "Del lado derecho: " << myList->rightSearch(pivote, buscar) << endl;*/

	//auxTortuga = 1 + rand() % (1001 - 1); 

	//Ejercicio 2
	BinaryTree *myTree = new BinaryTree();
	myTree->add(15);
	myTree->add(6);
	myTree->add(3);
	myTree->add(9);
	myTree->add(1);
	myTree->add(4);
	myTree->add(12);
	myTree->add(7);
	myTree->add(20);
	myTree->add(18);
	myTree->add(17);
	myTree->add(24);
	myTree->inOrder(myTree->root);
	cout << "Eliminando nodos hoja con valor impar..." << endl;
	myTree->removeLeaf(myTree->root);
	myTree->inOrder(myTree->root);
}
