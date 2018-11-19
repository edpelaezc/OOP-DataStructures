#pragma once
#include "Lavadora.h"
#include "Television.h"
#include "Electrodomestico.h"

class Node
{
public:
	Node(int nTipo, Lavadora lava, Television tele, Node *nextNode);
	Electrodomestico getElement();
	Node* getNext();
	void setNext(Node *next);
	Lavadora getLavadora();
	Television getTelivision();
	int getTipo();
	~Node();
private:
	Lavadora lavadora;
	Television television;
	int tipo;
	Node *next;
}; typedef Node *node;

