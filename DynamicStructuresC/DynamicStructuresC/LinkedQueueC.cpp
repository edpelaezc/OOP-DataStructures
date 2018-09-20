#include "stdafx.h"
#include "LinkedQueueC.h"


LinkedQueueC::LinkedQueueC()
{
	myList = new MyLinkedListC();
}

int LinkedQueueC::size() { return myList->size(); }

bool LinkedQueueC::isEmpty() { return myList->isEmpty(); }

void LinkedQueueC::enqueue(int t) {
	myList->addLast(t);
}

int LinkedQueueC::dequeue() {
	return myList->removeFirst();
}

int LinkedQueueC::front(){
	return myList->first();
}

LinkedQueueC::~LinkedQueueC()
{
}
