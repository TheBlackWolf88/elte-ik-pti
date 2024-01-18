module Lesson4 where
import Data.Char(isUpper, toLower)
import Data.List(nub)

guardian :: Int -> Int
guardian a
    | a < 5 = 5
    | otherwise = a

elem' :: Eq a => a -> [a] -> Bool
elem' _ [] = False
elem' n (x:xs)
    | n == x = True
    | otherwise = elem' n xs

take' :: Int -> [a] -> [a]
take' 0 _ = []
take' _ [] = []
take' a (x:xs) = x : take' (a-1) xs

drop' :: Int -> [a] -> [a]
drop' 0 a = a
drop' _ [] = []
drop' a (x:xs) = drop' (a-1) xs

even_numbers :: Int -> Int -> [Int]
even_numbers a b = [ x | x <- [a..b], mod x 2 == 0]

square_numbers :: Int -> Int -> [Int]
square_numbers a b = [ x*x | x <- [a..b]]

isPrime :: Int -> Bool
isPrime 1 = False
isPrime n = [x | x <- [2..(n-1)], mod n x == 0] == []

primes :: Int -> Int -> [Int]
primes a b = [x | x <- [a..b], isPrime x]

camelToWords :: String -> String
camelToWords [] = []
camelToWords (x:xs)
    | isUpper x = " " ++ [ (toLower x)] ++ camelToWords xs
    | otherwise = x : camelToWords xs

isSorted :: Ord a => [a] -> Bool
isSorted [] = True
isSorted [_] = True
isSorted (x:y:xs)
    | x < head xs = isSorted xs
    | otherwise = False

uniques :: Eq a => [a] -> [a]
uniques [] = []
uniques (x:xs)
    | elem x xs = uniques xs
    | otherwise = x : uniques xs

quicksort :: Ord a => [a] -> [a]
quicksort [] = []
quicksort [a] = [a]
quicksort (x:xs) = quicksort [y | y <- xs, y < x] ++ [x] ++ quicksort [y | y <- xs, y >= x]
