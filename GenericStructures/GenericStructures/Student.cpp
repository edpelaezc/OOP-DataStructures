#include "pch.h"
#include "Student.h"
#include <string>
#include <string.h>

Student::Student() {}

Student::Student(int carnet, char *sName)
{
	this->carnet = carnet;
	this->name = sName;
}

int Student::getCarnet() {
	return carnet;
}

void Student::setCarnet(int sCarnet) {
	carnet = sCarnet;
}

char* Student::getName() {
	return name;
}

void Student::setName(char *sName) {
	name = sName;
}

void Student::toString() {
	std::cout << "[Name]: " << getName() << std::endl << "[Carnet]: " << getCarnet() << std::endl;
}

Student::~Student()
{
}
