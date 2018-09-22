#pragma once
#include "MyLinkedListCpp.h"

class LinkedStackCpp
{
public:
	MyLinkedListCpp *myList;
	LinkedStackCpp();
	int size();
	bool isEmpty();
	void push(int t);
	int pop();
	int top();
	~LinkedStackCpp();
};

