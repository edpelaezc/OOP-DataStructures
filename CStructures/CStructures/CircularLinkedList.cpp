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
		tail = new Node(n , NULL);
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
	if (isEmpty) {
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

CircularLinkedList::~CircularLinkedList()
{
}
