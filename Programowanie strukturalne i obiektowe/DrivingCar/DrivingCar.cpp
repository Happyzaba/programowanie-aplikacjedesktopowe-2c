#include <iostream>

using namespace std;

struct CoordinateGPS
{
    int x, y;
};

struct Direction
{
    int x,y;

};

class Car
{
public:

#pragma region Konstruktory

    Car(string name)
    {
        this->name = name;
        coordinateGPS.x = 0;
        coordinateGPS.y = 0;
        direction.x = 1;
        direction.y = 0;
    }

    Car(string name, int x, int y)
    {
        this->name = name;
        coordinateGPS.x = x;
        coordinateGPS.y = y;
        direction.x = 1;
        direction.y = 0;
    }

#pragma endregion

#pragma region Turn method

    void ShowInfo()
    {
        cout << "***********************************\n";
        cout << "Samochod o nazwie " << name << "\n";
        cout << "Pozycja (" << coordinateGPS.x << " ; " << coordinateGPS.y << ")\n";
        cout << "***********************************\n";
    }

    void MoveForward()
    {
        coordinateGPS.x += direction.x;
        coordinateGPS.y += direction.y;

    }

    void TurnLeft()
    {
        /*if (direction.x == 1 && direction.y == 0)
        {
            direction.x = 0;
            direction.y = 1;
        }
        else if(direction.x==0 && direction.y==1)
        {
            direction.x = 0;
            direction.y = -1;
        }
        else if (direction.x == 0 && direction.y == -1)
        {
            direction.x = -1;
            direction.y = 0;
        }
        */
        int tmpX = direction.x;
        direction.x = -direction.y;
        direction.y = tmpX;

    }

    void TurnRight()
    {

        int tmpX = direction.x;
        direction.x = direction.y;
        direction.y = -tmpX;
    }

    void TurnBack()
    {
        TurnRight();
        TurnRight();

    }

#pragma endregion

protected:

private:
    string name;

    CoordinateGPS coordinateGPS;

    Direction direction;
};

int main()
{
    setlocale(LC_CTYPE, "polish");

    Car carFirst("Super bryka");
    Car carSecond("Krązwonik szos", 10, 10);

    carFirst.ShowInfo();
    carSecond.ShowInfo();

    carFirst.MoveForward();
    carFirst.TurnLeft();
    carFirst.MoveForward();

    carFirst.ShowInfo();
}