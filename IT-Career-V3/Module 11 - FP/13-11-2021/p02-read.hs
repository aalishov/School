main :: IO ()
main = do
    putStr "Enter your name: "
    name <- getLine 
    putStrLn ("Hello " ++ name ++ "!")
    