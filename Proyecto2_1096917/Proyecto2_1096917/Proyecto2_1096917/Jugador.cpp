#include "pch.h"
#include "Jugador.h"

Jugador::Jugador() {}

Jugador::Jugador(string conference, string division, string city, string team, string position, int number, int id,
	string name, string height, string weight, string birthdate, int power, string skill, int scoredPoints,
	int stolenBalls, int rebounds, int plugs, int votes) {
	this->setName(name);	
	this->id = id;
	this->birthdate = birthdate;
	this->city = city;
	this->division = division;
	this->conference = conference;
	this->team = team;
	this->position = position;
	this->power = power;
	this->skill = skill;
	this->height = height;
	this->scoredPoints = scoredPoints;
	this->stolenBalls = stolenBalls;
	this->rebounds = rebounds;
	this->plugs = plugs;
	this->votes = votes;
}

int Jugador::getId()
{
	return id;
}

void Jugador::setId(int jId)
{
	id = jId;
}

int Jugador::getNumber() {
	return number;
}

void Jugador::setNumber(int jNumber) {
	number = jNumber;
}

string Jugador::getConference()
{
	return conference;
}

void Jugador::setConference(string jConference)
{
	conference = jConference;
}

string Jugador::getTeam()
{
	return team;
}

void Jugador::setTeam(string jTeam)
{
	team = jTeam;
}

string Jugador::getPosition()
{
	return position;
}

void Jugador::setPosition(string jPosition)
{
	position = jPosition;
}

string Jugador::getWeight(){
	return weight;
}

void Jugador::setWeight(string jWeight) {
	weight = jWeight;
}

string Jugador::getBirthdate() {
	return birthdate;
}

void Jugador::setBirthDate(string jBirthdate) {
	birthdate = jBirthdate;
}

int Jugador::getPower()
{
	return power;
}

void Jugador::setPower(int jPower)
{
	power = jPower;
}

string Jugador::getSkill()
{
	return skill;
}

void Jugador::setSkill(string jSkill)
{
	skill = jSkill;
}

string Jugador::getHeight()
{
	return height;
}

void Jugador::setHeight(string jHeight)
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

void Jugador::toString() {	
	cout << "Jugador [ID: " << id << ", Nombre: " << getName() << ", Ciudad: " << city << ", Conferencia: " << conference << ", Equipo: " << team << ", Posicion:" << position
		<< ", Potencia: " << power << ", Habilidad: " << skill << ", Altura: " << height << ", Puntos: " << scoredPoints
		<< ", Balones robados=" << stolenBalls << ", Rebotes: " << rebounds << ", Tapones: " << plugs << ", Votos: " << votes
		<< ", Peso: " << weight << ", Numero: " << number << ", Fecha de Nacimiento: " << birthdate << "]";
}

Jugador::~Jugador()
{
}
