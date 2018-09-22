#include "stdafx.h"
#include "LinkedStackCpp.h"

template <typename T>
LinkedStackCpp<T>::LinkedStackCpp()
{
	myList = new MyLinkedListCpp();
}

template <typename T>
int LinkedStackCpp<T>::size() {
	return myList->size();
}

template <typename T>
bool LinkedStackCpp<T>::isEmpty()
{
	return myList->isEmpty();
}

template <typename T>
T LinkedStackCpp<T>::pop()
{
	return myList->removeFirst();
}

template <typename T>
void LinkedStackCpp<T>::push(T t)
{
	myList->addFirst(t);
}

template <typename T>
T LinkedStackCpp<T>::top()
{
	return myList->first();
}

template <typename T>
LinkedStackCpp<T>::~LinkedStackCpp()
{
}
