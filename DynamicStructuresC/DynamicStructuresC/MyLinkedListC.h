#pragma once
#include "Node.h"
class MyLinkedListC
{
public:
	MyLinkedListC();
	node head;
	node tail;
	int size();
	bool isEmpty();
	int first();
	int last();
	void addFirst(int t);
	void addElement(int reference, int t);
	void addLast(int t);
	int removeFirst();
	~MyLinkedListC();
private:
	int listSize;	
};

