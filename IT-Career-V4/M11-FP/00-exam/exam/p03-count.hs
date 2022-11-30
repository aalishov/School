main = do
    text <- getLine
    putStrLn $ "" ++ show (countLower text) ++ " " ++ show (countUpper text) ++ " " ++ show (countOther text) 
    
countLower :: String -> Int
countLower = length . filter (`elem` ['a'..'z'])

countUpper :: String -> Int
countUpper = length . filter (`elem` ['A'..'Z'])

countOther :: String -> Int
countOther = length . filter (`notElem` ['a'..'z'] ) . filter (`notElem` ['A'..'Z'])