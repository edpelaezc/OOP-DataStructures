#pragma once
class LinkedQueue
{
public:
	LinkedQueue();
	int size();
	bool isEmpty();
	void enqueue(int t);
	int dequeue();
	int front();	
	~LinkedQueue();
};

