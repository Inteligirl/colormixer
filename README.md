# C# Color Mixer application

## Program Requirements
The colors red, blue, and yellow are known as the primary colors because they cannot be made by mixing other colors.  When you mix two primary colors, you get a secondary color, as shown here:

when you mix red and blue, you get purple.
when you mix red and yellow, you get orange.
when you mix blue and yellow, you get green.
Create a C# application that lets the user select two primary colors from two different sets of Radio buttons as shown on page 264 in your textbook.  The form should also have a Mix button.  When the user clicks the Mix button, the form's background should change to the color that you get when you mix the two selected primary colors.  

Note:  if the user picks the same color from both sets of Radio buttons, set the form's background to that color.

## Thoughts
This was a pretty straigt forward project for me. The purpose was to incorporate if and else if statements. My original plan was to have on click the users selection save into a variable. Then I would have the clicked event of the mix button evaluate what was stored in the variables and through a series of if, else if statements determine the background color of the application. However the more I looked at this program the more I realize that this could be done much simpler. I combined conditions on the statemnts that check for the same color combination but reversed depending on which groupbox the color was selected from. Such as, red from the first group and blue from the second group would mix to purple. Similarly, blue from the first group and red from the second group would also mix to purple. 

![alt text](https://github.com/Inteligirl/colormixer/blob/master/color.png "Color Mixer")
