module UlohyFs.u17

open System.IO
open UlohyFs.Attributes
open System

let eur2usd euro =
    euro * 1.0245

[<Uloha(17)>]
let uloha15() =
    printfn "Eur?: "
    let eur = System.Console.ReadLine() |> float
    let usd = eur2usd eur
    printfn "USD: %f" usd
