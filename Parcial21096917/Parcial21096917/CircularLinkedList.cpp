#include "pch.h"
#include "CircularLinkedList.h"
#include <iostream>


CircularLinkedList::CircularLinkedList()
{
	tail = NULL;
	listSize = 0;
}

int CircularLinkedList::size() { return listSize; }

bool CircularLinkedList::isEmpty() { return listSize == 0; }

int CircularLinkedList::first() {
	if (isEmpty()) {
		return NULL;
	}
	else {
		return tail->getNext()->getElement();
	}
}

int CircularLinkedList::last() {
	if (isEmpty()) {
		return NULL;
	}
	else {
		return tail->getElement();
	}
}

void CircularLinkedList::rotate() {
	if (tail != NULL) {
		tail = tail->getNext();
	}
}

void CircularLinkedList::addFirst(int n) {
	if (listSize == 0) {
		tail = new Node(n, NULL);
		tail->setNext(tail);
	}
	else {
		node newest = new Node(n, tail->getNext());
		tail->setNext(newest);
	}
	listSize++;
}

void CircularLinkedList::addLast(int n) {
	addFirst(n);
	tail = tail->getNext();
}

int CircularLinkedList::removeFirst() {
	if (isEmpty()) {
		return NULL;
	}
	else {
		node head = tail->getNext();
		if (tail == head) {
			tail = NULL;
		}
		else {
			tail->setNext(head->getNext());
		}
		listSize--;
		return head->getElement();
	}
}

bool CircularLinkedList::search(int reference) {
	node auxiliar = tail->getNext();
	bool flag = true;
	while (auxiliar != tail && flag)
	{
		if (auxiliar->getElement() == reference)
		{
			flag = false;
		}
		else
		{
			auxiliar = auxiliar->getNext();
		}
	}

	if (auxiliar == tail && auxiliar->getElement() == reference)
	{
		return flag;
	}
	else
	{
		return !flag;
	}
}

void CircularLinkedList::showElements() {
	node auxiliar = tail->getNext();
	while (auxiliar != tail)
	{
		std::cout << auxiliar->getElement() << "-";
		auxiliar = auxiliar->getNext();
	}
	std::cout << auxiliar->getElement() << "\n";
}

int CircularLinkedList::searchPointer(int rep) {
	node auxiliar = tail->getNext();
	int cont = 0;
	
	while (cont != rep) {		
		auxiliar = auxiliar->getNext();
		auxiliar = auxiliar->getNext();
		cont += 2;
	}
	auxiliar = auxiliar->getNext();
	auxiliar = auxiliar->getNext();
	return auxiliar->getElement();
}

CircularLinkedList::~CircularLinkedList()
{
}
