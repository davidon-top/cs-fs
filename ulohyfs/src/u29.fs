module UlohyFs.u28

open System.IO
open System.Text.RegularExpressions
open System.Text.Unicode
open UlohyFs.Attributes
open System

let (./.) l r = $"{l}{Path.PathSeparator}{r}"


let getHobit =
    Environment.GetFolderPath(Environment.SpecialFolder.Desktop) ./. "maturita" ./. "ZADANIE č.19" ./. "hobit.txt"
    |> fun x -> if File.Exists x then Some(x) else None
    |> function
        | Some(v) -> File.ReadAllText v
        | None ->
            printfn "Nepodarilo sa najst hobit.txt zadaj cestu k hobit.txt"
            let inp = Console.ReadLine()
            File.ReadAllText inp

[<Uloha(28)>]
let uloha28() =
    let h = getHobit
    let mutable spaces = 0
    h
    |> String.iter (fun c -> if c = ' ' then spaces <- spaces + 1)
    printfn "medzery: %d" spaces
    h
    |> printfn "%s"