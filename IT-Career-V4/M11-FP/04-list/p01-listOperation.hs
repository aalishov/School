import Text.XHtml (input)
x = [10..15] --[10,11,12,13,14,15] 
x2 :: [Integer]
x2 = [-5..5]  --[-5,-4,-3,-2,-1,0,1,2,3,4,5]

h = head x --10
t  = tail x --[11,12,13,14,15]
n = head (tail x) --11

l = last x --15

i = init x --[10,11,12,13,14]

isTrue = 5 `elem`  x --False

isTrue2 = 13 `elem`  x --True

ev = filter (\x -> x `mod` 2 == 0) [1..20] --[2,4,6,8,10,12,14,16,18,20]

ev2 :: [Integer]
ev2 = filter even [1..20] --[2,4,6,8,10,12,14,16,18,20]

od1 = filter odd [1..20] --[1,3,5,7,9,11,13,15,17,19]

z = zip [1,3,5] [2,4,6] -- [(1,2),(3,4),(5,6)]

zSum = zipWith (+) [1,3,5] [2,4,6] --[3,7,11]

zProduct = zipWith (*) [1,3,5] [2,4,6] --[2,12,30]

listAbs = map abs x2 --[5,4,3,2,1,0,1,2,3,4,5]

list2 = map (*2) x2 --[-10,-8,-6,-4,-2,0,2,4,6,8,10]

list3 = map (\x -> x * x) x2 --[25,16,9,4,1,0,1,4,9,16,25]


doubleList :: Num a => [a] -> [a]
doubleList list = 
    if null list
    then []
    else 2 * head list : doubleList (tail list)

len = length [-10..10] --21

createList = do
    inputStart <- getLine
    inputEnd <- getLine
    let start = read inputStart ::Integer
    let end = read inputEnd ::Integer
    print  (head [start..end])
    print  (tail [start..end])
