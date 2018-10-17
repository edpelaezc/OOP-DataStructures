#pragma once
#include "Node.h"
class MyLinkedListC
{
public:
	node head;
	node tail;
	MyLinkedListC();
	int size();
	bool isEmpty();
	MyLinkedListC* invert();
	int first();
	int last();
	void addElement(int reference, int t);
	void addFirst(int t);
	void addLast(int t);
	int remove(int reference);
	int removeFirst();
	bool searchElement(int reference);
	void showElements();
	~MyLinkedListC();
private:
	int listSize;
};

