#include "pch.h"
#include "BinaryTree.h"
#include <iostream>

using namespace std;
template<typename T>
BinaryTree<T>::BinaryTree()
{
	root = NULL;
	numberOfNodes = 0;
}

template<typename T>
int BinaryTree<T>::weight() { return numberOfNodes; }

template<typename T>
void BinaryTree<T>::add(T element, int key) {
	if (this->root == NULL) {
		root = new TreeNode<T>(element, NULL, NULL, NULL, key);
		numberOfNodes++;
	}
	else {
		addElement(root, element, key);
	}
}

template<typename T>
void BinaryTree<T>::addElement(TreeNode<T> *root, T element, int key) {
	//si el elemento es menor que el valor de root lo agrega a la izq. recursivamente
	if (key < root->getKey()) {
		if (root->getLeft() == NULL) {
			root->setLeft(new TreeNode<T>(element, root, NULL, NULL, key));
			numberOfNodes++;
		}
		else {
			addElement(root->getLeft(), element, key);
		}
	}
	else if (key > root->getKey()) {// si es mayor lo agrega al subarbol derecho. 
		if (root->getRight() == NULL) {
			root->setRight(new TreeNode<T>(element, root, NULL, NULL, key));
			numberOfNodes++;
		}
		else {
			addElement(root->getRight(), element, key);
		}
	}
	else { //los elementos son iguales
		//no hace nada.
	}
}

template<typename T>
bool BinaryTree<T>::elementExists(TreeNode<T> *root, int elementKey) {
	if (root == NULL) {
		return false;
	}
	else if (elementKey == root->getKey()) {
		return true;
	}
	else
	{
		if (elementKey < root->getKey())
		{
			return elementExists(root->getLeft(), elementKey);
		}
		else
		{
			return elementExists(root->getRight(), elementKey);
		}
	}
}

template<typename T>
T BinaryTree<T>::showElement(TreeNode<T> *root, int elementKey) {
	if (this->root != NULL) {
		if (elementKey == root->getKey()) {
			T aux = root->getElement();
			return aux;
		}
		else
		{
			if (elementKey < root->getKey())
			{
				return showElement(root->getLeft(), elementKey);
			}
			else
			{
				return showElement(root->getRight(), elementKey);
			}
		}
	}	
}

template<typename T>
int BinaryTree<T>::numberOfChildren(TreeNode<T> *root) {
	int count = 0;
	if (root->getLeft() != NULL)
		count++;
	if (root->getRight() != NULL)
		count++;
	return count;
}

template<typename T>
void BinaryTree<T>::preOrder(TreeNode<T> * root) {
	if (root != NULL)
	{
		cout << root->getKey() << "\t";
		preOrder(root->getLeft());
		preOrder(root->getRight());
	}
}

template<typename T>
void BinaryTree<T>::postOrder(TreeNode<T> *root) {
	if (root != NULL)
	{
		postOrder(root->getLeft());
		postOrder(root->getRight());
		cout << root->getElement() << "\t";
	}
}

template<typename T>
void BinaryTree<T>::inOrder(TreeNode<T> *root) {
	if (root != NULL)
	{
		inOrder(root->getLeft());
		cout << root->getElement() << "\t";
		inOrder(root->getRight());
	}
}

template<typename T>
T BinaryTree<T>::remove(TreeNode<T> *root, int elementKey) {
	if (this->root == NULL) {		
	}
	else if (elementKey == root->getKey()) {
		if (numberOfChildren(root) == 0) {
			T aux = root->getElement();
			if (root == this->root) {
				this->root = NULL;
			}
			else {
				if (elementKey == root->getParent()->getLeft()->getKey()) {
					root->getParent()->setLeft(NULL);
					root = NULL;
				}
				else {
					root->getParent()->setRight(NULL);
					root = NULL;
				}
			}
			numberOfNodes--;
			return aux;
		}
		else if (numberOfChildren(root) == 1) {
			T aux = root->getElement();

			if (root == this->root) {
				if (root->getLeft() != NULL) {
					this->root = root->getLeft();
				}
				else {
					this->root = root->getRight();
				}
			}
			else {
				if (root->getParent()->getLeft() != NULL) {
					if (root->getLeft() != NULL) {
						root->getParent()->setLeft(root->getLeft());
					}
					else {
						root->getParent()->setLeft(root->getRight());
					}
				}
				else {
					if (root->getLeft() != NULL) {
						root->getParent()->setRight(root->getLeft());
					}
					else {
						root->getParent()->setRight(root->getRight());
					}
				}
			}
			numberOfNodes--;
			return aux;
		}
		else {// el nodo que sustituir� ser� el m�s derecho del sub�rbol izquierdo.
			TreeNode<T> *next = root->getLeft();
			T aux = root->getElement();
			if (next->getRight() != NULL) {
				while (next->getRight() != NULL)
				{
					next = next->getRight();
				}
				root->setElement(next->getElement());
				TreeNode<T> *father = next->getParent();
				father->setRight(NULL);
			}
			else {
				root->setElement(next->getElement());
				root->setLeft(NULL);
			}
			numberOfNodes--;
			return aux;
		}
	}
	else {
		if (elementKey < root->getKey()) {
			return remove(root->getLeft(), elementKey);
		}
		else {
			return remove(root->getRight(), elementKey);
		}

	}
}

template<typename T>
int BinaryTree<T>::treeDepth(TreeNode<T> *root) {
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

template<typename T>
BinaryTree<T>::~BinaryTree()
{
}
