open System
//50 elements
open Col0
//50 elements
open Col1
//49 elements
open Col2

let rnd = new Random()

let num0 = rnd.Next(49)
let num1 = rnd.Next(49)
let num2 = rnd.Next(48)

let gen0 (num0 : int): string =
  let mutable firstWord = ""
  firstWord <- col0.[num0]
  firstWord

let gen1 (num1 : int) : string =
  let mutable secondWord = ""
  secondWord <- col1.[num1]
  secondWord

let gen2 (num2 : int): string =
  let mutable thirdWord = ""
  thirdWord <- col2.[num2]
  thirdWord


//test
printfn "Thou %s %s %s" (gen0 num0) (gen1 num1) (gen2 num2)
