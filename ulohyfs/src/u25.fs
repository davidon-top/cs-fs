module UlohyFs.u25

open System.IO
open System.Text.Unicode
open UlohyFs.Attributes
open System

let obraty = [|15;-10;20;45;-90;65;40;78;-81;40;-9;61|]

[<Uloha(25)>]
let uloha25() =
    let positive = obraty |> Array.filter (fun x -> x > 0) |> Array.sum
    let negative = obraty |> Array.filter (fun x -> x < 0) |> Array.sum
    let sum = obraty |> Array.sum
    printfn "Kladne: %d" positive
    printfn "Zaporne: %d" negative
    printfn "Suma: %d" sum