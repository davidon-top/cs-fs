module UlohyFs.u24

open System.IO
open System.Text.Unicode
open UlohyFs.Attributes
open System

let noMessages = [| "Ups, vedľa ako tá jedľa!"; "No, toto ti nevyšlo."; "Skús ešte raz, možno sa stane zázrak."; "Tak toto bolo fakt mimo."; "Si vedľa, ako keby si spadol z višne."; "Nie, ale aspoň si sa snažil!"; "Skoro, ale len pre kone."; "To je síce pekné, ale nesprávne."; "Si na míle vzdialený od správnej odpovede."; "Nie, ale máš aspoň dobrú fantáziu!"; "Žiaľ, tvoja odpoveď je taká zlá, že ju ani nebudem komentovať. " |]

[<Uloha(24)>]
let uloha24() =
    printfn "myslim si cislo od 1 do 10, hadaj:"
    let rng = Random()
    let cislo = rng.Next(1, 11)
    let mutable hadane = 0
    let mutable pokusy = 0
    while hadane <> cislo do
        hadane <- Console.ReadLine() |> int
        pokusy <- pokusy + 1
        if hadane <> cislo then
            let r = rng.Next(0, noMessages.Length)
            printfn "%s" noMessages.[r]

    printfn "Gratulujem, uhádol si na %d. pokus!" pokusy