#include "pch.h"
#include "DoubleLinkedList.h"
#include <iostream>

DoubleLinkedList::DoubleLinkedList()
{
	header = new Node(NULL, NULL, NULL);
	trailer = new Node(NULL, header, NULL);
	header->setNext(trailer);
	listSize = 0;
}

int DoubleLinkedList::size() { return listSize; }

bool DoubleLinkedList::isEmpty() { return listSize == 0; }

int DoubleLinkedList::first() {
	if (isEmpty()) {
		return NULL;
	}
	else {
		return header->getNext()->getElement();
	}
}

int DoubleLinkedList::last() {
	if (isEmpty()) {
		return NULL;
	}
	else {
		return trailer->getPrev()->getElement();
	}
}

void DoubleLinkedList::addFirst(int n) {
	addBetween(n, header, header->getNext());
}

void DoubleLinkedList::addLast(int n) {
	addBetween(n, trailer->getPrev(), trailer);
}

int DoubleLinkedList::removeFirst() {
	if (isEmpty()) {
		return NULL;
	}
	else {
		return remove(header->getNext());
	}
}

int DoubleLinkedList::removeLast() {
	if (isEmpty()) {
		return NULL;
	}
	else {
		return remove(trailer->getPrev());
	}
}

void DoubleLinkedList::addBetween(int n, node predecessor, node successor) {
	node newest = new Node(n, predecessor, successor);
	predecessor->setNext(newest);
	successor->setPrev(newest);
	listSize++;
}

int DoubleLinkedList::remove(Node *node) {
	Node *predecessor = node->getPrev();
	Node *successor = node->getNext();
	predecessor->setNext(successor);
	successor->setPrev(predecessor);
	listSize--;
	return node->getElement();
}

bool DoubleLinkedList::search(int reference) {
	node auxiliar = header->getNext();
	bool flag = true;
	while (auxiliar != trailer && flag)
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
	return flag;
}

void DoubleLinkedList::showElements() {
	node auxiliar = header->getNext();
	while (auxiliar != trailer)
	{
		std::cout << auxiliar->getElement() << "\t";
		auxiliar = auxiliar->getNext();
	}
}
DoubleLinkedList::~DoubleLinkedList()
{
}
