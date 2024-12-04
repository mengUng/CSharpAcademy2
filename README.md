### Système de suivi des changements d'état d'objets ###

Spécifications :
----------------
Chaque objet métier possède un état initial et peut passer par plusieurs états jusqu'à un état final.
Le système doit enregistrer chaque changement d'état avec une date et une description de l'événement ayant conduit au changement.
Implémentez une classe EtatHistorique qui stocke les transitions d'état d'un objet.
Le système doit permettre d'afficher l'historique complet des états d'un objet, en incluant la date et la description de chaque transition.


Mise en oeuvre :
----------------
Ce projet implémente un modèle basé sur le Pattern État pour gérer les différents états d'une porte (ouverte, fermée, verrouillée) 
et inclut un système pour enregistrer l'historique des transitions d'état avec une date et une description.


Fonctionnalités :
1. Pattern État :
    La porte peut être dans un des états suivants :
        - Fermée
        - Ouverte
        - Verrouillée
    Chaque état est implémenté comme une classe séparée (ex. PorteFermee, PorteOuverte, PorteVerrouille).
	
2 - Historique des États :
    Un historique des transitions est enregistré via la classe EtatHistorique.
    Chaque transition inclut :
        La date de la transition.
        Le nom de l'état.
		
Structure du Projet :
	Classes Principales :
		IEtat : Interface pour définir les états de la porte.
		Porte : Classe principale représentant la porte. Elle contient un état actuel et un historique des transitions.
		États :
			PorteFermee : Représente une porte fermée.
			PorteOuverte : Représente une porte ouverte.
			PorteVerrouille : Représente une porte verrouillée.
		EtatHistorique : Gère l'enregistrement et l'affichage des transitions d'état.
		
Exemple d'utilisation :
	Voir le contenu du fichier Program.cs du projet.
	
	
	
