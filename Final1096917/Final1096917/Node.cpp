#include "pch.h"
#include "Node.h"


Node::Node(int nTipo, Lavadora lava, Television tele, Node *nextNode) {	
	tipo = nTipo;
	if (tipo == 1) {//tipo 1 lavadora, tipo 2 television
		lavadora = lava;
	}
	else { 
		television = tele;
	}
	next = nextNode;
}


Electrodomestico Node::getElement() {
	if (tipo == 1) { return lavadora; }
	else { return television; }
}

Node* Node::getNext() {
	return next;
}

void Node::setNext(Node *next) {
	this->next = next;
}

Lavadora Node::getLavadora() { return lavadora; }

Television Node::getTelivision() { return television; }

int Node::getTipo() { return tipo; }

Node::~Node()
{
}