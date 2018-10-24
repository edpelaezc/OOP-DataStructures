#pragma once
#include "Node.h"

class CircularLinkedList
{
public:
	CircularLinkedList();
	node tail;
	int listSize;
	int size();
	bool isEmpty();
	int first();
	int last();
	void rotate();
	void addFirst(int n);
	void addLast(int n);
	int removeFirst();
	bool search(int reference);
	int searchPointer(int rep);
	void showElements();
	~CircularLinkedList();
};

