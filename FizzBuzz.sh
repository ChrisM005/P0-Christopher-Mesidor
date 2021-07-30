#! /usr/bin/bash

num=1
while [ $num -le 20 ]
do
i=$((num % 3))
j=$((num % 5))
if [ "$i" -eq 0 ] && [ "$j" -ne 0 ]
then
    echo "Fizz"
elif [ "$i" -ne 0 ] && [ "$j" -eq 0 ]
then
    echo "Buzz"
elif [ "$i" -eq 0 ] && [ "$j" -eq 0 ]
then
    echo "FizzBuzz"
else
    echo ' '
fi
num=$((num + 1))
done