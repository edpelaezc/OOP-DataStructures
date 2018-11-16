#pragma once
#include "Jugador.h"
class Score
{
public:
	Score();
	Score(Jugador j, int quali);
	Jugador getJugador();
	int getQuilification();
	void toString();
	~Score();
private:
	Jugador j;
	int qualification;
};

