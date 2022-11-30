findTribonacci n  initialValue prevValue prevprevValue index =
    if index >= n
    then initialValue
    else findTribonacci n (initialValue+prevValue+prevprevValue) initialValue prevValue (index+1)

tribonacci n = findTribonacci n 0 0 1 1

main = do
    input <- getLine
    let n = read input :: Integer
    putStrLn (show (tribonacci n))