#pragma once

class Node {
private:
	int element;
	Node *prev;
	Node *next;

public:
	Node(int e, Node *previousNode, Node *nextNode) {
		element = e;
		prev = previousNode;
		next = nextNode;
	}

	int getElement() {
		return element;
	}

	Node *getPrev() {
		return prev;
	}

	void setPrev(Node *previous) {
		prev = previous;
	}

	Node *getNext() {
		return next;
	}

	void setNext(Node *nextNode) {
		next = nextNode;
	}
}; typedef Node *node;


class DoubleLinkedList
{
private:
	node header;
	node trailer;
	int listSize;
	void addBetween(int n, node predecessor, node successor);
	int remove(Node *node);
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

