#include "pch.h"
#include "BinaryTree.h"
#include <iostream>

using namespace std;
BinaryTree::BinaryTree()
{
	root = NULL;
}

int BinaryTree::size() { return treeSize; }

void BinaryTree::add(int element) {
	if (root->getElement() == NULL)	{
		root = new TreeNode(element, NULL, NULL, NULL);
		treeSize++;
	}
	else {
		addElement(this->root, element);
	}
}

void BinaryTree::addElement(Node root, int element) {
	//si el elemento es menor que el valor de root lo agrega a la izq. recursivamente
	if (element < root->getElement()) {
		if (root->getLeft() != NULL) {
			root->setLeft(new TreeNode(element, root, NULL, NULL));
			treeSize++;
		}
		else {
			addElement(root->getLeft(), element);
		}
	}
	else if (element > root->getElement()) {// si es mayor lo agrega al subarbol derecho. 
		if (root->getRight() != NULL) {
			root->setRight(new TreeNode(element, root, NULL, NULL));
			treeSize++;
		}
		else {
			addElement(root->getRight(), element);
		}
	}
	else { //los elementos son iguales
		cout << "NO SE PERMITEN ELEMENTOS DUPLICADOS.";
	}
}

bool BinaryTree::elementExists(Node root, int element) {
	if (this->root == NULL) {
		return false;
	}
	else if (element == root->getElement()) {
		return true;
	}
	else
	{
		if (element < root->getElement())
		{
			return elementExists(root->getLeft(), element);
		}
		else
		{
			return elementExists(root->getRight(), element);
		}
	}
}

void BinaryTree::preOrder(Node root) {
	if (this->root != NULL)
	{
		cout << root->getElement();
		preOrder(root->getLeft());
		preOrder(root->getRight());
	}
}

void BinaryTree::postOrder(Node root) {
	if (this->root != NULL)
	{
		postOrder(root->getLeft());
		postOrder(root->getRight());
		cout << root->getElement();
	}
}

void BinaryTree::inOrder(Node root) {
	if (this->root != NULL)
	{
		inOrder(root->getLeft());
		cout << root->getElement();
		inOrder(root->getRight());
	}
}

int BinaryTree::numberOfChildren(Node root) {
	int count = 0;
	if (root->getLeft() != NULL)
		count++;
	if (root->getRight() != NULL)
		count++;
	return count;
}

int BinaryTree::remove(Node root, int element) {
	if (this->root != NULL) {
		return NULL;
	}
	else if (element == root->getElement()) {
		if (numberOfChildren(root) == 0)
		{
			if (element == root->getParent()->getLeft()->getElement())
			{
				int aux = root->getElement();
				root->getParent()->setLeft(NULL);
				root = NULL;
				treeSize--;
				return aux;
			}
			else
			{
				int aux = root->getElement();
				root->getParent()->setRight(NULL);
				root = NULL;
				treeSize--;
				return aux;
			}
		}
		else if (numberOfChildren(root) == 1) {
			int aux = root->getElement();
			if (root->getParent()->getLeft() != NULL)
			{
				if (root->getLeft() != NULL)
				{
					root->getParent()->setLeft(root->getLeft());
				}
				else
				{
					root->getParent()->setLeft(root->getRight());
				}
			}
			else
			{
				if (root->getLeft() != NULL)
				{
					root->getParent()->setRight(root->getLeft());
				}
				else
				{
					root->getParent()->setRight(root->getRight());               
				}
			}
			treeSize--;
			return aux;
		}
		else {// el nodo que sustituirá será el más derecho del subárbol izquierdo.
			Node next = root->getLeft();
			int aux = root->getElement();			
			while (next->getRight() != NULL)
			{
				next = next->getRight();
			}
			root->setElement(next->getElement());
			Node father = next->getParent();
			father->setRight(NULL);
			return aux;
		}
	}
	else {
		if (element < root->getElement()) {
			return remove(root->getLeft(), element);
		}
		else {
			return remove(root->getRight(), element);
		}

	}
}

BinaryTree::~BinaryTree()
{
}
