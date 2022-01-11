line :: IO String 
line =
    return "Print some text"

main :: IO ()
main = do
    l <- line
    putStrLn l