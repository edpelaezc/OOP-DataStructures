#pragma once
#include "NodeC.h"

template <class T>
class MyLinkedListCpp
{
public:
	NodeC<T>* head;
	NodeC<T>* tail;
	MyLinkedListCpp<T>();		
	int size();
	bool isEmpty();
	T first();
	T last();
	void addFirst(T t);	
	void addLast(T t);
	T removeFirst();
	~MyLinkedListCpp<T>();
private:
	int listSize;
};

