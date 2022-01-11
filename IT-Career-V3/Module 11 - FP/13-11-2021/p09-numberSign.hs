sign a =
    if a>0
        then show a ++ " is positive"
    else if a<0
        then (show a ++ " is negative")
    else "It's zero"

main = do
    putStrLn (sign 5)
    putStrLn (sign (-5))
    putStrLn (sign 0)