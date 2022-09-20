#include <iostream>

using namespace std;

void showMenu()
{
	system("cls");
	std::cout << "Menu:\n";
	std::cout << "1. Pole kwadratu\n";
	std::cout << "2. Pole trojkata\n";
	std::cout << "3. Zadanie 1\n";
	std::cout << "4. Zadanie 2\n";
	std::cout << "5. Zadanie 3\n";
	std::cout << "6. Zadanie 4\n";
	std::cout << "7. Zadanie 5\n";
	std::cout << "0. Zamknij program\n";
}

int chooseOptionFromUser()
{
	std::cout << "Wybierz opcje\n";
	int selectedOption;
	std::cin >> selectedOption;
	return selectedOption;
}

void SquareArea()
{
	std::cout << "Podaj wartosc boku kwadratu:\n";
	int side;
	std::cin >> side;
	int area = side * side;
	std::cout << "Pole kwadratu to " << area << "\n";
}

void TriangleArea()
{
	std::cout << "Podaj wartosc podstawy trojkata:\n";
	int base;
	std::cin >> base;
	std::cout << "Podaj wartosc wysokosci trojkata:\n";
	int height;
	std::cin >> height;
	int area = base * height / 2;
	std::cout << "Pole trojkata to " << area << "\n";
}

void Zadanie1()
{
	std::cout << "Podaj liczbe:\n";
	int number;

	std::cin >> number;

	if (number % 2 == 0)
		number--;

	while (number > 0)
	{
		std::cout << number << ", ";
		number = number - 2;
	}
	std::cout << '\n';
}

void Zadanie2()
{
	std::cout << "Podaj liczbe liczb ci¹gu Fibonacciego:\n";
	int number;
	std::cin >> number;

	int currentFibonacciNumber = 0;
	int prevOneFibonacciNumber = 0;
	int prevTwoFibonacciNumber = 1;

	for (int i = 0; i < number; i++)
	{
		currentFibonacciNumber = prevOneFibonacciNumber + prevTwoFibonacciNumber;
		std::cout << currentFibonacciNumber << ", ";

		prevTwoFibonacciNumber = prevOneFibonacciNumber;
		prevOneFibonacciNumber = currentFibonacciNumber;
	}
	std::cout << '\n';
}

void Zadanie3()
{
	std::cout << "Podaj liczbe:\n";
	int number;
	std::cin >> number;

	for (int i = 1; i <= number; i++)
	{
		if (number % i == 0)
			std::cout << i << ", ";
	}
	std::cout << '\n';

	//wersja 2
	for (int i = 1; i <= sqrt(number); i++)
	{
		if (number % i == 0)
		{
			std::cout << i << ", ";
			int divider = number / i;
			if (divider != i)
				std::cout << divider << ", ";
		}
	}
	std::cout << '\n';

	//wersja 3
	int changeNumber;
	if (number % 2 == 0)
		changeNumber = 1;
	else
		changeNumber = 2;
	for (int i = 1; i <= sqrt(number); i = i + changeNumber)
	{
		if (number % i == 0)
		{
			std::cout << i << ", ";
			int divider = number / i;
			if (divider != i)
				std::cout << divider << ", ";
		}
	}
	std::cout << '\n';
}

void Zadanie4()
{
	std::cout << "Podaj liczbe:\n";
	int numberFromUser;
	std::cin >> numberFromUser;

	std::string arrayOfWordsNumbers[10] = { "zero", "jeden", "dwa", "trzy",
											"cztery", "piec", "szesc",
											"sieden", "osiem", "dziewiec" };
	//arrayOfWordsNumbers[0] = "zero";
	//arrayOfWordsNumbers[1] = "jeden";

	int number = numberFromUser;
	do
	{
		int digit = number % 10;
		number = number / 10;

		std::cout << arrayOfWordsNumbers[digit] << " ";

	} while (number != 0);
	std::cout << "\n";

	number = numberFromUser;
	std::string stringNumber = "";

	do
	{
		int digit = number % 10;
		number = number / 10;

		stringNumber = arrayOfWordsNumbers[digit] + " " + stringNumber;

	} while (number != 0);

	std::cout << stringNumber;
	std::cout << "\n";
}
void dec_to_bin(int liczba)
{
	int i=0, tab[31];

	while(liczba)
	{
	
		tab[i++] = liczba % 2;
		liczba /= 2;
	}
	
	for (int j = i - 1; j >= 0; j--)
		cout << tab[j];
}
void show_converter_menu()
{
	cout << "Menu:";
	cout << "1. dec na bin";
	cout << "2. dec na szesnastkowy";
}
int choosenOption()
{

}

void menu_convertion(int choosenOption)
{
	switch (choosenOption)
	{
		case 1:
			dec_to_bin;
			break;
	}

}

void doSelectedTask(int& selectedOption)
{
	switch (selectedOption)
	{
	case 1:
		SquareArea();
		break;
	case 2:
		TriangleArea();
		break;
	case 3:
		Zadanie1();
		break;
	case 4:
		Zadanie2();
		break;
	case 5:
		Zadanie3();
		break;
	case 6:
		Zadanie4();
		break;
	case 7:
		break;
	 case 0:
		 return;
	default:
		std::cout << "Brak opcji w menu\n";
		break;
	}

	system("pause");

}

void mainProgram()
{
	int selected;
	do
	{
		//1. wyœwietlenie menu
		showMenu();

		//2. wybranie opcji przez u¿ytkownika
		selected = chooseOptionFromUser();

		//3. Wykonanie wybranego zadania
		doSelectedTask(selected);

	} while (selected != 0);
}

void main_dec_converter()
{
	int selected;
	do
	{
		show_converter_menu;
	
	}
}


int main()
{
	//mainProgram();
	int liczba;
	cout << "podaj liczbe: ";
	cin >> liczba;
	cout << "Liczba po zmianie na liczbe binarna:"; dec_to_bin(liczba); cout << endl;
	return 0;
}