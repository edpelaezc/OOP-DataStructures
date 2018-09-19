#include "stdafx.h"
#include "Node.h"
#include <iostream>

Node::Node(int newElement, Node *nextNode = NULL)
{
	element = newElement;
	next = nextNode;
}

int Node::getElement() {
	return element;
}

Node Node::getNext() {
	return *next;
}

void Node::setNext(Node *next) {
	this->next = next;
}

Node::~Node()
{
}
