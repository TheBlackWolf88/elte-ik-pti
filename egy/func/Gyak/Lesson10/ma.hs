module Ma where 
import Data.List

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
fromList [] = Nil
fromList (x:xs) = ListaElemAmiNemNil x (fromList xs)

lookup' :: Eq a => a -> [(a,b)] -> Maybe b
lookup' _ [] = Nothing
lookup' key ((a,b):xs)
    | key == a = Just b
    | otherwise = lookup' key xs

update :: Eq k => (v -> Maybe v) -> k -> [(k,v)] -> [(k,v)]
update _ _ [] = []
update f k (x@(key,val):xs)
    | k /= key = update f k xs
    | k == key = case f val of
        Just val' -> (key,val') : xs
        Nothing -> xs

delete' :: Eq k => k -> [(k,v)] -> [(k,v)]
delete' k = update (const Nothing) k


data Privilege = User | Admin deriving (Show, Eq)

type Username = String
type Password = String
type Database = [((Username, Password), Privilege)]

data Cookie = LoggedOut | LoggedIn Username Privilege deriving (Show,Eq)

login :: Username -> Password -> Database -> Cookie
login uname pw db = case lookup (uname, pw) db of
    Nothing -> LoggedOut
    Just priv -> LoggedIn uname priv

trfDb :: [((Username, Password), Privilege)] -> [(Username,(Password, Privilege))]
trfDb = map (\((x,y),z) -> (x,(y,z)))

--trfDbBack :: [(Username, (Password, Privilege))] -> [(Username,(Password, Privilege))]
--trfDbBack = map (\(x,(y,z)) -> ((x,y),z))

deleteUser :: Username -> Cookie -> Database -> Database
--deleteUser u (LoggedIn _ Admin) = trfDbBack . delete' u . trfDb 
deleteUser _ _ = id

length' :: [a] -> Int 
length' = foldl (\acc _ -> acc +1) 0

isort :: Ord a => [a] -> [a]
isort = foldr insert []

--reverseWFl = foldr (flip(:)) []

--concat' = foldr (++) []

maximum' :: Ord a => [a] -> a
maximum' = foldl1 max
