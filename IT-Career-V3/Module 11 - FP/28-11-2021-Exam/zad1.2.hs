factorial n = findFactorial n 1 1
findFactorial n initialValue index =
    if index > n
    then initialValue
    else findFactorial n (initialValue * index) (index + 1)

fibonacci n = findFibonacci n 1 0 1

findFibonacci n initialValue prevValue index =
    if index >= n
    then initialValue
    else findFibonacci n (initialValue + prevValue) initialValue (index + 1)

main = do
    n1 <- getLine
    let fib = fibonacci (read n1)
    n2 <- getLine
    let fac = factorial (read n2)
    let result = max fib fac
    print (show result)
    