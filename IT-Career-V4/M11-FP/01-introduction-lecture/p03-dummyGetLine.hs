dummyGetLine :: IO String
dummyGetLine =
    return  "I'm not really doing anything"

main :: IO ()
main = do
    line <- dummyGetLine
    putStrLn line