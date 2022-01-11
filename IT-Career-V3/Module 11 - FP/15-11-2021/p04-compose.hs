compose f g x = f (g x)
add1 x = x + 1
mult2 x = 2 * x


main = do
    print (show(compose add1 mult2 10))