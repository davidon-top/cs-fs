module UlohyFs.u26

open System.IO
open System.Text.Unicode
open UlohyFs.Attributes
open System

[<Uloha(26)>]
let uloha26() =
    printfn "zadaj 5 medzerou oddelenych cisel od 1 do 35"
    let input = Console.ReadLine()
    let inpint = input.Split(' ') |> Array.map int
    if inpint.Length <> 5 then
        printfn "Zle zadane cisla"
    else
    let rng = Random()
    let lotto = [|for i in 1..5 -> rng.Next(1, 36)|]
    let matches = inpint |> Array.filter (fun x -> lotto |> Array.contains x) |> Array.length
    printfn "Tvoje cisla: %A" inpint
    printfn "Vyherne cisla: %A" lotto
    printfn "Zhoda: %d" matches