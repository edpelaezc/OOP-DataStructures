#include "stdafx.h"
#include "NodeC.h"
#include <iostream>

NodeC::NodeC(int newElement, NodeC *nextNode)
{
	element = newElement;
	next = nextNode;
}

int NodeC::getElement() {
	return element;
}

NodeC* NodeC::getNext() {
	return next;
}

void NodeC::setNext(NodeC *next) {
	this->next = next;
}

NodeC::~NodeC()
{
}

