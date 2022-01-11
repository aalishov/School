import Data.ByteString.Lazy ()
x = [1, 2, 3, 4]

main = do
    print (show (length x)) --4
    print (show (x !! 2)) --3 , get element by index
    print (show x) --"[1, 2, 3, 4]""
    print (show (head x)) --"1"
    print (show (tail x)) --"[2,3,4]"
    print (show (init x)) --"[1,2,3]"
    print (show (last x)) --"4"
    print (show (reverse x)) --"[4,3,2,1]"
    print (show (4 `elem` x))  --"True"
    print (show (7 `elem` x))  --"False"
    print (show (maximum x))  --"4"
    print (show (minimum x))  --"1"
    print (show (sum x))  --"10"
    print (show (product x))  --"24"