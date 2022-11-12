
numberSign :: (Ord a, Num a) => a -> String
numberSign num =
    if num>0 then "+"
    else if num<0 then "-"
    else "0"

main :: IO ()
main = do
    putStr "Enter number: "
    input <- getLine
    let number = read input :: Integer
    let output = numberSign number :: String 
    putStrLn (output ++ show number)

