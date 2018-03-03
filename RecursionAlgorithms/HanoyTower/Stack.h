#pragma once
struct Node
{
	int value;
	Node* pNext;
	Node(int a) {
		value = a;
		pNext = NULL;
	}
};
class Stack
{
public:
	Stack();
	~Stack();
	int GetCount(){ return count;}

public:
	Node * pFirst=NULL;
	int count=0;
public:
	void Pop(int a);
	int Push();
	//int operator[](int i);
};

