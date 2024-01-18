import Prelude hiding (Maybe(..), find, lookup, update)

data Calculator = Addition Int Int | Multiplication Int Int deriving (Show)

calc :: Calculator -> Int
calc (Addition a b) = (+) a b
calc (Multiplication a b) = (*) a b

newtype Name = Name String deriving (Show)

addPetoffy :: Name -> Name
addPetoffy (Name n) = Name ("Petoffy " ++ n)

data Point = Point Int Int deriving (Show)
instance Eq Point where
    (Point x1 y1) == (Point x2 y2) = (x1 == x2) && (y1 == y2)

data Point2 = Point2 Int Int 
instance Show Point2 where
    show(Point2 x y) = "Point2: X=" ++ show(x) ++ " Y=" ++ show(y) 

data Point3 = Point3 Int Int deriving (Show)
instance Num Point3 where
    (Point3 x1 y1) + (Point3 x2 y2) = (Point3 (x1+x2) (y1+y2))

data Maybe a = Just a | Nothing deriving (Show, Eq)

isJust :: Maybe a -> Bool
isJust (Just _) = True
isJust _ = False

isNothing:: Maybe a -> Bool
isNothing(Just _) = False 
isNothing _ = True

eqMaybe :: Eq a => Maybe a ->Maybe a -> Bool
eqMaybe (Nothing) (Nothing) = True
eqMaybe (Just a) (Just b) = a == b
eqMaybe _ _ = False

safeHead :: [a] -> Maybe a
safeHead [] = Nothing
safeHead (x:_) = (Just x)

convertJust :: Maybe Int -> Int
convertJust (Just a) = a
convertJust (Nothing) = 0

safeTail :: [a] -> Maybe [a]
safeTail [] = Nothing
safeTail (_:xs) = (Just xs)

maybeToList :: Maybe a -> [a]
maybeToList (Nothing) = []
maybeToList (Just a) = [a]

divide10 :: Double -> Maybe Double
divide10 0 = Nothing
divide10 n = Just (10/n) 

lookup :: Eq k => k -> [(k,v)] -> Maybe v
lookup _ [] = Nothing
lookup k ((a,b):xs)
    | k == a = Just b
    | otherwise = lookup k xs

data List a = Nil | Cons a (List a)
instance Foldable List where
    foldr f a Nil = a
    foldr f a (x `Cons` xs) = f x (foldr f a xs)

instance Show a => Show (List a) where
    show l = '<' : showInner l ++ ">"
     where
     showInner Nil = ""
     showInner (Cons x Nil) = show x
     showInner (Cons x xs) = show x ++ ";" ++ showInner xs

fromList :: [a] -> List ai
fromList [] = Nil
fromList (x:xs) = Cons x (fromList xs)

