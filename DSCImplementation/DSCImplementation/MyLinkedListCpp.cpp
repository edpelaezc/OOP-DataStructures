#include "stdafx.h"
#include "MyLinkedListCpp.h"
#include <iostream>

MyLinkedListCpp::MyLinkedListCpp()
{
	head = NULL;
	tail = NULL;
	listSize = 0;
}

int MyLinkedListCpp::size() { return listSize; }

bool MyLinkedListCpp::isEmpty() { return listSize == 0; }

int MyLinkedListCpp::first() {
	if (isEmpty()) {
		return NULL;
	}
	else {
		return head->getElement();
	}
}

int MyLinkedListCpp::last() {
	if (isEmpty()) {
		return NULL;
	}
	else {
		return tail->getElement();
	}
}

void MyLinkedListCpp::addElement(int reference, int t) {
	node auxiliar = head;
	while (auxiliar->getElement() != reference)
	{
		auxiliar = auxiliar->getNext();
	}
	node newNode = new NodeC(t, auxiliar);
	auxiliar->setNext(newNode);
	listSize++;
}

void MyLinkedListCpp::addFirst(int t) {
	head = new NodeC(t, head);
	if (listSize == 0)
	{
		tail = head;
	}
	listSize++;
}

void MyLinkedListCpp::addLast(int t) {
	node newest = new NodeC(t, NULL);
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

int MyLinkedListCpp::remove(int reference) {
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

int MyLinkedListCpp::removeFirst() {
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

bool MyLinkedListCpp::searchElement(int reference) {
	node auxiliar = head;
	while (auxiliar != NULL){	
		if (auxiliar->getElement() == reference)
		{			
			return true;
			break;			
		}
		else
		{
			auxiliar = auxiliar->getNext();
		}	
	}

	/*if (auxiliar == NULL)
	{
		return false;
	}*/
}

void MyLinkedListCpp::showElements() {
	node auxiliar = head;
	while (auxiliar != NULL)
	{
		std::cout << auxiliar->getElement() << "\t";
		auxiliar = auxiliar->getNext();
	}
}

MyLinkedListCpp::~MyLinkedListCpp()
{
}
