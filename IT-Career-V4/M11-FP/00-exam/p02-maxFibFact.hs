fib :: (Eq t, Num t, Num a) => t -> a
fib 0 = 1
fib 1 = 1
fib n = fib (n-1) + fib (n-2)

fact :: (Eq t, Num t) => t -> t
fact n = 
    if n == 0 then 1 
    else n * fact(n-1)

main :: IO ()
main = do
    inputFB <-getLine
    inputFC <-getLine
    let fb = read inputFB :: Integer
    let fc = read inputFC :: Integer
    print (max (fib fb) (fact fc))