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

void DoubleLinkedList::purge() {
	list = new MyLinkedListC();
	NodeD *aux = header->getNext();
	NodeD *aux2 = aux->getNext();
	int cont = 1;
	while (aux2->getNext() != NULL)
	{
		while (aux2 != NULL)
		{
			if (aux->getElement() == aux2->getElement())
			{
				NodeD *auxiliar = header;
				while (auxiliar->getNext() != aux2)
				{
					auxiliar = auxiliar->getNext();
				}
				auxiliar->setNext(aux2->getNext());
				listSize--;
				cont++;
			}
			
			if (aux2->getNext() == trailer)
			{
				if (cont == 3)
				{
					std::cout << aux2->getElement();
				}
			}
			
			aux2 = aux2->getNext();
		}
		aux = aux->getNext();
		aux2 = aux->getNext();
		cont = 1;
		if (aux == NULL || aux2 == NULL)
		{
			break;
		}
	}
}

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

int DoubleLinkedList::leftSearch(int pivot, int intacter) {
	nodeD auxiliar = header->getNext();
	int response = 0;
	while (auxiliar->getElement() != pivot) {
		if (auxiliar->getElement() == intacter) {
			response++;
		}
		auxiliar = auxiliar->getNext();
	}
	return response;
}

int DoubleLinkedList::rightSearch(int pivot, int intacter) {
	nodeD auxiliar = header->getNext();
	int response = 0;

	while (auxiliar->getElement() != pivot) {
		auxiliar = auxiliar->getNext();
	}
	auxiliar = auxiliar->getNext();

	while (auxiliar != trailer) {
		if (auxiliar->getElement() == intacter) {
			response++;
		}
		auxiliar = auxiliar->getNext();
	}
	return response;
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

int DoubleLinkedList::searchPivot(int reference) {
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
