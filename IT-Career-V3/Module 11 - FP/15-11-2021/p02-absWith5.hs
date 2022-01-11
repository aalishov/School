import System.IO (putStr)
plusFive n = abs n + 5

main = do
    putStr "Enter number: "
    s1 <- getLine 
    let num = read s1 :: Double
    print (show (plusFive num))
