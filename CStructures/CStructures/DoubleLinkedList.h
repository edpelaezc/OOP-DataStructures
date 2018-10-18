#pragma once
#include <string.h>
#include <string>
#include <stdio.h>
#include <iostream>


class NodeD {
private:
	int element;
	NodeD *prev;
	NodeD *next;

public:
	NodeD(int e, NodeD *previousNode, NodeD *nextNode) {		
		prev = previousNode;
		next = nextNode;
	}

	int getElement() {
		return element;
	}

	NodeD *getPrev() {
		return prev;
	}

	void setPrev(NodeD *previous) {
		prev = previous;
	}

	NodeD *getNext() {
		return next;
	}

	void setNext(NodeD *nextNode) {
		next = nextNode;
	}
}; typedef NodeD *nodeD;


class DoubleLinkedList
{
private:
	nodeD header;
	nodeD trailer;
	int listSize;
	void addBetween(int n, nodeD predecessor, nodeD successor);
	int remove(NodeD *node);
public:	
	DoubleLinkedList();
	int size();
	bool isEmpty();
	int first();
	int last();
	void addFirst(int n);
	void addLast(int n);
	int removeFirst();
	int removeLast();
	bool search(int reference);
	void showElements();
	~DoubleLinkedList();
};

