square :: Num a => a -> a
square x = x * x

sumNum :: Num a => a -> a -> a
sumNum a b = a + b

multMax :: (Num a, Ord a) => a -> a -> a -> a
multMax a b x = max a b * x

main :: IO ()
main = do
    print (show  (multMax 5 2 10))