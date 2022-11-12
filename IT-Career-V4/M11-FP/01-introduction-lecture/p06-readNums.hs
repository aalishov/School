main = do
    putStr "Enter number: "
    input <- getLine
    let number = read  input :: Integer
    let number2 = number*10
    putStrLn ("Your number: " ++ show number)
    putStrLn ("New number: " ++ show number2)

main2 = do
    putStr "Enter number: "
    input <- getLine
    let number = read  input :: Double
    let number2 = number*10
    putStrLn ("Your number: " ++ show number)
    putStrLn ("New number: " ++ show number2)