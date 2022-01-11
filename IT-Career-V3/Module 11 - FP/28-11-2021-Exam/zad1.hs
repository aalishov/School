findFactorial n initialValue index =
    if index > n
        then initialValue
    else findFactorial n (initialValue * index) (index + 1)
factorial n = findFactorial n 1 1
fibonacci n =
    if n == 1 || n == 2
        then 1
    else fibonacci (n - 1) + fibonacci (n - 2)

main = do
    number1 <- getLine
    let fb = fibonacci (read number1)
    number2 <- getLine
    let fc = factorial (read number2)
    let result = max fc fb
    print (show result)