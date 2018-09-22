#pragma once
template <class T>
public class NodeC
{
public:
	NodeC(T newElement, NodeC<T> *nextNode);
	T getElement();
	NodeC<T>* getNext();
	void setNext(NodeC<T> *next);
	~NodeC();
private:
	T element;
	NodeC<T> *next;
}; 
