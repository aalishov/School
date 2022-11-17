pass3 :: Num t1 => (t1 -> t2) -> t2
pass3 f = f 3
add1 :: Num a => a -> a
add1 x = x+1

main :: IO ()
main = do
    putStrLn ("Result " ++ show (pass3 add1))