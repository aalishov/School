path = "text1.txt"

main :: IO ()
main = do
    writeFile path "Write new text!"