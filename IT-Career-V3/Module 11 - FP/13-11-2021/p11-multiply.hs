
main = do
    s1 <- getLine 
    s2 <- getLine 
    let num1 = read s1 :: Int
    let num2 = read s2 :: Int 
    let result = num1*num2
    print (show result)
