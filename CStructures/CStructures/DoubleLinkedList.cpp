#include "pch.h"
#include "DoubleLinkedList.h"
#include <iostream>

DoubleLinkedList::DoubleLinkedList()
{
	header = new NodeD(NULL, NULL, NULL);
	trailer = new NodeD(NULL, header, NULL);
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

void DoubleLinkedList::addBetween(int n, nodeD predecessor, nodeD successor) {
	nodeD newest = new NodeD(n, predecessor, successor);
	predecessor->setNext(newest);
	successor->setPrev(newest);
	listSize++;
}

int DoubleLinkedList::remove(NodeD *node) {
	NodeD *predecessor = node->getPrev();
	NodeD *successor = node->getNext();
	predecessor->setNext(successor);
	successor->setPrev(predecessor);
	listSize--;
	return node->getElement();
}

bool DoubleLinkedList::search(int reference) {
	nodeD auxiliar = header->getNext();
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
	return !flag;
}

void DoubleLinkedList::showElements() {
	nodeD auxiliar = header->getNext();
	while (auxiliar != trailer)
	{
		std::cout << auxiliar->getElement() << "\t";
		auxiliar = auxiliar->getNext();
	}
}
DoubleLinkedList::~DoubleLinkedList()
{
}
