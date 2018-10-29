#include "pch.h"
#include "MyLinkedList.h"
#include <iostream>

template<class Data>
MyLinkedList<Data>::MyLinkedList() {
	head = NULL;
	tail = NULL;
	listSize = 0;
}

template<class Data>
int MyLinkedList<Data>::size() { return listSize; }

template<class Data>
bool MyLinkedList<Data>::isEmpty() { return listSize == 0; }

template<class Data>
Data MyLinkedList<Data>::first() {
	if (isEmpty()) {
		return NULL;
	}
	else {
		return head->getElement();
	}
}

template<class Data>
Data MyLinkedList<Data>::last() {
	if (isEmpty()) {
		return NULL;
	}
	else {
		return tail->getElement();
	}
}


template<class Data>
void MyLinkedList<Data>::addFirst(Data d) {
	head = new Node<Data>(d, head);
	if (listSize == 0) {
		tail = head;
	}
	listSize++;
}

template<class Data>
void MyLinkedList<Data>::addLast(Data d) {
	Node<Data> newest = new Node<Data>(d, NULL);
	if (isEmpty()) {
		head = newest;
	}
	else {
		tail->setNext(newest);
	}
	tail = newest;
	listSize++;
}

template<class Data>
Data MyLinkedList<Data>::removeFirst() {
	if (isEmpty()) {
		return NULL;
	}
	else {
		Data auxiliary = head->getElement();
		head = head->getNext();
		listSize--;
		if (listSize == 0)
		{
			tail = NULL;
		}
		return auxiliary;
	}
}

template<class Data>
bool MyLinkedList<Data>::searchElement(Data reference) {
	Node<Data> auxiliar = head;
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

template<class Data>
void MyLinkedList<Data>::showElements() {
	Node<Data> auxiliar = head;
	while (auxiliar != NULL) {
		std::cout << auxiliar->getElement() << "\t";
		auxiliar = auxiliar->getNext();
	}
}

template<class Data>
MyLinkedList<Data>::~MyLinkedList() {
}
