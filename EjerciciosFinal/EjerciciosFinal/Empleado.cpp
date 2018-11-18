#include "pch.h"
#include "Empleado.h"


Empleado::Empleado() {}

void Empleado::setNombre(string eNombre) { nombre = eNombre; }

string Empleado::getNombre() { return nombre; }

void Empleado::setEdad(int eEdad) { edad = eEdad; }

int Empleado::getEdad() { return edad; }

void Empleado::setDui(int eDui) { dui = eDui; }

int Empleado::getDui() { return dui; }

Empleado::~Empleado() {}
