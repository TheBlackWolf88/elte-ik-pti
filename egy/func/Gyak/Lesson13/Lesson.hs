import Data.List

data Binary = On | Off deriving (Show, Eq)

switch :: Binary -> Binary
switch On = Off
switch Off = On

bxor :: [Binary] -> [Binary] -> [Binary]
bxor l1 l2 = map (\(a,b) -> toBinary (a == b)) (zip l1 l2)
    where 
        toBinary a 
            | a = On
            | otherwise = Off

ntimes :: (a -> a -> a) -> a -> Int -> a
ntimes f a n
    | n == 1 = a
    | otherwise = f a $ ntimes f a (n-1)

w :: (a-> a-> a) -> a -> a
w f a = f a a

selectUnless :: (t -> Bool) -> (t -> Bool) -> [t] -> [t]
selectUnless f g lst = filter (\x -> f x && (not $ g x)) lst

c :: (a -> b -> c) -> (b -> a -> c)
c = flip

--parseCSV :: String -> [String]
--parseCSV a@(x:xs) =  
{-
splitOn :: Eq a => a -> [a] -> [[a]]
splitOn _ [] = []
splitOn a lst@(x:xs) = word a lst []
    where 
        word a [] acc = acc
        word a (x:xs) acc = case x of
            a -> acc ++ splitOn a xs 
            x -> word a xs (acc ++ [x])
-}

safeDiv :: Int -> Int -> Maybe Int 
safeDiv _ 0 = Nothing
safeDiv a b = Just (div a b)

paripos :: [Int] -> Bool
paripos = snd . foldl (\(ind, volt) curr -> (ind+1, (volt && even curr == even ind))) (0, True) 
