# Groupe Eau-Mineral
# Game Design
## Concept
Vous êtes un aventurier qui est tombé dans un trou qui s'avère être un donjon dans lequel il vous faut trouver la sortie.

Vous devez passer de salle en salle en effectuant des quêtes qui changent à chaque salle.
Vous serez amené à combattre pour votre vie, votre équipement et votre dextérité seront les clés pour survivre.

Vous commencez la partie avec votre équipement de base, à savoir une épée toute simple qui va changer au cours de la partie.

La difficulté du jeu augmente au fur et à mesure que la partie se déroule.


## Gamplay
Notre RPG est un jeu 2D avec une vue du dessus.
### Objectif de salle
Le joueur progresse dans un labyrinthe peuplé de monstres.
Chaque salle de ce labyrinthe donne un objectif au joueur :
- Massacre : Le joueur doit tuer tous les monstres présents dans la salle avant de pouvoir continuer son chemin.
- Clef : Un des monstres présents dans la piece a une clé sur  lui. Le joueur doit la lui dérober pour pouvoir sortir.

### Armes
Le Systeme de combat est aussi ce qui rend notre jeu interessant :

Le joueur posséde en bas a droite de l'écran 4 emplacements. Ces derniers constituent l'inventaire. Ce que le joueur peut utiliser :
- Slot d'arme : Permet de contenir une arme qui va changer la maniere d'attaquer du personnage. Chaque arme a des caracteristiques differentes afin de modifier le gameplay :

    - L'épee simple : Coup simple devant le personnage.
    - L'épee double : Inflige moins de dégats que l'épée simple mais  permet d'attaquer plus vite.
    - L'arc simple : Permet d'envoyer un projectile devant le personnage.


<img src = "images/ArmePouvoirs.png" width = "500">

(Image des differentes armes et pouvoirs)

Les potions sont des consomables qui prennent un emplacement dans l'inventaire. Le joueur ne peut en avoir qu'une seule.

<img src = "images/PotionBoost.png" width = "200">
<img src = "images/PotionSoins.png" width = "200">
<img src = "images/PotionVitesse.png" width = "200">

Leurs effets sont un boost de force Un soin instatané et un boost de vitesse

<img src = "images/effetForce.png" width = "250">
<img src = "images/effetSoins.png" width = "250">
<img src = "images/effetSpeed.png" width = "300">

## Generation Procedurale
La génération procédurale se fait par l'intermédiaire des portes que le joueur passe. Quand il passe une porte après l'avoir ouverte, il marche sans le savoir sur un élément qui fait spawn (apparaitre) la salle suivante parmi une liste de salles possibles. Il y a ainsi 4 listes de salles car le joueur peut arriver de 4 endroits différents.

## L'interaction
Le joueur peut intéragir avec plusieurs éléments de son environnement : les objets et les mobs (créatures).
Ces éléments sont détectés à l'aide d'un overlap créé par le joueur avec des touches précises, l'une sert à attaquer les ennemis, l'autre à ramasser ou utiliser des objets.

## Plus de précision
Pour avoir des détails des manières de faire telle ou telle chose, des dossiers explications et vidéos sont disponibles pour aider.

## Problème rencontré
Des problème ont été rencontrés lors de la création de la génération procédurale avec le fait de pouvoir automatiquement créer les salles suivantes aléatoirement et au bon endroit.
Des problèmes de collider ont également été rencontrés vers la fin du processus de création.
Des objets récupérables ont posé des soucis durant leur création.
La création des IA par le code uniquement a aussi posé quelques soucis, notamment dans le changement d'état et la création d'effets ou actions particulières.

## Résolution
Malheuresement, seul le problème de génération procédurale a été impossible à régler avec nos compétences actuelles, les salles suivantes apparaissaient certes, mais au mauvais endroit et empilées les unes sur les autres.
Les objets qui posaient poblèmes ont été abandonnés dans les assets et seuls celles fonctionnants ont été gardé.

## Vidéo GamePlay

(https://www.youtube.com/watch?v=N6DmQTyGbJUv)

(Viédo qui montre les Menus, Menu-Pause, Interaction avec les objets le systeme d'inventaire et les effets de potions.)

![Groupe Eau-Mineral](https://img.youtube.com/vi/N6DmQTyGbJU/0.jpg)


## Des preuves de notre travail se trouve à ces liens:
- GDD :https://docs.google.com/document/d/1MOgN9Cmmnw9T821qZ9wcUv3CsC7VkAA52k2r_U00ORQ/edit

- Trello :https://trello.com/b/Wmp7orb2/eau-min%C3%A9ral-todolist