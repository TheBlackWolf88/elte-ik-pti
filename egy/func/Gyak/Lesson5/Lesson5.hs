module Lesson5 where

pairity :: [(Int, Bool)]
pairity = zip [1..] [ even x | x <- [1..]]

pythagoreanTriple :: Int -> [(Int,Int,Int)]
pythagoreanTriple n = [(a,b,c) | a <- [1..n], b <- [a..n], c <- [a..n], a^2 + b^2 == c^2 ]

reverse' :: [a] -> [a]
reverse' [] = []
reverse' (x:xs) = reverse' xs ++ [x]

reverse'' :: [a] -> [a]
reverse'' = rev []
    where
        rev :: [a] -> [a] -> [a]
        rev done [] = done
        rev done (x:xs) = rev (x : done) xs

nub' :: Eq a => [a] -> [a]
nub' xs = (nub'' [] xs) where
    nub'' :: Eq a =>[a] -> [a] -> [a]
    nub'' done [] = done
    nub'' done (x:xs)
        | elem x done = nub'' done xs
        | otherwise = nub'' (done ++ [x]) xs


minimum' :: Ord a => [a] -> a
minimum' (x:xs) = m x xs where
    m :: Ord a => a -> [a] -> a
    m x [] = x
    m x (y:ys)
        | x > y = m y ys
        | otherwise = m x ys

splitAt':: Int -> [a] -> ([a],[a])
splitAt' n xs = (reverse ys, zs) where
    (ys, zs) = s n ([],xs)
    s :: Int -> ([a],[a]) -> ([a],[a])
    s 0 done = done
    s n done@(xs,[]) = done
    s n (xs, y:ys) = s (n-1) (y:xs, ys)
splitAt'' :: Int -> [a] -> ([a], [a])
splitAt'' n xs = (take n xs, drop n xs)

countString :: String -> String -> Int
countString _ [] = 0
countString a b@(x:y:xs)
    | length a == 1 = length [ x | x <- b , x == head a]
   -- | (x == head a && y == head (tail a)) = 1 + countString a (y:xs)
   -- | otherwise = countString a (y:xs)
   
flip' :: (a->b->c) -> b -> a -> c
flip' f a b = f b a

foldl' :: (b-> a -> b) -> b -> [a] -> b
foldl' _ acc [] = acc
foldl' fn acc (x:xs) = foldl' fn (fn acc x) xs

zipWith' :: (a -> b -> c) -> [a] -> [b] -> [c]
zipWith' _ [] _ = []
zipWith' _ _ [] = []
zipWith' f (x:xs) (y:ys) = (f x y) : zipWith' f xs ys

reverse''' :: [a] -> [a]
reverse''' = foldl (flip(:)) [] 

zipWith3' :: (a -> b -> c -> d) -> [a] -> [b] -> [c] -> [d]
zipWith3' _ [] _ _ = []
zipWith3' _ _ [] _ = []
zipWith3' _ _ _ [] = []
zipWith3' fn (x:xs) (y:ys) (z:zs) = ( fn x y z) : zipWith3' fn xs ys zs
