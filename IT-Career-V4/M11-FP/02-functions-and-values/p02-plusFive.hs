plusFive x = abs x + 5

main = do
    putStr "Enter number: "
    input <- getLine
    let a = read input :: Integer
    putStrLn ("Result: " ++ show (plusFive a))