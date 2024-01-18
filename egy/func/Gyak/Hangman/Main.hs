module Main where 
import Data.List

main :: IO ()
main = do putStrLn "Kitalando szo: "
          x <- readLn
          putStrLn "Guess: "
          inp <- readLn
          let pont = 0
          case guess x inp of
              True -> pont + 1
              False -> pont -1
          putStrLn (show pont)

guess :: String -> String -> Bool
guess a b = elem b $ group a

