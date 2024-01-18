import Data.Char

which :: ([Char], [Char], [Char]) -> Char -> Int 
which (a,b,c) ch
    | elem ch a = 1
    | elem ch b = 2
    | elem ch c = 3
    | otherwise = 0

matches :: (Int, Int) -> (Int, Int) -> Bool
matches (_,b) (c,_) = b == c

toUpperCase :: String -> String
toUpperCase [] = []
toUpperCase (x:xs)
    | isLetter x = toUpper x : xs
    | otherwise = x:xs

swap Nothing _ = Nothing
swap (Just _) b = Just b

data Temperature = Daytime Int | Night 

isDaytime (Daytime _) = True
isDaytime _ = False
{-
extremes :: [Temperature] -> (Int,Int)
extremes l = (foldl (\acc x -> getErtekAholDay x acc) (-275), (foldl (\acc x -> getErtekAholEste x acc) 99999999))
    where 
        getErtekAholDay (Daytime a) acc
            | acc >  a = acc
            | otherwise = a
        getErtekAholDay _ acc = acc
        getErtekAholEste (Daytime a) acc
            | acc <  a = acc
            | otherwise = a
        getErtekAholEste _ acc = acc      
-}

data RPS = Rock | Paper | Scissors deriving (Eq)

beats :: RPS->RPS 
beats Paper = Rock
beats Rock = Scissors 
beats Scissors = Paper

firstBeats a b = foldl helper 0 (zip a b)
    where 
        helper acc ls 
            | beats (fst ls) == (snd ls) = acc+1
            | otherwise = acc

--strip s = reverse $ dropWhile (=='_') s $ reverse $ dropWhile (=='_') s 
