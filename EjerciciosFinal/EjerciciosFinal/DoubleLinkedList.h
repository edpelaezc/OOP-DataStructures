#pragma once
#include <iostream>

using namespace std;
template<class T>
class NodeD {
private:
	T element;	
	NodeD<T> *prev;
	NodeD<T> *next;

public:
	NodeD(T t, NodeD<T> *previousNode, NodeD<T> *nextNode) {
		element = t;
		prev = previousNode;
		next = nextNode;
	}

	T getElement() {
		return element;
	}

	void setElement(T t) {
		element = t;
	}

	NodeD<T> *getPrev() {
		return prev;
	}

	void setPrev(NodeD<T> *previous) {
		prev = previous;
	}

	NodeD<T> *getNext() {
		return next;
	}

	void setNext(NodeD<T> *nextNode) {
		next = nextNode;
	}
};

template<class T>
class DoubleLinkedList
{
private:
	int listSize;
	void addBetween(T n, NodeD<T> *predecessor, NodeD<T> *successor);
	T remove(NodeD<T> *node);
public:
	NodeD<T> *header;
	NodeD<T> *trailer;
	DoubleLinkedList(T n);
	int size();
	bool isEmpty();
	T first();
	T last();
	void addFirst(T n);
	void addLast(T n);
	T removeFirst();
	T removeLast();
	bool search(T reference);
	void purge(static DoubleLinkedList<T> *list);	
	void showElements();
	~DoubleLinkedList();
};


