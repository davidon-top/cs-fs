module UlohyFs.u22

open System.IO
open System.Text.Unicode
open UlohyFs.Attributes
open System

[<Uloha(22)>]
let uloha22() =
    printfn "zadaj dajake cislo"
    let input = Console.ReadLine()
    let inpint = int input
    input.ToString()
    |> Seq.map (fun x -> x.ToString())
    |> Seq.map (fun x -> int x)
    |> Seq.sum
    |> printfn "sum: %d"