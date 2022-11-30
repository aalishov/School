import Data.Char

countLower :: String -> Int
countLower = length . filter (isLower)

countUpper :: String -> Int
countUpper = length . filter (isUpper)

main = do
    input <- getLine
    let upper = countUpper input
    let lower = countLower input
    let sign = length input - (upper + lower)

    putStrLn(show(lower) ++ " " ++ show(upper) ++ " " ++ show(sign))

