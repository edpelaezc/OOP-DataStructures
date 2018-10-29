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
Data MyLinkedList<Data>::first() {}

template<class Data>
Data MyLinkedList<Data>::last() {}


template<class Data>
void MyLinkedList<Data>::addFirst(Data d) {}

template<class Data>
void MyLinkedList<Data>::addLast(Data d) {}

template<class Data>
Data MyLinkedList<Data>::removeFirst() {}

template<class Data>
bool MyLinkedList<Data>::searchElement(Data reference) {}

template<class Data>
void MyLinkedList<Data>::showElements() {}

template<class Data>
MyLinkedList<Data>::~MyLinkedList() {
}
