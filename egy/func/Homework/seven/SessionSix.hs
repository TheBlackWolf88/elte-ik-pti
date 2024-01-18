module SessionSix where
import Data.List


type Spell magic = (magic -> (Bool, magic))
type Stabilizer magic = (magic -> magic)
type Crate item = [[item]]
type Checker item = (item -> Bool)
type Amount = Int
type Cool = (Amount -> Bool)

 

prepare :: [Spell container] -> container -> container
prepare [] n = n
prepare (x:xs) n
    | fst (x n) = prepare xs (snd (x n))
    | otherwise = prepare xs n

stabilize :: Eq magic => Stabilizer magic -> magic -> magic
stabilize f m
    | m == (f m) = m
    | otherwise = stabilize f (f m)

brew :: (Integral item, Num ultimatrum) => Checker ultimatrum -> Stabilizer ultimatrum -> Crate item -> ultimatrum
brew _ _ [] = 0
brew c f a = make_it_stop c f (fromIntegral $ sum_sum a)
    where 
        sum_sum [] = 0
        sum_sum (x:xs) = sum x + sum_sum xs
        make_it_stop :: Checker a -> Stabilizer a -> a -> a
        make_it_stop c f n
            | c n = n
            | otherwise = make_it_stop c f (f n)
       

cooldown :: Eq magic => [magic] -> Cool -> [magic]
cooldown lst c = reverse $ i_want_my_own_function_with_blackjack_and_hookers c (group lst) []
    where
        i_want_my_own_function_with_blackjack_and_hookers _ [] done = done
        i_want_my_own_function_with_blackjack_and_hookers c (x:xs) done
            | c (length x) = i_want_my_own_function_with_blackjack_and_hookers c xs (head x : done)
            | otherwise = i_want_my_own_function_with_blackjack_and_hookers c xs (x ++ done);
