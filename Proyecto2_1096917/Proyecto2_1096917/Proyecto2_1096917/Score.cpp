#include "pch.h"
#include "Score.h"

Score::Score() {}

Score::Score(Jugador j, int quali)
{
	this->j = j;
	this->qualification = quali;
}

Jugador Score::getJugador() { return j; }

int Score::getQuilification() { return qualification; }

void Score::toString() {
	j.toString();
	std::cout << "[CALIFICACION]: " << qualification << std::endl;
}

Score::~Score()
{
}
