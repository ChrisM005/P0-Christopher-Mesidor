#! /usr/bin/bash

#Part 1 - Odd Vs Even
echo "Enter a number: "
read num

i=$(( num % 2 ))
if [[ $i != 0 ]]
then
    echo "ODD NUMBER"
else
    echo "EVEN NUMBER"
fi

#Part 2 - Grades
echo "Enter Your numerical Grade: "
read grade

if [ $grade -gt 70 ]
then
    echo "You got an 'A'! :D"
elif [ $grade -ge 61 ] && [ $grade -le 70 ]
then
    echo "You got a 'B'!"
elif [ $grade -ge 51 ] && [ $grade -le 60 ]
then
    echo "You got a 'C'."    
elif [ $grade -ge 41 ] && [ $grade -le 50 ]
then
    echo "You got a 'D'."    
else
    echo "You got an 'F'. :("
fi