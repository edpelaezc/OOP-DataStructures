#include "pch.h"
#include "Node.h"


Node::Node(int newElement, Node *nextNode)
{
	element = newElement;
	next = nextNode;
}


int Node::getElement() {
	return element;
}

Node* Node::getNext() {
	return next;
}

void Node::setNext(Node *next) {
	this->next = next;
}

Node::~Node()
{
}