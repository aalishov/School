fuktica n  a b c index =
    if index >= n
    then a
    else fuktica n (a+b+c) a b (index+1)

tribonacci :: (Ord t1, Num t2, Num t1) => t1 -> t2
tribonacci n = fuktica n 0 0 1 1

main = do
    input <- getLine
    let n = read input :: Integer
    putStrLn (show (tribonacci n))