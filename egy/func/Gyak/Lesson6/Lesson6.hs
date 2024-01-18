module Lesson6 where

-- / <- lambda operator
--
-- takeWhile 
--
-- $ "pipe" operator
-- . f kor g
import Data.Char

squared x = x^2

megmeg x = x+x

hasFever :: Int -> Bool
hasFever t = (fromIntegral(t-32) / 1.8)> 38

positiveProduct :: (Num a, Ord a) => [a] -> a
positiveProduct [] = 1
positiveProduct (x:xs)
    | x > 0 = x * positiveProduct xs
    | otherwise = positiveProduct xs

positiveProduct2 :: (Num a, Ord a) => [a] -> a
positiveProduct2 a = product [ x | x <- a, x>0]

mightyGale :: [(String, Int, Int, Int)] -> String
mightyGale[] = ""
mightyGale ((n, t, s, d):xs)
    | s > 110 = n
    | otherwise = mightyGale xs

mightyGale2 :: [(String, Int, Int, Int)] -> String
mightyGale2 arr
    | null station = ""
    | otherwise = head station
    where 
        station = [name | (name, _, speed, _) <- m, speed > 110 ]


cipher :: String -> String
cipher (x:y:z:xs)
    | isLetter x && isLetter y && isDigit z = [x,y]
    | otherwise = cipher (y:z:xs)
cipher _ = ""


pizza :: [(String, Int)] -> Int
pizza [] = 500
pizza ((_, ar):xs) = ar + pizza xs

pizza2 :: [(String, Int)] -> Int
pizza2 arr = sum [ ar | (_,ar) <- ar] + 500

splitEvenOdd' :: [Int] -> ([Int], [Int])
splitEvenOdd' l = (evens, odds)
    where
        evens = [ x | x <- l, even x]
        odds = [ x | x <- l, odd x]
