#pragma once
#include <iostream>

template<class T>
class Node {
private:
	T element;
	Node<T> *next;
public:
	T getElement() {
		return element;
	}

	Node<T>* getNext() {
		return next;
	}
	void setNext(Node<T> *next) {
		this->next = next;
	}

	Node(T d, Node<T> *nextNode) {
		element = d;
		next = nextNode;
	}
};

template<class T>
class MyLinkedList
{
public:
	MyLinkedList();
	void *compare;
	Node<T> *head;
	Node<T> *tail;
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

