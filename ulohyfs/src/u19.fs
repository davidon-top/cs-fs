module UlohyFs.u19

open System.IO
open UlohyFs.Attributes
open System

let startsWithConsonant (s: string) =
    let consonants = "bcdfghjklmnpqrstvwxz"
    s.ToLower().[0] |> consonants.Contains

let startsWithVowel (s: string) =
    let vowels = "aeiouy"
    s.ToLower().[0] |> vowels.Contains

[<Uloha(19)>]
let uloha15() =
    printfn "zadaj slovo"
    let input = Console.ReadLine()
    if startsWithConsonant input then
        printfn "%s%cay" (input.Substring(1)) input.[0]
    elif startsWithVowel input then
        printfn "%sway" input