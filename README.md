# CSE-3902 Zelda Game Sprint 3
## Current future

##### Link has initial blood of 12 lives once the game is began. The various enemies will cause Link to drop his blood differenly. Link can pick up many items where each of them has functionality.
* Heart: Link gains one drop of blood
* Key: Link can use it to open the door
* Clock: freeze all moving objects in all the rooms
* Map: Show the level map both on the game bar and inventory screen
* Compass: Show the location of TriForce Pieces on the map only item Map is collected
* Diamond: Dead enemy will turn into a diamond for Link to collect. Link can use it as money
* Weapon: Such as Bomb, Boomerang, Bow, and Candle. All can be purchased in Merchandise room with corrsponding price which is the number of Diamonds


## How to play

### Start State
* Press "S" to start a game, switch to the Play State
### Play State
* All enemies, npcs, and items appear in the first room. Link can pick up items by touching them. To unlock the door, he has to pick up the key first. At the same time, Link need to avoid enemies to avoid damage or attack enemies to destory them
* Press "1" to use the wooden sword as defalut weapon
* After purchasing other weapon, press "I" to switch to Inventory room 
* In the Inventory room, the weapons that being purchased will appear in the rectangle box on the top. Use "Up Arrow", "Down Arrow", "Left Arrow", or "Right Arrow" to traverse the weapon. Press "Enter" to select the weapon. Link can only select on per time, the selected item will appear in "item B" box. 
* Press "R" to switch back to Play room from Inventory room, press "2" to use the selected weapon from Inventory room



### Implementation

* Added camera for room switching in map
* Added collision detection
* Added xmls for rooms

### BUGS

#### Game play:  

currently empty itemstate interface  

rooms always refresh to initial state when entering  

partial funtionalities  

#### Unresolved warnings:  

Warning CA1303: Do not pass literals as localized parameters. These warnings happen when we use strings as parameter without defined or localized before.   

Warning CA1051: Do not declare visible instance fields. These warnings happen when we use public identifier instead of using private. Some of them were modified, others were suppressed in the file or in the source because these fields need to be accessed by other codes.  

Warning CA2211: Non-constant fields should not be visible.  

Warning CA2227: Collection properties should be read only  

Message IDE0044: Add readonly modifier. These three warnings are safe to be added to suppression file   

Message IDE0059: Unnecessary assignment of a value. The system said the it is unnecessary for some assignments. But the variables were used in the afterward code. They need to be investigated further.  

