#pragma once
public class Node
{
public:
	Node(int newElement, Node *nextNode);
	int getElement();
	Node getNext();
	void setNext(Node *next);
	~Node();
private:
	int element;
	Node *next;
}; typedef Node *node;

