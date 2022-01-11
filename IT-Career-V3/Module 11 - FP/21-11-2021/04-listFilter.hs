removeOdd nums =
    if null nums
    then []
    else 
        if (mod (head nums) 2 ) == 0
        then (head nums) : (removeOdd (tail nums))
        else removeOdd (tail nums)

x = [1,2,3,4,5,6,9,12,15]

main = do
    print (show (removeOdd x))
