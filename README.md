[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/MjLLqDcN)
# HW1
## Devlog
Gianine Ariane Umali, she/her

In the week 1 activity this is what me and my team discussed for the game objects: 

For the bunny object, we said that it should have the attributes: speed, number of seeds, and the sprite. The action for it should be movement.

For the plant we said it should have the attribute of the location and with its actions being that it will appear when the space button is hit and having a counter for when how many seeds are planted and remaining.

For the UI, we said that it should display the number of seeds and has a background.


What I did for MG1:

For the bunny object, it has the attributes for speed, transform, plant prefab, number of seeds, the plant count UI, number of seeds left, and number of seeds planted.

For the actions of the bunny, I made the bunny move using the arrow keys using the transform and translate function. The bunny also has the action of planting the seeds using the PlantSeed() function, where when the space bar is hit, the function will see if there are less than 5 seeds planted and if so, then a plant prefab will instantiate where the bunny is.

For the UI, it has the attributes of the planted text, remaining text, seeds left, and seeds planted. 

The plant uses the Start and Update functions to constantly adjust the numbers that are shown on the screen based on the amount of seeds planted and remaining.


Overall:

One difference between the planning stage and what I actually ended up doing is that the plant did not have any attributes or actions. Also, the bunny game object is the one that has the planting function in it and not the plant.

## Open-Source Assets
If you added any other outside assets, list them here!
- [Sprout Lands sprite asset pack](https://cupnooble.itch.io/sprout-lands-asset-pack) - character and item sprites

