main = do
    print("5 /= 3 = " ++ show (5/=3))
    print("5>1 && 10>2 = " ++ show (5>1 && 10>2))
    print("5>1 && 10>12 = " ++ show (5>1 && 10>12))
    print("not(5>1 && 10>2) = " ++ show (not(5>1 && 10>2)))
    print("5>1 || 10>2 = " ++ show (5>1 || 10>2))