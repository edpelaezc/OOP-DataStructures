#include "stdafx.h"
#include "MyLinkedListC.h"
#include <iostream>

MyLinkedListC::MyLinkedListC()
{		
	head = NULL;
	tail = NULL;
	listSize = 0;
}

int MyLinkedListC::size() {	return listSize;}

bool MyLinkedListC::isEmpty() { return listSize == 0; }

int MyLinkedListC::first() {
	if (isEmpty()) {
		return NULL;
	} else{
		return head->getElement();
	}
}

int MyLinkedListC::last() {
	if (isEmpty()) {
		return NULL;
	} else{
		return tail->getElement();
	}
}

void MyLinkedListC::addFirst(int t) {	
	head = new Node(t, head);
	if (listSize == 0)
	{
		tail = head;
	}
	listSize++;
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

MyLinkedListC::~MyLinkedListC()
{
}
