import Text.Printf

main = do
   s1 <- getLine 
   let r = read s1 :: Double
   let result = pi *r*r
   printf "%.4g" result

