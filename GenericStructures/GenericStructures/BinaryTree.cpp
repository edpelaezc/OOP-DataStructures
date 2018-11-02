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
void BinaryTree<T>::add(T element) {
	if (this->root == NULL) {
		root = new TreeNode<T>(element, NULL, NULL, NULL);
		numberOfNodes++;
	}
	else {
		addElement(root, element);
	}
}

template<typename T>
void BinaryTree<T>::addElement(TreeNode<T> *root, T element) {
	//si el elemento es menor que el valor de root lo agrega a la izq. recursivamente
	if (element < root->getElement()) {
		if (root->getLeft() == NULL) {
			root->setLeft(new TreeNode<T>(element, root, NULL, NULL));
			numberOfNodes++;
		}
		else {
			addElement(root->getLeft(), element);
		}
	}
	else if (element > root->getElement()) {// si es mayor lo agrega al subarbol derecho. 
		if (root->getRight() == NULL) {
			root->setRight(new TreeNode<T>(element, root, NULL, NULL));
			numberOfNodes++;
		}
		else {
			addElement(root->getRight(), element);
		}
	}
	else { //los elementos son iguales
		//no hace nada.
	}
}

template<typename T>
bool BinaryTree<T>::elementExists(TreeNode<T> *root, T element) {}

template<typename T>
int BinaryTree<T>::numberOfChildren(TreeNode<T> *root) {}

template<typename T>
void BinaryTree<T>::preOrder(TreeNode<T> * root) {}

template<typename T>
void BinaryTree<T>::postOrder(TreeNode<T> *root) {}

template<typename T>
void BinaryTree<T>::inOrder(TreeNode<T> *root) {}

template<typename T>
T BinaryTree<T>::remove(TreeNode<T> *root, T element) {}

template<typename T>
int BinaryTree<T>::treeDepth(TreeNode<T> *root) {}

template<typename T>
BinaryTree<T>::~BinaryTree()
{
}
