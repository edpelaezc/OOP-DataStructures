#pragma once
#include "MyLinkedList.h"

template<class T>
class CircularLinkedList
{
public:
	CircularLinkedList();
	Node<T> *tail;
	int listSize;
	int size();
	bool isEmpty();
	T first();
	T last();
	void rotate();
	void addFirst(T n);
	void addLast(T n);
	T removeFirst();
	bool search(T reference);
	void showElements();
	~CircularLinkedList();
};

