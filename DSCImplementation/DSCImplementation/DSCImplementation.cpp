#include "stdafx.h"
#include "MyLinkedListCpp.h"
#include <iostream>

using namespace System;

int main(array<System::String ^> ^args)
{		
	MyLinkedListCpp *myList = new MyLinkedListCpp();
	Console::WriteLine("MOSTRANDO ELEMENTOS DE LA LISTA ENLAZDA");	
	for(int i = 0; i < 10; i++)
	{
		myList->addLast(i + 1);
	}

		myList->showElements();	

		/*Console::WriteLine("\n\n" + myList->searchElement(3));
		Console::WriteLine(myList->searchElement(15));
		Console::WriteLine(myList->searchElement(20));
		Console::WriteLine(myList->searchElement(200));
		Console::WriteLine(myList->searchElement(500));*/
		//Console::WriteLine(myList->remove(11));
		//myList->remove(1);
		MyLinkedListCpp *list = myList->invert();
		Console::WriteLine("\nLISTA INVERTIDA");
		list->showElements();		
	return 0;
}
