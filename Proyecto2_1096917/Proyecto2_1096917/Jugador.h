#pragma once
#include "Persona.h"
class Jugador: public Persona
{
public:
	Jugador();
	int getId();
	void setId(int jId);
	char* getConference();
	void setConference(char jConference[]);
	char* getTeam();
	void setTeam(char jTeam[]);
	char* getPosition();
	void setPosition(char jPosition[]);
	int getPower();
	void setPower(int jPower);
	char* getSkill();
	void setSkill(char jSkill[]);
	int getHeight();
	void setHeight(int jHeight);
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
	int getWeight();
	void setWeight(int jWeight);		
	char* getBirthdate();
	void setBirthDate(char jBirthdate[]);
	~Jugador();
private:
	 int id;
	 char* conference;
	 char* team;
	 char* position;
	 char* skill;
	 char* birthdate;
	 char* city;
	 char* division;
	 int power;	 
	 int height;
	 int weight;
	 int scoredPoints;
	 int stolenBalls;
	 int rebounds;
	 int plugs;
	 int votes;
};

