#include <iostream>

using namespace std;

int globalVariable = 7;

void AnotherFunction(int parameter)
{
	int anotherLocalVariableInFunction = 6;
}

void TestFunction()
{
	int localVaroableInFunction = 5;
	AnotherFunction(localVaroableInFunction);
}

int main()
{
	/*int localVariableInMain = 8;
	TestFunction();*/
	
	int number; 

	int* wsk;
	wsk = new int;
	*wsk = 7;

	cout << wsk << "\n";
	cout << *wsk << "\n";

	number = *wsk * 2;
}