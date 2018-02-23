# Miskatonic-Investigations
An old prototype of a Top Down horror game

//As of 2-23-2018
I have thus far programmed the player movement.

Also wrote up a somewhat reusable lever code. It can take in most objects and depending on that objects tag calls a method. I could have made this more reusable by instead of calling a specific object's function, simply naming the main function inside of the objects themsevles "main function" so that in the lever I could simply call someObject.mainfunction().

I also managed to get the doors to work, despite them working in a very primitive way because they use Translate as opposed to AddForce which would be much smoother. 

I also tested a concept of having a fire trap that shoots fire balls, and is currently tested by using a lever but was inteded for use with a pressure plate. This would simply require a pressure plate object that would be a similar appearance to the ground with a trigger collider that detects the player and calls the fire trap's main function upon interaction.

I'm handing off the prototype to Selena. Other goals were to get the pathfinding and Monster AI implemented
