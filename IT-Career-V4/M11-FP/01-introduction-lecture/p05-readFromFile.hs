filePath :: String
filePath = "./file1.txt"

main :: IO ()
main = do
    line <- readFile filePath
    putStrLn line
