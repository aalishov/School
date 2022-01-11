topLeftTriangle c n = [replicate i c | i <- [n, n-1 .. 1]]

main = do
  size <- getLine
  symbol <- getLine
  putStr $ unlines $ topLeftTriangle (head symbol)  (read size :: Int)