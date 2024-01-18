import Data.Char
import Data.List

nub' :: Eq a => [a] -> [a]
nub' a =  reverse $ helper a []
    where
        helper [] b = b 
        helper (x:xs) done
            | elem x done = helper xs done
            | otherwise = helper xs (x:done)
            
map' :: (a -> b) -> [a] -> [b]
map' f a = [ f x | x <- a ]

compose :: (b -> c) -> (a -> b) -> a -> c
compose f1 f2 a = f1 $ f2 a

filter' :: (a -> Bool) -> [a] -> [a]
filter' f a = [ x | x <- a, f x ]

zipWith' :: (a -> b -> c) -> [a] -> [b] -> [c]
zipWith' f a b = [ f x y | (x,y) <- listsToTuple a b ]
    where
        listsToTuple [] _ = []
        listsToTuple _ [] = []
        listsToTuple (x:xs) (y:ys) = (x,y) : listsToTuple xs ys

iterate'' :: (a -> a) -> a -> [a]
iterate'' f a = a : iterate'' f (f a)

takeWhile' :: (a -> Bool) -> [a] -> [a]
takeWhile' f a = reverse $ helper f a []
    where
        helper _ [] done = done
        helper f (x:xs) done
            | not $ f x  = done
            | otherwise = helper f xs (x : done)

dropWhile' :: (a -> Bool) -> [a] -> [a]
dropWhile' f a@(x:xs)
    | f x  = dropWhile' f xs
    | otherwise = a


tripletToList :: (a,a,a) -> [a]
tripletToList (a,b,c) = [a,b,c]

all' :: (a -> Bool) -> [a] -> Bool
all' f [] = True
all' f (x:xs)
    | f x = all' f xs
    | otherwise = False

any' :: (a -> Bool) -> [a] -> Bool
any' f [] = False
any' f (x:xs) = f x || any' f xs

diffCube :: Num a => a -> a -> a
diffCube a b = (a-b)^3

middle :: [a] -> [a]
middle a = reverse $ tail $ reverse $ tail a

toUpperSecondAndThird :: String -> String
toUpperSecondAndThird a = helper 0 a
    where
        helper _ [] = []
        helper n (x:xs)
            | n == 1 || n == 2 = toUpper x : helper (n+1) xs
            | otherwise = x : helper (n+1) xs

headAndBeforeLast :: [a] -> [a]
headAndBeforeLast (x:xs) = x : [ reverse xs !! 1 ]

average :: [Double] -> Double
average a = sum a / genericLength a 

removeDuplicateSpaces :: String -> String
removeDuplicateSpaces  "" = ""
removeDuplicateSpaces [a] = [a]
removeDuplicateSpaces (x:y:ys)
    | x == ' ' && y == ' ' = removeDuplicateSpaces (y : ys)
    | otherwise = x : removeDuplicateSpaces (y:ys)


doubleElements :: [a] -> [a]
doubleElements [] = []
doubleElements (x:xs) = x : x : doubleElements xs
