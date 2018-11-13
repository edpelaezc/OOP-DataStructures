#pragma once
#include "Persona.h"
#include <string>
#include <iostream>

using namespace std;
class Jugador: public Persona
{
public:
	Jugador();
	Jugador(string conference, string division, string city, string team, string position, int number, int id,
		string name, string height, string weight, string birthdate, int power, string skill, int scoredPoints,
		int stolenBalls, int rebounds, int plugs, int votes);
	string cadena;
	int getId();
	void setId(int jId);
	string getConference();
	void setConference(string jConference);
	string getTeam();
	void setTeam(string jTeam);
	string getPosition();
	void setPosition(string jPosition);
	int getPower();
	void setPower(int jPower);
	string getSkill();
	void setSkill(string jSkill);
	string getHeight();
	void setHeight(string jHeight);
	int getScoredPoints();
	void setScoredPoints(int jStolenBalls);
	int getStolenBalls();
	void setStolenBalls(int jStolenBalls);
	int getRebounds();
	void setRebounds(int jRebounds);
	int getPlugs();
	void setPlugs(int jPlugs);
	int getVotes();
	void setVotes(int jVotes);
	string getWeight();
	void setWeight(string jWeight);		
	string getBirthdate();
	void setBirthDate(string jBirthdate);
	int getNumber();
	void setNumber(int jNumber);
	void toString();	
	~Jugador();
private:	 
	 string conference;
	 string team;
	 string position;
	 string skill;
	 string birthdate;
	 string city;
	 string division;
	 string height;
	 string weight;
	 int id;	 
	 int number;	 
	 int power;	 	 
	 int scoredPoints;
	 int stolenBalls;
	 int rebounds;
	 int plugs;
	 int votes;
};

