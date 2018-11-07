#include "pch.h"
#include "Jugador.h"


Jugador::Jugador()
{
}

int Jugador::getId()
{
	return id;
}

void Jugador::setId(int jId)
{
	id = jId;
}

char* Jugador::getConference()
{
	return conference;
}

void Jugador::setConference(char jConference[])
{
	conference = jConference;
}

char* Jugador::getTeam()
{
	return team;
}

void Jugador::setTeam(char jTeam[])
{
	team = jTeam;
}

char* Jugador::getPosition()
{
	return position;
}

void Jugador::setPosition(char jPosition[])
{
	position = jPosition;
}

int Jugador::getWeight(){
	return weight;
}

void Jugador::setWeight(int jWeight) {}

char* Jugador::getBirthdate() {
	return birthdate;
}

void Jugador::setBirthDate(char jBirthdate[]) {}

int Jugador::getPower()
{
	return power;
}

void Jugador::setPower(int jPower)
{
	power = jPower;
}

char* Jugador::getSkill()
{
	return skill;
}

void Jugador::setSkill(char jSkill[])
{
	skill = jSkill;
}

int Jugador::getHeight()
{
	return height;
}

void Jugador::setHeight(int jHeight)
{
	height = jHeight;
}

int Jugador::getScoredPoints()
{
	return scoredPoints;
}

void Jugador::setScoredPoints(int jScoredPoints)
{
	scoredPoints = jScoredPoints;
}

int Jugador::getStolenBalls()
{
	return stolenBalls;
}

void Jugador::setStolenBalls(int jStolenBalls)
{
	stolenBalls = jStolenBalls;
}

int Jugador::getRebounds()
{
	return rebounds;
}

void Jugador::setRebounds(int jRebounds)
{
	rebounds = jRebounds;
}

int Jugador::getPlugs()
{
	return plugs;
}

void Jugador::setPlugs(int jPlugs)
{
	plugs = jPlugs;
}

int Jugador::getVotes()
{
	return votes;
}

void Jugador::setVotes(int jVotes)
{
	votes = jVotes;
}

Jugador::~Jugador()
{
}
