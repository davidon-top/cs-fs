module UlohyFs.u18

open System.IO
open UlohyFs.Attributes
open System

[<Uloha(18)>]
let uloha15() =
    let mutable znamky = []
    let mutable running = true
    while running do
        let znamka = Console.ReadLine() |> int
        if znamka = 0 then
            running <- false
        else
            znamky <- znamky @ [znamka]
            znamky |> List.map float |> List.average |> printfn "Prumer: %f"
            znamky |> List.min |> printfn "Minimum: %d"
            znamky |> List.max |> printfn "Maximum: %d"
