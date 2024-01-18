module SessionTwo(find, add, prime_magic, compress,decompress) where
import Data.List (filter, group)

type Room = String
type Air = Int
type Fire = Integer
type MagicLevel = Int

find :: [Room] -> [Room]
find [] = []
find (x:xs)
    | x == "2.620" = (x:xs)
    | otherwise = find xs

{-
 alternatively

find :: [Room] -> [Room]
find [a] = [a]
find _ = []

 -}

add :: (Integral magic1, Integral magic2, Num magic3) => magic1 -> magic2 -> magic3
add a b = fromIntegral(a) + fromIntegral(b)

isPrime :: Int -> Bool
isPrime n
    | n <= 1 = False
    | n == 2 = True
    | mod n 2 == 0 = False
    | otherwise = helper n (n-1)
    where
        helper :: Int -> Int -> Bool
        helper _ 1 = True 
        helper a b
            | mod a b == 0 = False
            | otherwise = helper a (b-1)

myFilter :: (a -> Bool) -> [a] -> [a]
myFilter _ [] = []
myFilter fn (x:xs)
    | fn x = x : myFilter fn xs
    | otherwise = myFilter fn xs

prime_magic :: MagicLevel -> MagicLevel -> [MagicLevel]
prime_magic 0 0 = []
prime_magic _ 0 = []
prime_magic 1 1 = []
prime_magic a b = myFilter isPrime [a..b]



compress :: (Eq magic) => [magic] -> [(magic, MagicLevel)]
compress [] = []
compress (x:xs) = helper xs x 1
  where
    helper :: (Eq magic) => [magic] -> magic -> MagicLevel -> [(magic, MagicLevel)]
    helper [] curr c = [(curr, c)]
    helper (y:ys) curr c
      | y == curr = helper ys curr(c + 1)
      | otherwise = (curr, c) : helper ys y 1


decompress :: Eq magic => [(magic, MagicLevel)] -> [magic]
decompress [] = []
decompress (x:xs) = helper x  ++ decompress xs
    where
--tbh el kellett volna olvasni a feladatot megint
      helper :: (a,Int) -> [a]
      helper (_,0) = []
      helper (char, c) = char : helper (char, (c-1)) 
