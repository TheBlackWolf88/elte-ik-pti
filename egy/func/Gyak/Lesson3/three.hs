module Three where

import Prelude hiding (lenght, sum, last, init, minimum, concat, (++), zip)

fact :: Int -> Int
fact 0 = 1
fact n = n * fact (n-1)

fib :: Int -> Int
fib 0 = 1
fib 1 = 1
fib n = fib (n-1) + fib(n-2)

pow :: Int -> Int -> Int
pow _ 0 = 1
pow n k = n * pow n (k-1)

head' :: [a] -> a
head' (x:xs) = x

tail' :: [a] -> [a]
tail' (x:xs) = xs

length' :: [a] -> Int
length' [] = 0
length' (x:xs) = 1 + length' xs

sum :: Num a => [a] -> a
sum [] = 0
sum (x:xs) = x + sum xs

last :: [a] -> a
last [x] = x
last (x:xs) = last xs

init :: [a] -> [a]
init [_] =  []
init (x:xs) = x : init xs

minimum :: Ord a => [a] -> a
minimum [x] = x
minimum (x:xs) = min x (minimum xs)

concat :: [[a]] -> [a]
concat [] = []
concat (x:xs) = x ++ concat xs

(++) :: [a] -> [a] -> [a]
(++) [] [] = []
(++) [] a = a 
(++) a [] = a
(++) (x:xs) b = x : (xs ++ b) 

zip :: [a] -> [b] -> [(a,b)]
zip [] [] = []
zip a [] = []
zip [] a = []
zip (x:xs) (y:ys) = (x,y) : zip xs ys

reverseList :: [a] -> [a]
reverseList [] = []
reverseList (x:xs) = reverseList xs ++ [x]

gcd' :: Integer -> Integer -> Integer
gcd' 0 a = a
gcd' a 0 = a
gcd' a b = gcd' (mod (max a b) (min a b)) (min a b)

recursiveMap :: (a -> b) -> [a] -> [b]
recursiveMap _ [] = []
recursiveMap fn (x:xs) = fn x : recursiveMap fn xs

