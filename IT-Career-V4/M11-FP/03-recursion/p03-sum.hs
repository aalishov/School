suma :: (Ord t, Num t) => t -> t
suma n = 
    if n <= 0 then 0
      else n + suma (n-1)
      
main :: IO ()
main = do
    putStr "Enter number: "
    input <- getLine
    let number = read input :: Integer
    let result = suma number
    putStrLn ("Result: " ++ show result)
