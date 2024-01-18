module Homework3 where

putIntoList :: a -> [a]
putIntoList a = [a]

interval :: Int -> Int -> [Int]
interval a b
    | a > b = []
    | otherwise = [a..b]

headTail :: [a] -> (a, [a])
headTail (x:xs) = (x, xs)

doubleHead :: [a] -> [b] -> (a,b)
doubleHead (x:_) (y:_) = (x,y)

hasZero :: [Int] -> Bool
hasZero [] = False
hasZero (x:xs)
    | x == 0 = True
    | otherwise = hasZero xs

hasEmpty :: [[a]] -> Bool
hasEmpty [] = False
hasEmpty [[]] = True
hasEmpty ([]:xs) = True
hasEmpty (_:xs) = hasEmpty xs

doubleAll :: [Int] -> [Int]
doubleAll [] = []
doubleAll (x:xs) = (x*2) : doubleAll xs

--this is fine
isLonger :: [a] -> [b] -> Bool
isLonger [] [] = False
isLonger a [] = True
isLonger [] b = False
isLonger (x:xs) (y:ys) = isLonger xs ys

evens :: [Int] -> [Int]
evens [] = []
evens (x:xs)
    | mod x 2 == 0 = x : evens xs
    | otherwise = evens xs

sumFirst :: Int -> [Int] -> Int
sumFirst 0 _ = 0
sumFirst n (x:xs) = x + (sumFirst (n-1) xs)

everySecond :: [a] -> [a]
everySecond [] = []
everySecond [a] = []
everySecond (x:y:xs) = y : everySecond xs


--ps: mindenépp próbálkozok még majd a hard mode-dal
