#pragma once
#include "MyLinkedListC.h"
class LinkedStackC
{
public:
	MyLinkedListC *myList;
	LinkedStackC();
	int size();
	bool isEmpty();
	void push(int t);
	int pop();
	int top();
	~LinkedStackC();
};

