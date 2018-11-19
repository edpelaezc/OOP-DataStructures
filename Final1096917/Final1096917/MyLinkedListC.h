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
	Electrodomestico first();
	Electrodomestico last();
	void addFirst(int eTipo, Television tele);
	void addLast(int eTipo, Television tele);
	void addLast(int eTipo, Lavadora lava);
	void addFirst(int eTipo, Lavadora lava);
	Electrodomestico removeFirst();	
	void showElements();
	~MyLinkedListC();
private:
	int listSize;
};

