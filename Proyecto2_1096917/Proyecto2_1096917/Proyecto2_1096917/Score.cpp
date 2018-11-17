#include "pch.h"
#include "Score.h"
#include <sstream>

Score::Score() {}

Score::Score(Jugador j, int quali)
{
	this->j = j;
	this->qualification = quali;
}

Jugador Score::getJugador() { return j; }

int Score::getQuilification() { return qualification; }

string Score::toString() {
	stringstream ss;	
	ss << j.toString() << std::endl <<"[CALIFICACION]: " <<  qualification << std::endl;
	string response = ss.str();
	return response;
}

Score::~Score()
{
}
