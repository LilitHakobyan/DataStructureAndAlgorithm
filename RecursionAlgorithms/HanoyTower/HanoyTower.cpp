// HanoyTower.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"


int main()
{
	Stack st;
	for (int i = 0; i < 5; i++)
	{
		st.Pop(i + 3);

	}
	cout << "count=" << st.GetCount() << endl;

	Node* pT = st.pFirst;
	while (pT)
	{
		cout << pT->value << ',';
		pT = pT->pNext;
	}
	cout << endl;
    return 0;
}

