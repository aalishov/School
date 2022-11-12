
numberSign :: (Ord a, Num a) => a -> String
numberSign num
    | num>0 = "positive -> "
    | num<0 = "negative -> "
    | otherwise = "zero -> "

main :: IO ()
main = do
    putStr "Enter number: "
    input <- getLine
    let number = read input :: Integer
    let output = numberSign number :: String 
    putStrLn (output ++ show number)