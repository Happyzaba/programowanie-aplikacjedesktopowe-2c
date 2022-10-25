#include <iostream>
#include <ctime>

using namespace std;
/*
Zadanie
Napisz klasê (oraz kod testujacy) opisuj¹cy osobe.
* Dodac 5 pol opisujacych osobe(ma byc rok urodzenia)
* dodanie konstruktorow umozliwiajacycj utworzenia obiuektow na pare sposobow 
* metoda ktora wyswietli informacje o osobie
* metoda ktora wyswietli czy osoba jest pelnoletnia czy nie
*/
struct Date {
	int year, month, day;

};

class Person
{
private:
	string name, surname;
	Date dateBirth;
	int height;
	//male
	//female
	bool gender;

public:
	Person() {};

	Person(string name, string surname, Date dateBirth, int height) {

		this->name = name;
		this->surname = surname;
		this->dateBirth = dateBirth;
		this->height = height;
	}

	Person(string name, string surname) {
		time_t now = time(0);
		tm* ltm = new tm;
		localtime_s(ltm, &now);

		this->name = name;
		this->surname = surname;
		this->dateBirth.year = 1900 + ltm->tm_year;
		this->dateBirth.month = 1 + ltm->tm_mon;
		this->dateBirth.day = ltm->tm_mday;
	}

	void CheckDate() {
		time_t now = time(0);
		tm* ltm = new tm;
		localtime_s(ltm, &now);
		if (1900 + ltm->tm_year - dateBirth.year >= 18)
			cout << "Yes\n";
		else
			cout << "No\n";
	}
	void CheckGender() {
		if (name.back() == 'a' || name.back() == 'e' || name.back() == 'y')
		{
			gender = false;
			cout << "Female\n";
		}

		else 
		{
			gender = true;
			cout << "Male\n";
		}
	}
	void ShowMajority() {
		cout << "Majority:"; 
		time_t now = time(0);
		tm* ltm = new tm;
		localtime_s(ltm, &now);
		if (1900 + ltm->tm_year - dateBirth.year >= 18)
			cout << "Yes\n";
		else
			cout << "No\n";

	}

	void ShowPersonInfo() {
		cout << "***********************************\n";
		cout << "Name:"<<name<<"\n";
		cout << "Surname:"<<surname<<"\n";
		cout << "***********************************\n";
		cout << "Brithday:" << dateBirth.year <<"/" << dateBirth.month << "/" << dateBirth.day << "\n";
		cout << "Majority:";
		CheckDate();
		cout << "***********************************\n";
		cout << "Height:"<< height<<"\n";
		cout << "Gender:";
		CheckGender();
		cout << "***********************************\n";
	
	}




};

int main()
{
	Date date;
	date.year = 2001;
	date.month = 12;
	date.day = 14;
	
	Person person1("Boguslaw","Linda", date, 150);
	//person1.ShowMajority();
	person1.ShowPersonInfo();
	Person person2("Natalia", "Krawczyk", date, 180);
	//person2.ShowPersonInfo();
}