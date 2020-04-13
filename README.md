# CSE-3902 Zelda Game Sprint 4
## Current future

#### There are five Game States includs Start State, Play State, Pause State, Lose State and Win State. The state will be alternated among all five based on Link's behavior. In the Play State, Link has initial 12 blood drops once the game is began. Each room has been designed differenly with various enemies which cause Link to drop his blood variously. Link's position is shown on both the inventory bar and the inventory room through the game. And the whole map and TriForce Piece's location will appear only by picking up the corrsponding item. Link can pick up items where each of them has its unique functionality as listed below: 
* Heart: Link gains one drop of blood. Link can only pick up "Heart" when his blood is less than 12
* Key: Link can use it to open the door
* Clock: freeze all moving objects in all the rooms
* Map: Show the level map both on the game bar and inventory screen
* Compass: Show the location of TriForce Pieces on the map only when item Map is collected
* Yellow Diamond: Dead enemy will turn into a diamond for Link to collect. Link can use it as money
* Weapon: Boomerang, Bow, and Candle can be purchased in Merchandise room with corrsponding price which is the number of yellow Diamonds. There is no need to purchase a bow, it can be picked up in any room.


## How to play

#### Start State
* Press "S" to start a game, switch to the Play State
* Press "Esc" to quit the game
#### Play State
* All enemies and items appear in the first room. Link can pick up items by touching them. To unlock the door, he has to pick up the key first. At the same time, Link needs to avoid enemies to avoid damage or attack enemies to destory them. Link needs to collect three triforce piece in order to switch to the win state.
* Press "1" to use the wooden sword as the defalut weapon
* Press "I" to switch to Inventory room and "R" to switch back
* In the Inventory room, the weapons that being purchased will appear in the rectangle box on the top. Use "Up Arrow", "Down Arrow", "Left Arrow", or "Right Arrow" to traverse the weapons. Press "Enter" to select the weapon. Link can only select one per time, the selected weapon will appear in "item B" box. 
* Press "R" to switch back to Play room from Inventory room, press "2" to use the selected weapon from Inventory room
* Press "Q" to switch back to the Start State
* Press "P" to pause the game from Play State
* Switch to Win State once Link collects three TriForce Pieces
* Switch to Lose State once Link drop all his blood
* Press "Esc" to quit the game

#### Pause State
* Press "R" to switch back from Pause State to Play State 
* Press "Esc" to quit the game

#### Win State
* Press "R" to restart a game
* Press "Esc" to quit the game 
#### Lose State
* Press "R" to restart a game
* Press "Esc" to quit the game

 
#### Future Improvement and Implantation:
* Triforce pieces are being placed in room 1&17 (they are connected) so that you can switch to win state easily. They will be placed in the room 14,15,16 later
* Link attacks in damaged mode
* Door detection need to be revised (Link may be pushed by the enemies to another room near the wall)
* Fairy functionality need to be added
* WallMaster comes out from the wall and take Link to the beginning of the level
* Add more items and enemies
* Redesign rooms to complete the game

#### Unresolved warnings:  
CA1822 (Member StayPosition doesn't access instance data and can be marked as static at LinkCollisionHandler.cs, 
CA1040 (empty interface at IitemState)
