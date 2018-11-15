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

int MyLinkedListC::first() {
	if (isEmpty()) {
		return NULL;
	}
	else {
		return head->getElement();
	}
}

int MyLinkedListC::last() {
	if (isEmpty()) {
		return NULL;
	}
	else {
		return tail->getElement();
	}
}

void MyLinkedListC::addElement(int reference, int t) {
	node auxiliar = head;
	while (auxiliar->getElement() != reference)
	{
		auxiliar = auxiliar->getNext();
	}
	node newNode = new Node(t, auxiliar);
	auxiliar->setNext(newNode);
	listSize++;
}

void MyLinkedListC::addFirst(int t) {
	head = new Node(t, head);
	if (listSize == 0)
	{
		tail = head;
	}
	listSize++;
}

void MyLinkedListC::addLast(int t) {
	node newest = new Node(t, NULL);
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

int MyLinkedListC::remove(int reference) {
	node predecessor = NULL;
	node auxNode = head;
	while (auxNode->getElement() != reference)
	{
		predecessor = auxNode;
		auxNode = auxNode->getNext();
	}
	if (auxNode != NULL)
	{
		if (predecessor != NULL)
		{
			int auxiliary = auxNode->getElement();
			predecessor->setNext(auxNode->getNext());
			listSize--;
			return auxiliary;
		}
		else
		{
			return this->removeFirst();
		}
	}
	else
	{
		return NULL;
	}
}

MyLinkedListC* MyLinkedListC::invert() {
	MyLinkedListC *list = new MyLinkedListC();
	node auxiliar = head;

	while (auxiliar != NULL)
	{
		list->addFirst(auxiliar->getElement());
		auxiliar = auxiliar->getNext();
	}

	return list;
}

int MyLinkedListC::removeFirst() {
	if (isEmpty())
	{
		return NULL;
	}
	else
	{
		int auxiliary = head->getElement();
		head = head->getNext();
		listSize--;
		if (listSize == 0)
		{
			tail = NULL;
		}
		return auxiliary;
	}
}

bool MyLinkedListC::searchElement(int reference) {
	node auxiliar = head;
	bool flag = true;
	while (auxiliar != NULL && flag) {
		if (auxiliar->getElement() == reference)
		{
			flag = false;
		}
		else
		{
			auxiliar = auxiliar->getNext();
		}
	}
	return !flag;
}

void MyLinkedListC::showElements() {
	node auxiliar = head;
	while (auxiliar != NULL)
	{
		std::cout << auxiliar->getElement() << "\t";
		auxiliar = auxiliar->getNext();
	}
}

MyLinkedListC::~MyLinkedListC()
{
}
