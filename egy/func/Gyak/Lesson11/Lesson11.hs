module Lesson11 where
import Data.List hiding (find, zipWith, zip, elem)
import Prelude hiding (zipWith, zip, elem)

zipWith :: (a -> b -> c) -> [a] -> [b] -> [c]
--zipWith f a b = map (\(x,y) -> f x y) $ zip a b 
zipWith f [] _ = []
zipWith f _ [] = []
zipWith f (x:xs) (y:ys) = f x y : zipWith f xs ys

zip :: [a] -> [b] -> [(a,b)]
zip = zipWith (,)

fibPairs :: [(Integer, Integer)]
fibPairs = iterate (\(a,b) -> (b, a+b)) (0,1)

elem :: Eq a => a -> [a] -> Bool
elem x = foldl (\acc curr -> (x == curr || acc)) False

data List a = Nil | ListaElemAmiNemNil a (List a)
instance Foldable List where
    foldr f a Nil = a
    foldr f a (ListaElemAmiNemNil x xs) = f x (foldr f a xs)

instance Show a => Show(List a) where
    show l = '<' : showInner l ++ ">"
        where
        showInner Nil = ""
        showInner (ListaElemAmiNemNil x Nil) = show x
        showInner (ListaElemAmiNemNil x xs) = show x ++ ";" ++ showInner xs

fromList :: [a] -> List a
fromList = foldr (\curr acc -> ListaElemAmiNemNil curr acc) Nil

nthElem :: Int -> (List a) -> a
nthElem 0 (ListaElemAmiNemNil a _) = a
nthElem n (ListaElemAmiNemNil _ a) = nthElem (n-1) a

tl :: List a -> List a
tl Nil = Nil
tl (ListaElemAmiNemNil _ a) = a

hd :: List a -> a
hd Nil = error("Fuggveny went boom")
hd (ListaElemAmiNemNil a _) = a

take' :: Int -> List a -> List a
take' n Nil = Nil
take' n _ | n <= 0 = Nil
take' n (x `ListaElemAmiNemNil` xs) = x `ListaElemAmiNemNil` take' (n-1) xs

drop' :: Int -> List a -> List a
drop' n Nil = Nil
drop' n l | n <= 0 = l
drop' n (x `ListaElemAmiNemNil` xs) = x `ListaElemAmiNemNil` drop' (n-1) xs

(***) :: Int -> Int -> List Int
(***) a b = fromList [a..b]

filter' :: (a -> Bool) -> List a -> List a
filter' f Nil = Nil
filter' f (ListaElemAmiNemNil x xs)
    | f x = ListaElemAmiNemNil x (filter' f xs)
    | otherwise = filter' xs
