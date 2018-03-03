#include "stdafx.h"
#include "Stack.h"


Stack::Stack()
{
}


Stack::~Stack()
{
}


void Stack::Pop(int a)
{
	Node* pTemp = new Node(a);
	count++;
	if (pFirst == NULL)
	{
		pFirst = pTemp;
	}
	else
	{
		Node* pT = pFirst;
		while (pT->pNext)
		{
			pT = pT->pNext;
		}
		pT->pNext = pTemp;
	}
}


int Stack::Push()
{
}
