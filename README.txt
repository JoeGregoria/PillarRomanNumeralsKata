The Romans wrote their numbers using letters; specifically the letters 'I' meaning '1', 'V' meaning '5', 'X' meaning '10', 
'L' meaning '50', 'C' meaning '100', 'D' meaning '500', and 'M' meaning '1000'. There were certain rules that the numerals followed which should be observed.

The symbols 'I', 'X', 'C', and 'M' can be repeated at most 3 times in a row. The symbols 'V', 'L', and 'D' can never be repeated. 
The '1' symbols ('I', 'X', and 'C') can only be subtracted from the 2 next highest values ('IV' and 'IX', 'XL' and 'XC', 'CD' and 'CM'). 
Only one subtraction can be made per numeral ('XC' is allowed, 'XXC' is not). The '5' symbols ('V', 'L', and 'D') can never be subtracted.

Feature 1 - Converting Arabic to Roman
We would like to be able to convert Arabic numbers into their Roman numeral equivalents. 
We just need some kind of program that can accept a numeric input and output the Roman numeral for the input number.

Convert Arabic Number to Roman Numeral
As a game developer
I want to be able to convert a number to a numeral
So that I can label my game releases using Roman numerals
Given I have started the converter
When I enter $number
Then $numeral is returned

Number	Numeral
1	I
3	III
9	IX
1066	MLXVI
1989	MCMLXXXIX

Feature 2 - Converting Roman to Arabic
The change from the Arabic numbering system to using Roman numerals has gone really well, all things considered. 
There is a slight issue in that sales of the latest games have dropped off, and when questioned people have said it's
because they no longer know what the latest version is, as there's no easy to read number. To remedy this, 
we are going to install Roman numeral to Arabic number converters everywhere we sell games, so people can work out which is the latest game.

As a marketing manager
I want customers to be able to convert numerals to numbers
So that they can buy the latest version of the game
Given I have started the converter
When I enter $numeral
Then $number is returned

Numeral	Number
I	1
III	3
IX	9
MLXVI	1066
MCMLXXXIX	1989