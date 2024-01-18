module X where
--Learn You a Haskell for Great Good!
--azon  formalis param  definialo egyenloseg    fvtorzs
    inc  x              =                       (+) x 1;
    pow i j = i ^ j;
-- Num : tipusleiras, barmilyen numerikus erteket elfogad
    inc :: Num a => a -> a;
