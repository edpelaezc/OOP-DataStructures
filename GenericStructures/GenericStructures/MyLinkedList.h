#pragma once
template<class DataN>
class Node {
private:
	DataN element;
	Node<DataN> *next;
public:
	DataN getElement() {
		return element;
	}

	Node<DataN>* getNext() {
		return next;
	}
	void setNext(Node<DataN> *next) {
		this->next = next;
	}

	Node(DataN d, Node<DataN> *nextNode) {
		element = d;
		next = nextNode;
	}
};

template<class Data>
class MyLinkedList
{
public:
	MyLinkedList();
	Node<Data> *head;
	Node<Data> *tail;
	int size();
	bool isEmpty();
	Data first();
	Data last();
	void addFirst(Data t);
	void addLast(Data t);
	Data removeFirst();
	bool searchElement(Data reference);
	void showElements();
	~MyLinkedList();
private:
	int listSize;
};

