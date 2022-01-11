pow2 :: (Eq t, Num t, Num p) => t -> p
pow2 n =
    if n == 0
        then 1
    else 2 * pow2 (n - 1)

main = do
    print (show (pow2 10))