// Proyecto2_1096917.cpp : Este archivo contiene la función "main". La ejecución del programa comienza y termina ahí.
//

#include "pch.h"
#include "BinaryTree.h"
#include "BinaryTree.cpp"
#include "MyLinkedList.h"
#include "MyLinkedList.cpp"
#include "Jugador.h"
#include "Persona.h"
#include "Score.h"
#include <iostream>
#include <string>

void showTeam(TreeNode<Jugador> *root, string team);
void showConference(TreeNode<Jugador> *root, string conference);
void score(TreeNode<Jugador> *root);
void showList(static MyLinkedList<Score> *list);
int base(int weight, int month, int skill, int points, int stolenBalls, int votes);
int alero(int inchesHeight, int weight, int year, int points, int rebounds, int votes);
int pivote(int metersHeight, int weight, int day, int power, int points, int plugs, int votes);
void bubble(static MyLinkedList<Score> *list);
static MyLinkedList<Score> *guardResults = new MyLinkedList<Score>();
static MyLinkedList<Score> *forwardResults = new MyLinkedList<Score>();
static MyLinkedList<Score> *centerResults = new MyLinkedList<Score>();

using namespace std;
int main(){    
	BinaryTree<Jugador> *guard = new BinaryTree<Jugador>();
	BinaryTree<Jugador> *forward = new BinaryTree<Jugador>();
	BinaryTree<Jugador> *center = new BinaryTree<Jugador>();
	int opt = 0;
	cout << "SEGUNDO PROYECTO \nCLASIFICACION PARA EL JUEGO DE LAS ESTRELLAS." << endl;

	do {
		cout << "\nSELECCIONE UNA OPCION" << endl;
		cout << "1. MANEJO DE DATOS" << endl;
		cout << "2. REPORTE ESTADISTICAS" << endl;
		cout << "3. SIMULACION"<< endl;
		cout << "4. SANCION A JUGADOR" << endl;
		cout << "5. SALIR" << endl;
		cin >> opt;

		switch (opt)
		{
		case 1: {
			cout << "\nDATOS CARGADOS AL SISTEMA CORRECTAMENTE." << endl;

			FILE *archivo;
			char caracter;		
			string cadena = "";
			string atributos[18];
			archivo = fopen("Prueba.txt", "r");
			int cont = 0;

			if (archivo == NULL) {
				cout << "Error en apertura de archivo";
			}
			else {
				caracter = fgetc(archivo);
				while (caracter != EOF) {
					if (caracter != '\n') {			
						if (caracter != '|') {
							cadena += caracter;
							caracter = fgetc(archivo);
						}
						else {
							atributos[cont] = cadena;
							cadena = "";
							caracter = fgetc(archivo);
							cont++;
						}
					}
					else {	
						atributos[cont] = cadena;
						cadena = "";
						Jugador aux;
						//inicializar jugador con su constructor e insertarlo al arbol binario según su posición
						aux = *new Jugador(atributos[0], atributos[1], atributos[2], atributos[3], atributos[4], atoi(atributos[5].c_str()), atoi(atributos[6].c_str()),
							atributos[7], atributos[8], atributos[9], atributos[10], atoi(atributos[11].c_str()), atoi(atributos[12].c_str()), atoi(atributos[13].c_str()),
							atoi(atributos[14].c_str()), atoi(atributos[15].c_str()), atoi(atributos[16].c_str()), atoi(atributos[17].c_str()));
						if (atributos[4] == "G") {
							guard->add(aux, aux.getId());
						}
						else if (atributos[4] == "F") {
							forward->add(aux, aux.getId());
						}
						else {
							center->add(aux, aux.getId());
						}
						cont = 0;
						caracter = fgetc(archivo);
					}
				}
			}
			fclose(archivo);
					
		}break;

		case 2: {
			int option = 0;
			cout << "\nSELECCIONE LA OPCION DE SU REPORTE DE ESTADISTICAS: " << endl;
			cout << "1. POR JUGADOR" << endl;
			cout << "2. POR EQUIPO" << endl;
			cout << "3. POR CONFERENCIA" << endl;
			cout << "4. MEJORES POR ESTADISTICA" << endl;
			cin >> option;

			if (option == 1) {//mostrar estadisticas por medio del codigo del jugador
				Jugador response;
				int id = 0;
				cout << "\nINGRESE EL CODIGO DEL JUGADOR QUE DESEA CONSULTAR: " << endl;
				cin >> id;
				if (guard->elementExists(guard->root, id)) {
					response = guard->showElement(guard->root, id);
					response.toString();
				}
				else if (forward->elementExists(forward->root, id)) {
					response = forward->showElement(forward->root, id);
					response.toString();
				}
				else if (center->elementExists(center->root, id)) {
					response = center->showElement(center->root, id);
					response.toString();
				}
				else {
					cout << "\nEL CODIGO DEL JUGADOR NO EXISTE O ES INCORRECTO." << endl;
				}
			}
			else if (option == 2) {//Listar jugadores para el equipo seleccionado
				string team = "";
				cout << "\nINGRESE EL NOMBRE DEL EQUIPO DE SU CONSULTA: " << endl;
				cin >> team;
				showTeam(guard->root, team);
				showTeam(forward->root, team);
				showTeam(center->root, team);
			}
			else if (option == 3) {//Listar jugadores por conferencia
				string conference = "";
				cout << "\nINGRESE LA CONFERENCIA PARA HACER SU CONSULTA: " << endl;
				cin >> conference;				
				cout << endl;
				showConference(guard->root, conference);
				showConference(forward->root, conference);
				showConference(center->root, conference);
			}
			else if (option == 4) {
				score(guard->root);
				score(forward->root);
				score(center->root);
				bubble(guardResults);
				bubble(forwardResults);
				bubble(centerResults);
				cout << "\nLOS MEJORES 10 JUGADORES BASE: " << endl;
				showList(guardResults);
				cout << endl;
				cout << "LOS MEJORES 10 JUGADORES ALERO: " << endl;
				showList(forwardResults);
				cout << endl;
				cout << "LOS MEJORES 10 JUGADORES PIVOTE: " << endl;
				showList(centerResults);
				cout << endl;
			}

		}break;

		case 3: {
		}break; 		

		case 4: {
		}break;

		default:
			cout << "GRACIAS POR USAR EL PROGRAMA" << endl;
			break;
		}

	} while (opt != 5);
}

