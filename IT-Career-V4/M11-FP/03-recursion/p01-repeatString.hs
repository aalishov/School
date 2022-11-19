repeatString :: (Eq t, Num t) => [Char] -> t -> [Char]
repeatString str n =
    if n==0 then ""
    else str ++ repeatString str (n-1)

main :: IO ()
main = do
    putStr "Enter some text: "
    inputString <- getLine
    putStr "Enter count: "
    inputCount <- getLine
    let count = read inputCount ::Integer
    let result = repeatString inputString count
    putStrLn result


