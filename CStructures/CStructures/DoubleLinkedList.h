#pragma once
#include <string.h>
#include <string>
#include <stdio.h>
#include <iostream>

class NodeD {
private:
	char element;
	NodeD *prev;
	NodeD *next;

public:
	NodeD(char e, NodeD *previousNode, NodeD *nextNode) {	
		element = e;
		prev = previousNode;
		next = nextNode;
	}

	char getElement() {
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
	void addBetween(char n, nodeD predecessor, nodeD successor);
	char remove(NodeD *node);
public:	
	DoubleLinkedList();
	int size();
	bool isEmpty();
	char first();
	char last();
	void addFirst(char n);
	void addLast(char n);
	char removeFirst();
	char removeLast();
	bool search(char reference);
	void showElements();
	~DoubleLinkedList();
};

