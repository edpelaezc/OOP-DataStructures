#pragma once

template<class T>
class TreeNode {
private: 
	T element;
	TreeNode<T> *parent;
	TreeNode<T> *left;
	TreeNode<T> *right;
	int key;
public: 
	TreeNode(T t, TreeNode<T> *above, TreeNode<T> *leftChild, TreeNode<T> *rightChild, int nKey) {
		element = t;
		parent = above;
		left = leftChild;
		right = rightChild;
		key = nKey;
	}

	int getKey() {
		return key;
	}

	T getElement() {
		return element;
	}

	TreeNode<T> *getParent()
	{
		return parent;
	}

	TreeNode<T> *getLeft()
	{
		return left;
	}

	TreeNode<T> *getRight()
	{
		return right;
	}

	void setElement(T t)
	{
		element = t;
	}

	void setParent(TreeNode<T> *parentNode)
	{
		parent = parentNode;
	}

	void setLeft(TreeNode<T> *leftChild)
	{
		left = leftChild;
	}

	void setRight(TreeNode<T> *rightChild)
	{
		right = rightChild;
	}
};

template<class T>
class BinaryTree
{
public:
	TreeNode<T> *root;
	BinaryTree();
	int weight();
	void add(T element, int key);
	bool elementExists(TreeNode<T> *root, int elementKey);
	int numberOfChildren(TreeNode<T> *root);
	void preOrder(TreeNode<T> *root);
	void postOrder(TreeNode<T> *root);
	void inOrder(TreeNode<T> *root);
	T remove(TreeNode<T> *root, int elementKey);
	int treeDepth(TreeNode<T> *root);
	~BinaryTree();
private:
	int numberOfNodes;
	void addElement(TreeNode<T> *root, T element, int key);
};

