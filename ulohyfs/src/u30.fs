module UlohyFs.u30

open System.IO
open System.Text.RegularExpressions
open System.Text.Unicode
open UlohyFs.Attributes
open System

let (./.) l r = $"{l}{Path.PathSeparator}{r}"


let getSlova=
    Environment.GetFolderPath(Environment.SpecialFolder.Desktop) ./. "maturita" ./. "ZADANIE č.20" ./. "slova.txt"
    |> fun x -> if File.Exists x then Some(x) else None
    |> function
        | Some(v) -> File.ReadAllText v
        | None ->
            printfn "Nepodarilo sa najst hobit.txt zadaj cestu k hobit.txt"
            let inp = Console.ReadLine()
            File.ReadAllText inp

[<Uloha(30)>]
let uloha30() =
    let h = getSlova
    let out = System.Text.RegularExpressions.Regex("\s[a-zA-Z1-9][\s|.|,]").Replace(h, " ")
    File.WriteAllText("./bez1.txt", out)