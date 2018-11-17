#pragma once
#include "Jugador.h"
#include <string>

using namespace std;
class Score
{
public:
	Score();
	Score(Jugador j, int quali);
	Jugador getJugador();
	int getQuilification();
	string toString();
	~Score();
private:
	Jugador j;
	int qualification;
};

