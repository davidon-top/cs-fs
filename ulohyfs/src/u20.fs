module UlohyFs.u20

open System.IO
open UlohyFs.Attributes
open System

[<Uloha(20)>]
let uloha15() =
    let hostia = ["Novak"; "Novaková"; "novy"; "mlinar"; "mlinarová"; "kovac"; "kovacová"; "rybar"; "rybarová"; "farmar"; "gazdová"]
    let hostiaZ = hostia |> List.filter _.EndsWith("ová") |> List.sort
    let hostiaM = hostia |> List.filter (fun x -> not(x.EndsWith("ová"))) |> List.sort
    printfn "Zeny: %A" hostiaZ
    printfn "Muzi: %A" hostiaM