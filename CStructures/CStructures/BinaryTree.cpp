#include "pch.h"
#include "BinaryTree.h"
#include <iostream>

using namespace std;
BinaryTree::BinaryTree()
{	
	root = NULL;
	numberOfNodes = 0;
}

int BinaryTree::weight() { return numberOfNodes; }

void BinaryTree::add(int element) {
	if (this->root == NULL)	{
		root = new TreeNode(element, NULL, NULL, NULL);
		numberOfNodes++;
	}
	else {
		addElement(root, element);
	}
}

void BinaryTree::addElement(TreeNode *root, int element) {
	//si el elemento es menor que el valor de root lo agrega a la izq. recursivamente
	if (element < root->getElement()) {
		if (root->getLeft() == NULL) {
			root->setLeft(new TreeNode(element, root, NULL, NULL));
			numberOfNodes++;
		}
		else {
			addElement(root->getLeft(), element);
		}
	}
	else if (element > root->getElement()) {// si es mayor lo agrega al subarbol derecho. 
		if (root->getRight() == NULL) {			
			root->setRight(new TreeNode(element, root, NULL, NULL));
			numberOfNodes++;
		}
		else {
			addElement(root->getRight(), element);
		}
	}
	else { //los elementos son iguales
		cout << "NO SE PERMITEN ELEMENTOS DUPLICADOS.";
	}
}

bool BinaryTree::elementExists(TreeNode *root, int element) {
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

void BinaryTree::preOrder(TreeNode *root) {
	if (root != NULL)
	{
		cout << root->getElement() << " ";
		preOrder(root->getLeft());
		preOrder(root->getRight());
	}
}

void BinaryTree::postOrder(TreeNode *root) {
	if (root != NULL)
	{
		postOrder(root->getLeft());
		postOrder(root->getRight());
		cout << root->getElement()<< " ";
	}
}

void BinaryTree::inOrder(TreeNode *root) {
	if (root != NULL)
	{
		inOrder(root->getLeft());
		cout << root->getElement() << " ";
		inOrder(root->getRight());
	}
}

int BinaryTree::numberOfChildren(TreeNode *root) {
	int count = 0;
	if (root->getLeft() != NULL)
		count++;
	if (root->getRight() != NULL)
		count++;
	return count;
}

int BinaryTree::remove(TreeNode *root, int element) {
	if (this->root == NULL) {
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
				return aux;
			}
			else
			{
				int aux = root->getElement();
				root->getParent()->setRight(NULL);
				root = NULL;				
				return aux;
			}
			numberOfNodes--;
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
			numberOfNodes--;
			return aux;
		}
		else {// el nodo que sustituirá será el más derecho del subárbol izquierdo.
			TreeNode *next = root->getLeft();
			int aux = root->getElement();			
			if (next->getRight() != NULL) {
				while (next->getRight() != NULL)
				{
					next = next->getRight();
				}
				root->setElement(next->getElement());
				TreeNode *father = next->getParent();
				father->setRight(NULL);				
			}
			else {

			}
			root->setElement(next->getElement());
			root->setLeft(NULL);
			numberOfNodes--;
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

void BinaryTree::removeLeaf(TreeNode *root) {
	if (root != NULL) {			
		removeLeaf(root->getLeft());
		removeLeaf(root->getRight());

		if (numberOfChildren(root) == 0 && root->getElement() % 2 != 0) {
			remove(this->root, root->getElement());
		}
	}
}

int BinaryTree::treeDepth(TreeNode *root) {
	if (!root) {
		return 0;
	}
	else {
		int leftDepth = treeDepth(root->getLeft());
		int rightDepth = treeDepth(root->getRight());
		if (leftDepth > rightDepth) {
			return leftDepth + 1;
		}
		else {
			return rightDepth + 1;
		}
	}
}

BinaryTree::~BinaryTree()
{
}
