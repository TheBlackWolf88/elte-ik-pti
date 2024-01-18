module SessionFive where

 type Crate item = [[item]] 
 type Recipe item = (item -> Bool) 
 type Measure item = (item -> item) 
 type Amount = Int

--Ez miert mukodik?
--Marmint
--Ezt csak jobban lehetett volna

 recipe :: Eq item => Recipe item -> Crate item -> Bool
 recipe f [] = True
 recipe f (x:xs) = recipe f xs && helper f x []
    where
        helper f [] [] = True
        helper f a@(x:xs) rem
            | f x = helper f xs rem
            | otherwise = False

 measure :: Measure item -> Crate item -> Crate item
 measure f [] = []
 measure f (x:xs) = [map f x] ++ measure f xs

 measure_until :: Eq item => Recipe item -> Measure item -> Crate item {-not empty-} -> Amount
 measure_until  f g a@(x:xs)
    | recipe f a = 1 + measure_until f g (measure g a)
    | otherwise = 0

