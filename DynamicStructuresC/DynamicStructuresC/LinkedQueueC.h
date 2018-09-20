#pragma once
#include "MyLinkedListC.h"
class LinkedQueueC
{
public:
	LinkedQueueC();
	MyLinkedListC *myList;	
	int size();
	bool isEmpty();
	void enqueue(int t);
	int dequeue();
	int front();
	~LinkedQueueC();
};

