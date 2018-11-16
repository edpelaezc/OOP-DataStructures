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
class CircularLinkedList
{
public:
	CircularLinkedList();
	Node<T> *tail;
	int listSize;
	int size();
	bool isEmpty();
	T first();
	T last();
	void rotate();
	void addFirst(T n);
	void addLast(T n);
	T removeFirst();
	bool search(T reference);
	void showElements();
	~CircularLinkedList();
};

