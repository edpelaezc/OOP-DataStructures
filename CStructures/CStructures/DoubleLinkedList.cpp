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

char DoubleLinkedList::first() {
	if (isEmpty()) {
		return NULL;
	}
	else {
		return header->getNext()->getElement();
	}
}

char DoubleLinkedList::last() {
	if (isEmpty()) {
		return NULL;
	}
	else {
		return trailer->getPrev()->getElement();
	}
}

void DoubleLinkedList::addFirst(char n) {
	addBetween(n, header, header->getNext());
}

void DoubleLinkedList::addLast(char n) {
	addBetween(n, trailer->getPrev(), trailer);
}

char DoubleLinkedList::removeFirst() {
	if (isEmpty()) {
		return NULL;
	}
	else {
		return remove(header->getNext());
	}
}

char DoubleLinkedList::removeLast() {
	if (isEmpty()) {
		return NULL;
	}
	else {
		return remove(trailer->getPrev());
	}
}

void DoubleLinkedList::addBetween(char n, nodeD predecessor, nodeD successor) {
	nodeD newest = new NodeD(n, predecessor, successor);
	predecessor->setNext(newest);
	successor->setPrev(newest);
	listSize++;
}

char DoubleLinkedList::remove(NodeD *node) {
	NodeD *predecessor = node->getPrev();
	NodeD *successor = node->getNext();
	predecessor->setNext(successor);
	successor->setPrev(predecessor);
	listSize--;
	return node->getElement();
}

int DoubleLinkedList::leftSearch(char pivot, char character) {
	nodeD auxiliar = header->getNext();
	int response = 0;
	while (auxiliar->getElement() != pivot) {
		if (auxiliar->getElement() == character) {
			response++;
		}
		auxiliar = auxiliar->getNext();
	}
	return response;
}

int DoubleLinkedList::rightSearch(char pivot, char character) {
	nodeD auxiliar = header->getNext();
	int response = 0;

	while (auxiliar->getElement() != pivot) {
		auxiliar = auxiliar->getNext();
	}
	auxiliar = auxiliar->getNext();

	while (auxiliar != trailer) {
		if (auxiliar->getElement() == character) {
			response++;
		}
		auxiliar = auxiliar->getNext();
	}
	return response;
}

bool DoubleLinkedList::search(char reference) {
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

int DoubleLinkedList::searchPivot(char reference) {
	nodeD auxiliar = header->getNext();
	int response = 0;
	while (auxiliar != trailer) {
		if (auxiliar->getElement() == reference) {
			break;
		}
		auxiliar = auxiliar->getNext();
		response++;
	}
	return response;
}

void DoubleLinkedList::showElements(int reference) {
	nodeD auxiliar = header->getNext();	
	int cont = 0;
	while (auxiliar != trailer) {
		if (cont == reference) {
			std::cout << "Pivote: " << auxiliar->getElement() << "\t";
		}
		else {
			std::cout << auxiliar->getElement() << "\t";
		}
		auxiliar = auxiliar->getNext();	
		cont++;
	}
}
DoubleLinkedList::~DoubleLinkedList()
{
}
