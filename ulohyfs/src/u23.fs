module UlohyFs.u23

open System.IO
open System.Text.Unicode
open UlohyFs.Attributes
open System

[<Uloha(23)>]
let uloha23() =
    let mutable array4 = Array.create 4 0.0
    let mutable i = 0
    let mutable running = true
    while running do
        printfn "Zadaj dajake cislo alebo koniec"
        let inp = Console.ReadLine()
        if inp = "end" || inp = "koniec" then
            running <- false
        else
        array4.[i] <- float inp
        i <- i + 1
        if i = 3 then
            array4.[i] <- float inp
            printfn "pole: %A" array4
            array4 |> Array.average |> printfn "priemer: %f"
            i <- 0