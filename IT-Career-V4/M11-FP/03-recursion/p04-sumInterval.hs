sum2 start end =
    if  end<start then 0
    else end + sum2 start (end-1)

main = do
    putStr "Interval start: "
    startInput <- getLine
    putStr "Interval end: "
    endInput <- getLine
    let start = read startInput
    let end = read endInput
    if start>end then putStrLn "Start must be less then end"
    else do
        let result = sum2 start end
        putStrLn  ("Interval [" ++ show start ++"; "++ show end ++"] sum: " ++ show result)

