module Lesson2 where

--currying

add :: Int -> Int -> Int;
add = (+);

distance :: Int -> Int -> Int;
distance a b = abs (a - b);

distanceFrom5 :: Int -> Int;
distanceFrom5 = distance 5;

not' :: Bool -> Bool;
not' True = False;
not' False = True;

and' :: Bool -> Bool -> Bool;
and' True True = True;
and' _ _ = False;

or' :: Bool -> Bool -> Bool;
or' False False = False;
or' _ _ = True;

tuple1 :: (Int, Int);
tuple1 = (2, 4);

tuple2 :: (Int, Char);
tuple2 = (,) 1 'a';

tuple3 :: (Int, Char, Bool);
tuple3 = (,,) 1 'b' False;

third :: (Int, Int, Int) -> Int;
third (_,_,a) = a;

funTuple :: (Int -> Int, Int -> Bool);
funTuple = ((+1), even)

matches :: (Int, Int) -> (Int, Int) -> Bool;
matches a b = a == b;

isEvenTuple :: Int -> (Int, Bool);
isEvenTuple a = (a, even a);

identity :: a -> a;
identity a = a;

triplicate :: a -> (a,a,a);
triplicate a = (a,a,a);

swap :: (a,b) -> (b,a);
swap (a,b) = (b,a);

doubleTheTouple :: (a,b) -> ((a,b), (a,b));
doubleTheTouple (a,b) = ((a,b), (a,b));

f :: Int -> Int -> Int;
f x y = x ^ 2 + 3 * y + 4 * x * y;

g :: Int -> Int -> Int;
g x y = f z z
    where
        z = 3*x + 7*y;

h :: Int -> Int -> Int;
h x y = f2 x y + f2 y x
    where
    --private instance, only visible to h; can be defined publicly h will use this.
        f2 x y = f x x + f y y; 

type KisPista = Int;
type NagyPista = KisPista;
type KozepesPista = NagyPista -> NagyPista;
type KozepesenNagyPista = KozepesPista -> KozepesPista;


fugg :: KozepesenNagyPista;
fugg a = a ;
