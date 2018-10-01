#pragma once
#include "NodeC.h"
class MyLinkedListCpp
{
public:
	node head;
	node tail;
	MyLinkedListCpp();
	int size();
	bool isEmpty();
	int first();
	int last();	
	void addElement(int reference, int t);
	void addFirst(int t);
	void addLast(int t);
	int removeFirst();
	~MyLinkedListCpp();
private:
	int listSize;
};


