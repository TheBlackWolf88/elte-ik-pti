module SessionFour where

type Air = Int
type Fire = Integer
type Shadow = Float
type Haskell = Double
type Open = String
type Key a b = [[(a,[b])]]
type Type = String
type Power = Integer
type Missile = (Type, Power)

mind_vision :: Ord magic => [magic] -> Bool
mind_vision [] = True
mind_vision [a] = True
mind_vision (x:xs)
    | x > head xs = False
    | otherwise = mind_vision xs

lock :: Key a b -> Open
lock [(x,xs):[y,ys]]            = "First"
lock ([_]:[(x,[xs])]:[y,ys]:[]) = "Second"
lock ([(x,y:_:[])]:[])          = "Third"
--ezen a ponton inkabb bent maradok

magic_key_1 = [[(1,[9,5]),(1,[4,3]),(2,[3,3])]]
magic_key_2 = [[(1,[1,2])],[(1,[1])],[(1,[1]),(1,[1,2])]] 
magic_key_3 = [[((1,2),[(1,4), (2,3)])]]

mage_armor :: [Missile] -> Type -> Power
mage_armor [] _ = 0
mage_armor ((t,l):xs) fil
    | t /= fil = l + mage_armor xs fil
    | otherwise = mage_armor xs fil

backfire :: [Missile] -> [Missile]
backfire [] = []
backfire (x:xs)
    | snd x < 50 =  backfire (justDoIt xs x)
    | otherwise = x : backfire xs 
  where
    justDoIt :: [Missile] -> Missile -> [Missile]
    justDoIt [] _ = []
    justDoIt (x:xs) red
        | fst red == fst x = (fst x, (snd x) - (snd red)) : justDoIt xs red
        | otherwise = x : justDoIt xs red

-- Ez a TidalCycle egész funnak tűnik.
