#pragma once
class TreeNode {
private:
	int element;
	TreeNode *parent;
	TreeNode *left;
	TreeNode *right;

public:
	TreeNode(int t, TreeNode *above, TreeNode *leftChild, TreeNode *rightChild) {
		element = t;
		parent = above;
		left = leftChild;
		right = rightChild;
	}

	int getElement() {
		return element;
	}

	TreeNode *getParent()
	{
		return parent;
	}

	TreeNode *getLeft()
	{
		return left;
	}

	TreeNode *getRight()
	{
		return right;
	}

	void setElement(int t)
	{
		element = t;
	}

	void setParent(TreeNode *parentNode)
	{
		parent = parentNode;
	}

	void setLeft(TreeNode *leftChild)
	{
		left = leftChild;
	}

	void setRight(TreeNode *rightChild)
	{
		right = rightChild;
	}
}; typedef TreeNode *node;

class BinaryTree
{
public:
	node root;
	BinaryTree();		
	int size();
	void add(int element);
	void addElement(node root, int element);	
	bool elementExists(node root, int element);
	void preOrder(node root);
	void postOrder(node root);
	void inOrder(node root);
	~BinaryTree();
private:
	int treeSize;
};

