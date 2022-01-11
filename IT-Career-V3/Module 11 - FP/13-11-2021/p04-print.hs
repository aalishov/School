name :: String 
name = "John"

age :: Int 
age = 54

main :: IO ()
main = do
    print ("Hello " ++ name ++" you are "++ show age ++ " years old!")
