# Groupe Eau-Mineral
# Game Design
## Concept
Vous êtes un aventurier qui est tombé dans un trou, s'avèrent être un donjon dans lequel il vous faut trouver la sortie.

Vous devez passer de salle en salle en effectuant des quêtes qui changent à chaque salle.
Vous serez amené à combattre pour votre vie, votre équipement et votre dextérité seront les clés pour survivre.

Vous commencez la partie avec votre équipement de base, à savoir une épée toute simple qui va changer au cours de la partie.

La difficulté du jeu augmente au fur et à mesure que la partie se déroule.


## Gampelay
Notre RPG est un jeu 2D a avec une vue du dessus.
### Objectif de salle
Le joueur progresse dans un labyrinthe peuplé de monstre.
Chaque salle de ce labyrinthe donne un objectif au joueur :
- Massacre : Le joueur doit tuée tout les monstre présent dans la salle avant de pouvoir continuer son chemin.
- Clef : Un des monstre present dans la piece a une clés sur  luis il faut lui dérobé pour pouvoir sortire.

## Armes
Le Systeme de combat est aussi ce qui rend notre jeux interessant :

Le joueur posséde en bas a droite de l'écrant 4 slot. ils constitue l'inventaire. Ce que le joueur peut utilisé :
- Slot d'arme : Permet de contenir une arme qui vas changer la manier d'attaquer du personnage. Chaque arme a des caracteristique differente afin de modifier le gameplay :

    - L'épee simple : Coup simple devant le personnage.
    - L'épee double : Inflige moin de dégat que l'épée simple mais  permet d'attaqué plus vite.
    - L'arc simple : Permet d'envoyer un projectile devant le personnage.

## Generation Procedurale
La génération procédurale se fait par l'intermédiaire des portes que le joueur passe. Quand il passe une porte après l'avoir ouverte, il marche sans le savoir sur un élément qui fait spawn la salle suivante parmis une liste de salle possible. Il y a ainsi 4 listes de salle car le joueur peut arriver de 4 endroits différents.

## L'interaction
Le joueur peut intéragir avec plusieurs éléments de son environnement : les objets et les mobs
Ces éléments sont détectés à l'aide d'un overlap créé par le joueur avec des touches précises, l'une sert à attaquer les ennemi, l'autre à ramasser ou utiliser des objets.

## Plus de précision
Pour avoir des détails des manière de faire tel ou tel chose, des dossiers explications et vidéos sont disponibles pour aider.

## Problème rencontré
Des problème ont été rencontrés lors de la création de la génération procédurale avec le fait de pouvoir automatiquement créer les salles suivantes aléatoirement et au bon endroit.
Des problème de collider ont également été rencontrés vers la fin du processus de création.
Des objets récupérables ont posé des soucis durant leur création.
La création des IA par le code uniquement a aussi posé quelque soucis, notamment dans le changement d'état et la création d'effet ou action particulière.

## Résolution
Malheuresement, seul le problème de génération procédurale a été impossible a régler avec nos compétences actuelles, les salles suivantes apparaissaient certes, mais au mauvais endroit et empilées les unes sur les autres.
Les objets qui posaient poblèmes ont été abandonnés dans les assets et seuls fonctionnant on été gardé.

## Des preuves de notre travail se trouve à ces liens:
GDD :https://docs.google.com/document/d/1MOgN9Cmmnw9T821qZ9wcUv3CsC7VkAA52k2r_U00ORQ/edit
Trello :https://trello.com/b/Wmp7orb2/eau-min%C3%A9ral-todolist
