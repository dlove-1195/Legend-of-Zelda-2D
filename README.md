# CSE-3902 Zelda Game Sprint 3
### How to play

* Game is automatically running in fullscreen mode
* See all enemies, npcs, and items in the first room
* Touch items to pick up
* Avoid enemies to avoid damage
* Press "1" to blow up enemies with bomb
* Press "2" to shoot a sword
* Press "3" to shoot a bow
* Press "4" to throw a boomerang
* Press "5" to use a candle, which does nothing right now
* Press "Z" or "N" to swing a sword, you cannot swing a sword when getting damage
* Press "Q" to exit game, and "R" to restart
* Walk to room 13 or room 15 to find stairs, go on stairs and enter next level

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

