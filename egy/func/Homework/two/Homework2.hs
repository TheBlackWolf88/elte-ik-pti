module Adventure where

inc :: Int -> Int;
inc = (+)1;

lesser_heal :: Int -> Int;
lesser_heal a = inc (inc( (inc a)));

lookout :: Int -> Int -> Bool
lookout hp en = hp > (div en 10)

volume :: Int -> Int -> Int
volume en fa = en + fa * (mod en 12)

type CurrentDistrict = Int
type NextDistrict = Int
type HealthDamage = Int
type ArmorDamage = Int
type Health = Int
type Armor = Int
type Enhance = Int

move:: (CurrentDistrict , NextDistrict) -> NextDistrict
move (_, a) = a;

--Why do I hear boss music?

arcane_missiles :: (HealthDamage , ArmorDamage) -> (Health , Armor) -> (Health , Armor)
arcane_missiles (dam1, dam2) (hp1, hp2) = (hp1-dam1, hp2 - dam2)

arcane_missiles_mark_1 :: Enhance -> (HealthDamage , ArmorDamage) -> (Health , Armor) -> (Health , Armor)
arcane_missiles_mark_1 multi (dam1, dam2) (hp1, hp2) = arcane_missiles (dam1 * multi, dam2 * multi) (hp1,hp2)

arcane_blast :: (HealthDamage , ArmorDamage) -> (HealthDamage , ArmorDamage) -> (Health , Armor) -> (Health , Armor)
arcane_blast (dam1_1, dam2_1) (dam1_2, dam2_2) (hp1, hp2) = arcane_missiles (damage, damage) (hp1,hp2)
    where
        damage = dam1_1 * dam1_2 + dam2_1 * dam2_2

--This was the most entertaining házi feladat I've ever done.
