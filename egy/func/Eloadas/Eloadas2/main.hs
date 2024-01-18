inc :: Num a => a -> a;
--az x erteke nem valtozhat
inc x = x+1

--kolcsonos rekurzio
--eveN n = not (odD n);
--odD n = not (eveN n)

square = (^) 2;
squareInc x = square(inc x);


