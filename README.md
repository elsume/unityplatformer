# unityplatformer
rize gdm project

## description
this project is supposed to emulate a platformer game. it also acts as practice on using unity for 2d games.

## status log
**03/01/26**

first day working on the project. my first time working on a game with multiple scenes. was relatively easy to create the code for this assignment - the resources were very thorough and detailed. had issues with making buttons work (i had simply copy and pasted the ui element, but neglected to copy over the events system element as well). another bug i found was the fact that i guess since the sides of the platforms were considered ground as well the player sprite would stick to it if it collided into it mid-jump. this would interrupt the jump and also make movement awkward. additionally, the enemies' movements would sometimes bug and get stuck on one side for a long time before reversing its direction. i do not know why that is - i'm assuming maybe something was identified as being in the way or maybe the ground it was on was not long enough (though i doubt that is the reason). in the end, though, everything was fun to do and the end result was also very satisfying to play.



## instructions
* clone the repository:

`git clone https://github.com/elsume/unityplatformer.git`
* launch unity hub
* click "Add" and select the cloned repository folder
* open with Unity 2022.3.62f3 LTS
* open the main scene
* navigate to Assets/Scenes/mainMenu.unity
* click the play button in unity to start the game
