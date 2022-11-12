
number5Or6 :: (Eq a, Num a) => a -> String
number5Or6 num = case num of
    5 -> "number is 5"
    6 ->  "number is 6"
    _ -> "It's neither 5 nor 6 :("

main :: IO ()
main = do
    putStr "Enter number: "
    input <- getLine
    let result = read input :: Integer
    putStrLn (number5Or6 result)