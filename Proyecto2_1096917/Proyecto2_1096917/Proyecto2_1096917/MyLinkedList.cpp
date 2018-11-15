#include "pch.h"
#include "MyLinkedList.h"
#include <iostream>

template<typename T>
MyLinkedList<T>::MyLinkedList() {
	head = NULL;
	tail = NULL;
	listSize = 0;
}

template<typename T>
int MyLinkedList<T>::size() { return listSize; }

template<typename T>
bool MyLinkedList<T>::isEmpty() { return listSize == 0; }

template<typename T>
T MyLinkedList<T>::first() {
	if (isEmpty()) {
		return NULL;
	}
	else {
		return head->getElement();
	}
}

template<typename T>
T MyLinkedList<T>::last() {
	if (isEmpty()) {
		return NULL;
	}
	else {
		return tail->getElement();
	}
}


template<typename T>
void MyLinkedList<T>::addFirst(T d) {
	head = new Node<T>(d, head);
	if (listSize == 0) {
		tail = head;
	}
	listSize++;
}

template<typename T>
void MyLinkedList<T>::addLast(T d) {
	Node<T> *newest = new Node<T>(d, NULL);
	if (isEmpty()) {
		head = newest;
	}
	else {
		tail->setNext(newest);
	}
	tail = newest;
	listSize++;
}

template<typename T>
T MyLinkedList<T>::removeFirst() {
	if (isEmpty()) {
		return NULL;
	}
	else {
		T auxiliary = head->getElement();
		head = head->getNext();
		listSize--;
		if (listSize == 0)
		{
			tail = NULL;
		}
		return auxiliary;
	}
}

template<typename T>
bool MyLinkedList<T>::searchElement(T reference) {
	Node<T> *auxiliar = head;
	bool flag = true;
	while (auxiliar != NULL && flag) {
		if (auxiliar->getElement() == reference) {
			flag = false;
		}
		else {
			auxiliar = auxiliar->getNext();
		}
	}
	return !flag;
}

template<typename T>
void MyLinkedList<T>::showElements() {
	Node<T> *auxiliar = head;
	while (auxiliar != NULL) {
		std::cout << auxiliar->getElement() << "->";
		auxiliar = auxiliar->getNext();
	}
}

template<typename T>
MyLinkedList<T>::~MyLinkedList() {
}
