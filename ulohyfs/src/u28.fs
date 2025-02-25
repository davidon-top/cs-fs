module UlohyFs.u29

open System.IO
open System.Text.RegularExpressions
open System.Text.Unicode
open UlohyFs.Attributes
open System

let napoje = [| 20; 55; 45; 95; 150; 105; 100; 45 |]

[<Uloha(29)>]
let uloha29() =
    printfn "napoje:"
    napoje |> Array.iteri (fun i x -> printfn $"{i + 1}. cena: {x}")
    let inp = Console.ReadLine().Trim() |> int
    let mutable cena = napoje[inp - 1]
    while not (cena <= 0) do
        printfn "vhod mincu, este treba %d" cena
        let minca = Console.ReadLine().Trim() |> int
        cena <- cena - minca
    printfn "vydavok: %d" (Math.Abs cena)