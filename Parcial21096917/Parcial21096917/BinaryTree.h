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
};

class BinaryTree
{
public:
	TreeNode *root;
	BinaryTree();
	int weight();
	void add(int element);
	bool elementExists(TreeNode *root, int element);
	int numberOfChildren(TreeNode *root);
	void preOrder(TreeNode *root);
	void postOrder(TreeNode *root);
	void inOrder(TreeNode *root);
	int remove(TreeNode *root, int element);
	void removeLeaf(TreeNode * root);
	void showParents(TreeNode *root);
	int treeDepth(TreeNode *root);
	~BinaryTree();
private:
	int numberOfNodes;
	void addElement(TreeNode *root, int element);
};

