module UlohyFs.u27

open System.IO
open System.Text.RegularExpressions
open System.Text.Unicode
open UlohyFs.Attributes
open System

type Zamestnanec = {
    meno: string
    priezvisko: string
    vek: int
    nastupil: int
}

let parseInput input =
    let regex = "^(?'meno'[A-Z][a-z]+)[ |,]+(?'pr'[A-Z][a-z]+)[ |,]+(?'vek'[0-9]+)[ |,]+(?'rok'[0-9]+)$"
    let r = Regex.Match(input, regex)
    {
        meno = r.Groups["meno"].Value;
        priezvisko = r.Groups["pr"].Value;
        vek = r.Groups["vek"].Value |> int;
        nastupil = r.Groups["rok"].Value |> int;
    }

[<Uloha(27)>]
let uloha27() =
    printfn "zadaj cislo zamestnancov"
    let n = Console.ReadLine().Trim() |> int
    let mutable list = List.empty
    for i in 1..n do
        printfn "zadaj zamestnanca"
        let inp = Console.ReadLine().Trim()
        list <- list @ [parseInput inp]
        
    list
    |> List.filter (fun x -> x.nastupil > 2012)
    |> List.iter (fun x -> printfn $"{x.meno} {x.priezvisko}")
    
    list
    |> List.map (fun x -> x.vek |> float)
    |> List.average
    |> printfn "priemer %f"