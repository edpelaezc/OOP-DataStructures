#include "stdafx.h"
#include "LinkedStackC.h"


LinkedStackC::LinkedStackC()
{
	myList = new MyLinkedListC();
}

int LinkedStackC::size() {
	return myList->size();
}


bool LinkedStackC::isEmpty()
{
	return myList->isEmpty();
}

int LinkedStackC::pop()
{
	return myList->removeFirst();
}

void LinkedStackC::push(int t)
{
	myList->addFirst(t);
}

int LinkedStackC::top()
{
	return myList->first();
}

LinkedStackC::~LinkedStackC()
{
}
