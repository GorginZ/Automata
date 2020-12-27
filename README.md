# Automaton



A simple console app for 1D cellular automaton simulaiton.

Starting with elementary Wolfram rules.

This is a nice fun way to use some maths and do some C# practice over my holidays.

Generations class takes a starting state cell neighbourhood int array of 0s and 1s and applies the rules and creates the sucessive generations. 

The rules can be described algebraically or in boolean form. I have made a IRules interface which has a member function that returns a binary like state for the next cell in the generation based on the boolean expression of the rule and have been adding unit tests for each rule and then writing the rule as a new class that implements IRules.

 

References

http://atlas.wolfram.com/01/01/

http://psoup.math.wisc.edu/mcell/rullex_1dbi.html