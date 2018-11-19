#include "pch.h"
#include "MyLinkedListC.h"
#include <iostream>


MyLinkedListC::MyLinkedListC()
{
	head = NULL;
	tail = NULL;
	listSize = 0;
}

int MyLinkedListC::size() { return listSize; }

bool MyLinkedListC::isEmpty() { return listSize == 0; }

Electrodomestico MyLinkedListC::first() {
	if (!isEmpty()) {
		if (head->getTipo() == 1) {
			return head->getLavadora();
		}
		else {
			return head->getTelivision();
		}
	}
}

Electrodomestico MyLinkedListC::last() {
	if (!isEmpty()) {
		if (tail->getTipo() == 1) {
			return tail->getLavadora();
		}
		else {
			return tail->getTelivision();
		}
	}
}

void MyLinkedListC::addFirst(int eTipo, Television tele) {
	head = new Node(eTipo, *new Lavadora(), tele, head);
	if (listSize == 0)
	{
		tail = head;
	}
	listSize++;
}

void MyLinkedListC::addLast(int eTipo, Television tele) {
	node newest = new Node(eTipo, *new Lavadora(), tele, NULL );
	if (isEmpty())
	{
		head = newest;
	}
	else
	{
		tail->setNext(newest);
	}
	tail = newest;
	listSize++;
}

void MyLinkedListC::addFirst(int eTipo, Lavadora lava) {
	head = new Node(eTipo, lava, *new Television(), head);
	if (listSize == 0)
	{
		tail = head;
	}
	listSize++;
}

void MyLinkedListC::addLast(int eTipo, Lavadora lava) {
	node newest = new Node(eTipo, lava, *new Television(), NULL);
	if (isEmpty())
	{
		head = newest;
	}
	else
	{
		tail->setNext(newest);
	}
	tail = newest;
	listSize++;
}

Electrodomestico MyLinkedListC::removeFirst() {
	if (!isEmpty()) {
		Electrodomestico auxiliary = head->getElement();
		head = head->getNext();
		listSize--;
		if (listSize == 0)
		{
			tail = NULL;
		}
		return auxiliary;
	}
}

void MyLinkedListC::showElements() {
	node auxiliar = head;
	while (auxiliar != NULL)
	{
		if (auxiliar->getTipo() == 1) {
			auxiliar->getLavadora().toString();			
		}
		else {
			auxiliar->getTelivision().toString();			
		}
		auxiliar = auxiliar->getNext();
	}
}

MyLinkedListC::~MyLinkedListC() {}