/*Método para recorrer los arboles y mostrar los jugadores del equipo seleccionado para opc. 2 de los
reportes de estadisticas*/
void showTeam(TreeNode<Jugador> *root, string team) {
	if (root != NULL) {
		if (root->getElement().getTeam() == team) {
			root->getElement().toString();
			cout << endl;
			cout << endl;
		}		
		showTeam(root->getLeft(), team);
		showTeam(root->getRight(), team);
	}
}

/*Metodo para recorrer los arboles y mostrar los jugadores por conferencia*/
void showConference(TreeNode<Jugador> *root, string conference) {
	if (root != NULL) {
		if (root->getElement().getConference() == conference) {
			root->getElement().toString();
			cout << endl;
			cout << endl;
		}
		showConference(root->getLeft(), conference);
		showConference(root->getRight(), conference);
	}
}

//Formulas para calcular la calificación de los jugadores para el juego de las estrellas
int base(int weight, int month, int skill, int points, int stolenBalls, int votes) {
	return weight + (month * 10) + skill + points + stolenBalls + votes;
}

int alero(int inchesHeight, int weight, int year, int points, int rebounds, int votes) {
	return (inchesHeight * 10) + weight + year + points + rebounds + votes;
}

int pivote(int metersHeight, int weight, int day, int power, int points, int plugs, int votes) {
	return metersHeight + weight + (day * 5) + power + points + plugs + votes;
}

//Recorrer el arbol para calcular la calificación del jugador en el nodo actual
void score(TreeNode<Jugador> *root) {
	if (root != NULL) {
		if (root->getElement().getPosition() == "G") {
			int n = base(atoi(root->getElement().getWeight().substr(8, 10).c_str()),
				atoi(root->getElement().getBirthdate().substr(5, 6).c_str()), root->getElement().getSkill(),
				root->getElement().getScoredPoints(), root->getElement().getStolenBalls(), root->getElement().getVotes());
			Score aux = *new Score(root->getElement(), n);
			guardResults->addLast(aux);
		}
		else if (root->getElement().getPosition() == "F") {
			int n = alero(atoi(root->getElement().getHeight().substr(5, 6).c_str()),
				atoi(root->getElement().getWeight().substr(0, 2).c_str()),
				atoi(root->getElement().getBirthdate().substr(0, 3).c_str()),
				root->getElement().getScoredPoints(), root->getElement().getRebounds(),
				root->getElement().getVotes());
			Score aux = *new Score(root->getElement(), n);
			forwardResults->addLast(aux);
		}
		else {
			int n = pivote(atoi(root->getElement().getHeight().substr(11, 14).c_str()),
				atoi(root->getElement().getWeight().substr(8, 10).c_str()), atoi(root->getElement().getBirthdate().substr(8, 9).c_str()),
				root->getElement().getPower(), root->getElement().getScoredPoints(),
				root->getElement().getPlugs(), root->getElement().getVotes());
			Score aux = *new Score(root->getElement(), n);
			centerResults->addLast(aux);
		}
		score(root->getLeft());
		score(root->getRight());
	}
}

//Metodo para mostrar la lista de los mejores jugadores por estadistica
void showList(static MyLinkedList<Score> *list) {
	Node<Score> *auxiliar = list->head;
	for (size_t i = 0; i < 10; i++) {
		if (auxiliar != NULL) {
			auxiliar->getElement().toString();
			cout << endl;
			auxiliar = auxiliar->getNext();
		}
	}
}

void bubble(static MyLinkedList<Score> *list) {
	Node<Score> *temp = list->head;

	while (temp->getNext() != NULL) {
		Node<Score> *tempj = temp->getNext();
		while (tempj != NULL)
		{
			if (temp->getElement().getQuilification() > tempj->getElement().getQuilification()) {
				Score aux = temp->getElement();
				temp->setElement(tempj->getElement());
				tempj->setElement(aux);
			}
			tempj = tempj->getNext();
		}
		temp = temp->getNext();
	}
}

