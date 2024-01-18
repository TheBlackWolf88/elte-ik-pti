module LessonOne where
    one :: Int
    one = 1

    two :: Int
    two = 2
    --increments
    inc :: Int -> Int
    inc = (+) 1
    
    letterE :: Char
    letterE = 'E'
    --best npm package
    isEven :: Int -> Bool
    isEven a = mod a 2 == 0
    -- the second best npm package 
    isOdd :: Int -> Bool
    isOdd a = mod a 2 /= 0
    
    betterIsOdd :: Int -> Bool
    betterIsOdd a = not (isEven a)
    
    add :: Int -> Int -> Int
    add a b = a + b
    
    area :: Int -> Int -> Int
    area  a b = a*b
    
    greater :: Int -> Int -> Bool
    greater a b = a>b

    isLeapYear :: Int -> Bool
    isLeapYear a = mod a 4 == 0 && mod a 100 /= 0 || mod a 100 == 0 && mod a 400 == 0


