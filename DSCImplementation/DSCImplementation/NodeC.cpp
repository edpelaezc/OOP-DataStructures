#include "stdafx.h"
#include "NodeC.h"
#include <iostream>

template <typename T>
NodeC<T>::NodeC(T newElement, NodeC<T> *nextNode)
{	
	element = newElement;
	next = nextNode;
}

template <typename T>
T NodeC<T>::getElement() {
	return element;
}

template <typename T>
NodeC<T>* NodeC<T>::getNext() {
	return next;
}

template <typename T>
void NodeC<T>::setNext(NodeC<T> *next) {
	this->next = next;
}

template <typename T>
NodeC<T>::~NodeC()
{
}

