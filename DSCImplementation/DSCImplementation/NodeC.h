#pragma once
public class NodeC
{
public:
	NodeC(int newElement, NodeC *nextNode);
	int getElement();
	NodeC getNext();
	void setNext(NodeC *next);
	~NodeC();
private:
	int element;
	NodeC *next;
}; typedef NodeC *node;
