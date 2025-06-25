# C# role playing game
This is taken from Scott's Open-Source C# Role-Playing Ga[](https://soscsrpg.com/)me.

## Features
* User can create a player
  * Different classes (different bonuses for each class)
* Player can move to locations
* The location might have a monster to fight
* If the player defeats the monster, they receive:
  * Experience points, gold, random loot
* If the player loses to the monster, they:
  * Return home 
  * Are completely healed
* The location might have a quest
  * Completing the quest requires turning in an item
    * Item is from monster loot
  * When the player has the quest completion item, and returns to the location where they received the quest, they receive:
    * Experience points, gold, a reward item
  * The location might have a trader
    * Player can buy/sell items
  * Player can save/load game

## Map of locations
![](/Users/solmazpurser/RiderProjects/C_sharp_exercises/game_map.png)
