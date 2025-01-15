module UlohyFs.u16

open System
open UlohyFs.Attributes

[<Uloha(16)>]
let uloha16() =
    let original = "mATURITNÁ SKÚŠKA Z iNFORMATIKY"
    let added = sprintf $"{original} aktuálny rok, v ktorom maturujete"
    printfn "%s" added
    original.IndexOf "SKÚŠKA"
    |> printfn "Index SKÚŠKA: %d"
    printfn "inverted case: %s" (original |> Seq.map (fun c -> if Char.IsLower c then Char.ToUpper c else Char.ToLower c) |> Seq.toArray |> System.String)
    printfn "replaced %s" (original.Replace("Informatiky", "Programovania"))

    printfn "all operations: %s" (added |> Seq.map (fun c -> if Char.IsLower c then Char.ToUpper c else Char.ToLower c) |> Seq.toArray |> System.String |> fun s -> s.Replace("Informatiky", "Programovania"))
