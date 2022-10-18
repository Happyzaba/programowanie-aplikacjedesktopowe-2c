#include <iostream>

using namespace std;

struct Point {
    int x;
    int y;
};

double calculateDistance(int a, int b)
{
    double distance = sqrt(a * a + b * b);
    return distance;
}

double calculateDistance(Point p)
{
    double distance = sqrt(p.x * p.x + p.y * p.y);
    return distance;
}

void CoordinateTestVersion1()
{
    float x, y;
    cout << "Podaj X: \n";
    cin >> x;
    
    cout << "Podaj Y: \n";
    cin >> y;
        
   double distance = calculateDistance(x,y);

   cout << "Odleglosc to: " << distance << "\n";
}

void CoordinateTestVersion2()
{
    Point userPoint;
    
    cout << "Podaj x: \n";
    cin >> userPoint.x;

    cout << "Podaj y: \n";
    cin >> userPoint.y;

    double distance = calculateDistance(userPoint.x, userPoint.y);

    cout << "Odleglosc to: " << distance << "\n";
}

int main()
{
    CoordinateTestVersion1();
    CoordinateTestVersion2();
}

struct Person
{
    string name;
    string surnamne;
    int age;
    int height;
    Point coordinate;
};

Person p1;
//p1.name
//
string nameTab[5];
string surnameTab[5];
int ageTab[5];
int heightTab[5];

Person pTab[5];
//pTab[1].name="Ala";












