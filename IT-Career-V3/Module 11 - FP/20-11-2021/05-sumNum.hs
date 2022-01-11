
sumNumbersLoop n sum index = 
    if index > n
    then sum
    else (sum + index) + sumNumbersLoop n sum (index + 1)


sumNumbers n = 
    sumNumbersLoop n 0 1