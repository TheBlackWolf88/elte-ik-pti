module Lesson8 where 
import Data.List


until' :: (a -> Bool) -> (a -> a) -> a -> a
until' p f a
    | p a = a
    | otherwise = until p f (f a)

subsequences' :: [a] -> [[a]]
subsequences' [] = [[]]
subsequences' (x:xs) = subsequences' xs ++  map (x:) (subsequences' xs)

subListWithLength :: Int -> [a] -> [[a]]
subListWithLength len l = take ( length l - len + 1 ) $ map (take len) (tails l)

repeated' :: Ord a => [a] -> [a]
repeated' lst = nub $ lst \\ nub lst

concatMap' :: (a -> [b]) -> [a] -> [b]
concatMap' f = concat . map f

firstLetters :: String -> String
firstLetters name = concatMap (\x -> [head x]) (words name)

monogram :: String -> String
monogram nm = concatMap (\x -> [head x, '.']) (words nm)

fog :: (b-> c) -> (a->b) -> (a->c)
fog f g x = f $ g x

foldr' :: (a->b->b) -> b -> [a] -> b
foldr' _ acc [] = acc
foldr' f acc (x:xs) = f x (foldr' f acc xs) 

foldl'' :: (b->a->b) -> b -> [a] -> b
foldl'' _ acc [] = acc
foldl'' f acc (x:xs) = foldl'' f (f acc x) xs

product' :: Num a => [a] -> a
product' = foldl (*) 1

and' :: [Bool] -> Bool
and' = foldl (&&) True

or' :: [Bool] -> Bool
or' = foldl (||) False

isort :: Ord a => [a] -> [a]
isort = foldl (insert) []
    where
        insert [] x = [x]
        insert (y:ys) x
            | x <= y = x : y : ys
            | otherwise = y : insert ys x


foldl1'' :: (a->a->a) -> [a] -> a
foldl1'' f (x:xs) = foldl'' f x xs

fromBin :: [Int] -> Integer
fromBin lst = foldl (\acc x -> 2 * acc + fromIntegral x) 0
