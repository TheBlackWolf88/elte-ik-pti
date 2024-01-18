module Homework1 where
    --direkt ennyire random
    intExpr1 :: Int;
    intExpr1 = 1;
    intExpr2 :: Int;

    charExpr2 :: Char;

    charExpr1 :: Char;
    charExpr1 = 'a';
    charExpr2 = 'b';
    charExpr3 = 'c';

    charExpr3 :: Char;
    boolExpr1 :: Bool;
    boolExpr2 :: Bool;
    boolExpr3 :: Bool;
    intExpr2 = 2;
    
    intExpr3 :: Int;
    intExpr3 = 3;

    boolExpr1 = True;
    boolExpr2 = False;
    boolExpr3 = True;

    canPlantAll :: Bool
    canPlantAll = (div 183 13) * 13 == 183;

    remainingSeeds :: Int;
    remainingSeeds = mod 183 13;

--increments
    inc :: Int -> Int
    inc = (+) 1

    double :: Int -> Int;
    double = (*) 2;

    seven1 :: Int;
    seven1 = inc(double(inc(double(inc 0))));

    seven2 :: Int;
    seven2 = inc (inc( inc( inc( inc( inc( inc 0))))));

    seven3 :: Int;
    seven3 = inc( inc(inc( double( double( (inc 0))))));

    cmpRem5Rem7 :: Int -> Bool;
    cmpRem5Rem7 a = mod a 5 > mod a 7;

    foo :: Int -> Bool -> Bool;
    foo a b = b;
 
    bar :: Bool -> Int -> Bool;
    bar x y = foo y x;
