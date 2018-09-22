#include "stdafx.h"
#include "MyLinkedListCpp.h"
#include <iostream>

template <typename T>
MyLinkedListCpp<T>::MyLinkedListCpp()
{
	head = NULL;
	tail = NULL;
	listSize = 0;
}

template <typename T>
int MyLinkedListCpp<T>::size() { return listSize; }

template <typename T>
bool MyLinkedListCpp<T>::isEmpty() { return listSize == 0; }

template <typename T>
T MyLinkedListCpp<T>::first() {
	if (isEmpty()) {
		return NULL;
	}
	else {
		return head->getElement();
	}
}

template <typename T>
T MyLinkedListCpp<T>::last() {
	if (isEmpty()) {
		return NULL;
	}
	else {
		return tail->getElement();
	}
}

template <typename T>
void MyLinkedListCpp<T>::addFirst(T t) {
	head = new NodeC(t, head);
	if (listSize == 0)
	{
		tail = head;
	}
	listSize++;
}

template <typename T>
void MyLinkedListCpp<T>::addLast(T t) {
	node newest = new NodeC(t, NULL);
	if (isEmpty())
	{
		head = newest;
	}
	else
	{
		tail->setNext(newest);
	}
	tail = newest;
	listSize++;
}

template <typename T>
T MyLinkedListCpp<T>::removeFirst() {
	if (isEmpty())
	{
		return NULL;
	}
	else
	{
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

template <typename T>
MyLinkedListCpp<T>::~MyLinkedListCpp()
{
}
