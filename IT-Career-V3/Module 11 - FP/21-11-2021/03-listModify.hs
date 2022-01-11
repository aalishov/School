doubleList list = 
    if null list
    then []
    else (2 * (head list) : (doubleList (tail list)))


main = do
    let x = [1,2,3,4]
    print (show (doubleList x))
    print (show (doubleList x))