# The Legend of Zelda
## Sprint2:

## Author: 
Mingjie Song, Wei Zong, Tina Liang, Yilai Yan, Wenzhuo Wang, Xinyi Chen

## Game Introduction:
In Sprint2, there are one player Link, one enemy dragon, and one non-player character princess Zelda. Player Link uses tools such as wooden sord and bomb; enemy dragon moves randomly on screen while constantly projecting fire; a non-animated princess Zelda can be showen by clicking the switch key; other items such as clock, heart, and blue diamond can be cycled between each other at the bottom of screen. All characters and items have no interactions with each other for now.

## Game Pattern:
#### state pattern
- ICommand is implemented by Command classes
- IController is implemented by KeyboardController classes 
- IPlayer is implemented by Link classes
- IPlayerState is implemented Link state classes
- IEnemyOrNPC is implemented by Enemy and NPC classes 
- IEnemyState is implemented by Dragon state classes
- INpcState is implemented by NPC state classes
- IItem is implemented by item states classes including bomb, clock, and fire etc.
- IItemState is implemented by all items state classes
- ISprite is implemented by all sprites classes
- Texture2DStorage class is used to store all sprites' textures

## Current Features:
 
#### Player controls
- Arrow and "wasd" keys move Link and change his facing direction.
- The 'z' and 'n' key cause Link to attack using his sword.
- Number keys 1 can be used to have Link use drop a bomb, and number key 2 can be used to have Link use a wooden sord.
- The 'e' can change Link to damaged state

#### Item controls
- The keys "u" and "i" cycle between which item is currently being shown, the items that can be shown includes clock, heart, and blue diamond. 
- The number key 1 causes Link drop a bomb, and number key 2 causes Link to use his wooden sord.
- Items do not interact with any other objects for now

#### Enemy/NPC (other character) controls
- The keys "o" and "p" cycle between enemy dragon and npc princess Zelda
- Dragon have animated states and move randomly while projecting fire
- Princess Zelda stay non-animated.
- They do not interact with any other objects for now

#### Other controls
- The 'q' key quits game
- The 'r' key resets the program back to its initial state.

## Code Analysis
- The number of warnings and errors: 
