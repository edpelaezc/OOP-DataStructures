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
	BinaryTree *myBinaryTree = new BinaryTree();
	myBinaryTree->add(8);
	myBinaryTree->add(3);
	myBinaryTree->add(1);
	myBinaryTree->add(6);
	myBinaryTree->add(4);
	myBinaryTree->add(7);
	myBinaryTree->add(10);
	myBinaryTree->add(14);
	myBinaryTree->add(13);	
	myBinaryTree->remove(myBinaryTree->root, 8);	
	cout << "MI ARBOL BINARIO" << endl;
	cout << myBinaryTree->root->getLeft()->getElement();
	cout << "RECORRIDO PRE - ORDEN DEL ARBOL BINARIO: " << endl;
	myBinaryTree->preOrder(myBinaryTree->root);
}
