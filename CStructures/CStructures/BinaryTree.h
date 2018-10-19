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
}; typedef TreeNode *Node;

class BinaryTree
{
public:
	Node root;
	BinaryTree();		
	int size();
	void add(int element);	
	bool elementExists(Node root, int element);
	int numberOfChildren(Node root);
	void preOrder(Node root);
	void postOrder(Node root);
	void inOrder(Node root);
	int remove(Node root, int element);
	~BinaryTree();
private:
	int treeSize;
	void addElement(Node root, int element);
};

