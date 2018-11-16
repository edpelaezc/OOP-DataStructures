#include "pch.h"
#include "CircularLinkedList.h"
#include <iostream>

template<typename T>
CircularLinkedList<T>::CircularLinkedList()
{
	tail = NULL;
	listSize = 0;
}

template<typename T>
int CircularLinkedList<T>::size() { return listSize; }

template<typename T>
bool CircularLinkedList<T>::isEmpty() { return listSize == 0; }

template<typename T>
T CircularLinkedList<T>::first() {
	if (isEmpty()) {
		return NULL;
	}
	else {
		return tail->getNext()->getElement();
	}
}

template<typename T>
T CircularLinkedList<T>::last() {
	if (isEmpty()) {
		return NULL;
	}
	else {
		return tail->getElement();
	}
}

template<typename T>
void CircularLinkedList<T>::rotate() {
	if (tail != NULL) {
		tail = tail->getNext();
	}
}

template<typename T>
void CircularLinkedList<T>::addFirst(T n) {
	if (listSize == 0) {
		tail = new Node<T>(n, NULL);
		tail->setNext(tail);
	}
	else {
		Node<T> *newest = new Node<T>(n, tail->getNext());
		tail->setNext(newest);
	}
	listSize++;
}

template<typename T>
void CircularLinkedList<T>::addLast(T n) {
	addFirst(n);
	tail = tail->getNext();
}

template<typename T>
T CircularLinkedList<T>::removeFirst() {
	if (isEmpty()) {
		return NULL;
	}
	else {
		Node<T> head = tail->getNext();
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

template<typename T>
bool CircularLinkedList<T>::search(T reference) {
	Node<T> *auxiliar = tail->getNext();
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

template<typename T>
void CircularLinkedList<T>::showElements() {
	Node<T> *auxiliar = tail->getNext();
	while (auxiliar != tail)
	{
		std::cout << auxiliar->getElement() << "\t";
		auxiliar = auxiliar->getNext();
	}
	std::cout << auxiliar->getElement() << "\n";
}

template<typename T>
CircularLinkedList<T>::~CircularLinkedList()
{
}
