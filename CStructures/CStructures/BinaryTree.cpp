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

void BinaryTree::addElement(node root, int element) {
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

bool BinaryTree::elementExists(node root, int element) {
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

void BinaryTree::preOrder(node root) {
	if (this->root != NULL)
	{
		cout << root->getElement();
		preOrder(root->getLeft());
		preOrder(root->getRight());
	}
}

void BinaryTree::postOrder(node root) {
	if (this->root != NULL)
	{
		postOrder(root->getLeft());
		postOrder(root->getRight());
		cout << root->getElement();
	}
}

void BinaryTree::inOrder(node root) {
	if (this->root != NULL)
	{
		inOrder(root->getLeft());
		cout << root->getElement();
		inOrder(root->getRight());
	}
}

BinaryTree::~BinaryTree()
{
}
