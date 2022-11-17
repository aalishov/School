multMax :: (Num a, Ord a) => a -> a -> a -> a
multMax a b x = max a b * x

main :: IO ()
main = do
    putStr "Enter a: "
    input <- getLine
    let a = read input :: Integer
    putStr  "Enter b: "
    input <- getLine
    let b = read input :: Integer
    putStr  "Enter x: "
    input <- getLine
    let x = read input :: Integer
    putStrLn ("Result: " ++ show (multMax a b 5))
