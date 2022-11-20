repeatString :: (Eq t, Num t) => [Char] -> t -> [Char]
repeatString str n =
    if n==0 then ""
    else str ++ repeatString str (n-1)

printTriangle :: (Eq t, Num t) => [Char] -> [Char] -> t -> [Char]
printTriangle result c count =
    if count == 1 then c
    else
      result ++ repeatString c count ++  "\n" ++  printTriangle result c (count-1) 

main :: IO ()
main = do
    putStrLn  (printTriangle "" "!" 10)