sumNum s n =
    if n == 0
        then 0
    else n + sumNum s (n-1)

sumN n = 
    sumNum 0 n