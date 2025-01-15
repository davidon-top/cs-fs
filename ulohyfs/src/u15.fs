module UlohyFs.u15

open System.IO
open System.Text.Unicode
open UlohyFs.Attributes
open System

let path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/spokojnost.txt"
let npath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/nespokojnost.txt"

[<Uloha(15)>]
let uloha15() =
    let spokojnost =
        File.ReadAllLines(path)
        |> Array.map (fun l -> Convert.ToInt32(l))
    let nfile = File.Create(npath)
    spokojnost |> Array.iter (fun s -> (
        if s <= 5 then
            nfile.Write(Text.Encoding.UTF8.GetBytes(s.ToString() + "\n"))
        ))
    nfile.Flush()
    nfile.Close()
    printfn "Pocet zakaznikov: %d" spokojnost.Length
    printfn "Priemer: %f" (spokojnost |> Array.map (fun f -> float f) |> Array.average)