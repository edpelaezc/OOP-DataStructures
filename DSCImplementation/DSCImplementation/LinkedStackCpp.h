#pragma once
#include "MyLinkedListCpp.h"

template <class T>
class LinkedStackCpp
{
public:
	MyLinkedListCpp<T> *myList;
	LinkedStackCpp<T>();
	int size();
	bool isEmpty();
	void push(T t);
	T pop();
	T top();
	~LinkedStackCpp<T>();
};

