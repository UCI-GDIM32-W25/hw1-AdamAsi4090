[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/MjLLqDcN)
# HW1
## W1L2 In-Class Activity

Put your notes from the W1L2 (Thurs, Jan 9) in-class activity here.

# Objects
*Player
*Plant
*UI
**Seeds Planted UI
**Seeds Remaining UI
*Camera
#Attributes / Actions
##The player
*The player can move in eight directions with the WASD keys.
*The player can move freely through the world’s borders.
##The plant
*One is planted each time the player presses SPACE.
*The plants have no collision, so the player can walk through them.
##Seeds Planted UI
*Shows the number of plants.
*Begins at 0.
##Seeds Remaining UI
*Shows the number of available plants.
*Begins at 5.
#Interactions
*Press SPACE to create a plant at the player’s current location.
*The seeds planted UI increases each time a plant is planted.
*The seeds remaining UI decreases each time a plant is planted.
*Once the seeds remaining Ui reaches zero, the player can no longer plant anymore plants, and no more plants can appear.


## Devlog
Prompt: Include the HW1 break-down exercise you wrote during the Week 1 - Lecture 2 (Jan 9) in-class activity (above). If you did not attend and perform this activity, review the lecture slides and write your own plan for how you believe HW1 should be built. If your initially proposed plan turned out significantly different than the activity answers given by Prof Reid, you may want to note what was different. Then, write about how the plan you wrote in the break-down connects to the code you wrote. Cite specific class names and method names in the code and GameObjects in your Unity Scene.


Write your Devlog here!
In order to get the player to move, I utilized the GetKey() function to get the an input from the player, this being the WASD keys, and outputted movement by using _playerTransform.Translate(), allowing the player to move in the direction they are holding. In order to simulate the plant and planting it, I turned the plant into _plantPrefab, used GetKeyUp() to detect an input from the player pressing the Space key, and called the PlantSeed() method. I would instantiate _plantPrefab into a plant GameObject, then used plant.transform.localposition to place the plant in the local position of the player with _playerTransform.localPosition. Afterwards, the amount of seeds (represented by _numSeedsLeft) would decrement, and the number of seeds planted (represented by _numSeedsPlanted) would increment. If the number of seeds is equal to to 0, then the PlantSeed() method would no longer activate, preventing me from planting anymore plants.

_plantCountUI.cs was used to simulate the UI for the seeds planted and the seeds remaining. At the start, I inputted the amount of seeds left as _numSeedsLeft, and set the amount of seeds planted as 0, sending it to the UI with the method UpdateSeeds(). This UpdateSeeds() method is then used everytime the PlantSeed() is used, with _numSeedsLeft and _numSeedsPlanted being inputted to UpdateSeeds() instead. From there, _plantCountUI.cs is used as a component of Canvas, with _plantedText and _remainingText being added to Text_SeedsPlantedNum and Text_SeedsRemainingNum, and updated each time UpdateSeeds() is called.

## Open-Source Assets
If you added any other outside assets, list them here!
- [Sprout Lands sprite asset pack](https://cupnooble.itch.io/sprout-lands-asset-pack) - character and item sprites
