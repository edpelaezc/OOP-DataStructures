#pragma once
#include <iostream>

template<class T>
class NodeM {
private:
	T element;
	NodeM<T> *next;
public:
	T getElement() {
		return element;
	}

	NodeM<T>* getNext() {
		return next;
	}
	void setNext(NodeM<T> *next) {
		this->next = next;
	}

	NodeM(T d, NodeM<T> *nextNodeM) {
		element = d;
		next = nextNodeM;
	}
};

template<class T>
class MyLinkedList
{
public:
	MyLinkedList();
	void *compare;
	NodeM<T> *head;
	NodeM<T> *tail;
	int size();
	bool isEmpty();
	T first();
	T last();
	void addFirst(T d);
	void addLast(T d);
	T removeFirst();
	bool searchElement(T reference);
	void showElements();	
	~MyLinkedList();
private:
	int listSize;
};

