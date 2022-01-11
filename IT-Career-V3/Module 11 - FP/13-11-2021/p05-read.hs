path = "text.txt"

main :: IO ()
main = do
    file <- readFile path
    putStrLn file