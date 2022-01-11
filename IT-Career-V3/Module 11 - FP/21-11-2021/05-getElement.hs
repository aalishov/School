nThElement list n = nThElementLoop list (length list) n 0

nThElementLoop list listLength n index =
    if n >= listLength || n < 0
    then error "Index outside bounds of array"
    else if index == n
         then (head list)
         else nThElementLoop (tail list) listLength n (index + 1)
