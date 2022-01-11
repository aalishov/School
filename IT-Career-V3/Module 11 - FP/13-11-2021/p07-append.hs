path = "text1.txt"

main :: IO ()
main = do
    appendFile path "Add new text!"