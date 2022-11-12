filePath :: String
filePath = "./file1.txt"

main :: IO ()
main = do
    writeFile filePath "Some text asdasdasdasd"

main2 :: IO ()
main2 = do
    appendFile filePath "Some text append asdasdasdasd\n"