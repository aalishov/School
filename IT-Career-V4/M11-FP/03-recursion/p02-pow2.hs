pow2Loop :: (Ord t1, Num t2, Num t1) => t1 -> t2 -> t1 -> t2
pow2Loop n x i = 
    if i<n then pow2Loop n (x*2) (i+1)
    else x

pow2 :: (Ord t1, Num t2, Num t1) => t1 -> t2
pow2 n = pow2Loop n 1 0
 
main = do
    putStr "Enter number: "
    input <- getLine
    let number = read input :: Integer
    let result = pow2 number
    putStrLn ("Result: " ++ show result)