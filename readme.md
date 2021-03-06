# Survey Squabble
© Evan S., 2020

A video demo and explanation can be found [here](https://youtu.be/P2YqA_gB2_I).

# Info
I am new to github and do not know how to change the commit message
for unedited code, but all of it is commented with explanations for
why I chose to do things in specific ways. 

# Overview 
Survey Squabble is an app designed for people to host a competitive 
guessing game based on the most popular answers given to individual, 
personality-based questions from surveys, in a way similar to Family 
Feud. It comes with no built-in questions, because I wanted to 
prioritize the support of custom questions so that people aren't limited 
to what I was able to find on google, and can make their own if desired.

# How to Set Up a Question & Play 
Press the "New Question" button to reset the form, type the Question into 
the Question field, and type each Answer & Score into their respective 
fields. Afterwards, the Host tells the Players how many Answers are on 
the board (Show Number Of Answers button), reads the Question out loud 
(Show Question Button), and Checks the Visible box when each Answer has 
been correctly guessed (or is close enough). If the team guesses an 
Answer incorrectly, they are given a Strike, and on three (3) Strikes, 
that Team is no longer allowed to guess Answers. At the end of a round, 
the Host updates the Scores.

#### For more information on what each of these individual buttons do, please refer to "Buttons". For more on Scores, please refer to "Scores".

# Windows 
On Startup, Survey Squabble opens two (2) windows: the Game Window & 
the Control Dock. This means that the game works best with any setup that 
allows the Host to see a screen different from the one that the Players 
will see, such as a computer connected to a projector, or discord's 
window sharing functionality.

### Game Window  
The Game Window is what the Players are intended to see. It shows the 
Team Names & Scores, the Question, the Answers, their Scores & the 
Number of Strikes. The Host should not be interacting with this window 
at all, it is specifically for viewing purposes. Please note that 
resizing of the Game Window is not supported at this time.

### Control Dock 
The Control Dock is only meant to be seen by the Host. It has the input 
fields for the Question, each individual Answer, and the Team Names & 
Scores. For more information about the Buttons, see section 3. The Tab 
button has been programmed to work correctly, so you can simply hit Tab 
from the Question field, and it will take you through each Answer and its 
Score sequentially.

# Buttons  
This section will describe all of the buttons on the Control Dock and 
their functions.

### New Question 
This button gives the players a blank screen to look at, and empties all 
of the fields in the Control Dock (except for Team Names & Scores) to 
make it easier to make a new question. It also clears off the information 
from the Game Window. Team Names & Scores are unaffected on there as well.

### Show Number of Answers 
This button will display a number on the Game Window for every Answer 
that still needs to be guessed by either Team. These numbers will be 
replaced by the answer when the Is It Visible button is checked. 
It is intended to be pressed before the Question is shown.

### Show Question 
This button will display the Question on the Game Window. It is intended 
to be pressed after the Question is said by the host, so reading speed 
is not a factor in answer speed.

### Update Scores And Team Names 
This button will update the Scores and Names of each Team. Intended to be 
pressed at the start of the game after each Team has been named, and 
after each round when the Host has calculated the score. Please note that 
the score is not calculated automatically by the game, please see section 
5 for more information.

### Strikes 
For each Answer not on the board, the Team shall receive a Strike. These 
are given by simply clicking the Check Box, and they update immediately 
on the Game Window.  

### Is It Visible? 
These Check Boxes are used to display individual answers. If you uncheck 
them, nothing changes, but re-checking them will update the Answer/Score 
to what is in the fields if you've changed them.


# Scores 
The scores are not calculated automatically, so the user needs to keep 
track of that themself. This has the benefit of allowing users to type 
any value they please in any of the score fields, including joke values
and/or the reduction of points.
