#include "stdafx.h"
#include "LinkedStackCpp.h"


LinkedStackCpp::LinkedStackCpp()
{
	myList = new MyLinkedListCpp();
}

int LinkedStackCpp::size() {
	return myList->size();
}


bool LinkedStackCpp::isEmpty()
{
	return myList->isEmpty();
}

int LinkedStackCpp::pop()
{
	return myList->removeFirst();
}

void LinkedStackCpp::push(int t)
{
	myList->addFirst(t);
}

int LinkedStackCpp::top()
{
	return myList->first();
}

LinkedStackCpp::~LinkedStackCpp()
{
}
