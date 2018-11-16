#include "pch.h"
#include "DoubleLinkedList.h"
#include <iostream>

template<typename T>
DoubleLinkedList<T>::DoubleLinkedList()
{
	header = new NodeD<T>(NULL, NULL, NULL);
	trailer = new NodeD<T>(NULL, header, NULL);
	header->setNext(trailer);
	listSize = 0;
}

template<typename T>
int DoubleLinkedList<T>::size() { return listSize; }

template<typename T>
bool DoubleLinkedList<T>::isEmpty() { return listSize == 0; }

template<typename T>
void DoubleLinkedList<T>::purge() {
	NodeD<T> *aux = header;
	NodeD<T> *aux2 = aux->getNext();
	int cont = 1;
	while (aux2->getNext() != NULL)
	{
		while (aux2 != NULL)
		{
			if (aux->getElement() == aux2->getElement())
			{
				NodeD<T> *auxiliar = header;
				while (auxiliar->getNext() != aux2)
				{
					auxiliar = auxiliar->getNext();
				}
				auxiliar->setNext(aux2->getNext());
				listSize--;
				cont++;
			}
			if (cont == 3)
			{
				std::cout << aux2->getElement();
			}
			cont = 1;
			aux2 = aux2->getNext();
		}
		aux = aux->getNext();
		aux2 = aux->getNext();
		if (aux == NULL || aux2 == NULL)
		{
			break;
		}
	}
}

template<typename T>
T DoubleLinkedList<T>::first() {
	if (isEmpty()) {
		return NULL;
	}
	else {
		return header->getNext()->getElement();
	}
}

template<typename T>
T DoubleLinkedList<T>::last() {
	if (isEmpty()) {
		return NULL;
	}
	else {
		return trailer->getPrev()->getElement();
	}
}

template<typename T>
void DoubleLinkedList<T>::addFirst(T n) {
	addBetween(n, header, header->getNext());
}

template<typename T>
void DoubleLinkedList<T>::addLast(T n) {
	addBetween(n, trailer->getPrev(), trailer);
}

template<typename T>
T DoubleLinkedList<T>::removeFirst() {
	if (isEmpty()) {
		return NULL;
	}
	else {
		return remove(header->getNext());
	}
}

template<typename T>
T DoubleLinkedList<T>::removeLast() {
	if (isEmpty()) {
		return NULL;
	}
	else {
		return remove(trailer->getPrev());
	}
}

template<typename T>
void DoubleLinkedList<T>::addBetween(T n, NodeD<T> *predecessor, NodeD<T> *successor) {
	NodeD<T> *newest = new NodeD<T>(n, predecessor, successor);
	predecessor->setNext(newest);
	successor->setPrev(newest);
	listSize++;
}

template<typename T>
T DoubleLinkedList<T>::remove(NodeD<T> *node) {
	NodeD *predecessor = node->getPrev();
	NodeD *successor = node->getNext();
	predecessor->setNext(successor);
	successor->setPrev(predecessor);
	listSize--;
	return node->getElement();
}

template<typename T>
bool DoubleLinkedList<T>::search(T reference) {
	NodeD<T> *auxiliar = header->getNext();
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

template<typename T>
DoubleLinkedList<T>::~DoubleLinkedList()
{
}
