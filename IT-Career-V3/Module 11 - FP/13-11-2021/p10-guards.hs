simpleFunction a 
    | a == 5 = "It's five :)"
    | a == 6 = "It's six :)"
    | otherwise = "It's neither 5 nor 6 :("

main = do
    putStrLn (simpleFunction 10)
    putStrLn (simpleFunction 5)
    putStrLn (simpleFunction 6)