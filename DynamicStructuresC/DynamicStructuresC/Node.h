#pragma once
template <class T>
public class Node
{
public:
	Node(T newElement, Node<T> *nextNode);
	T getElement();
	Node<T>* getNext();
	void setNext(Node<T> *next);
	~Node();
private:
	T element;
	Node<T> *next;
}; typedef Node<T> *node<T>;

