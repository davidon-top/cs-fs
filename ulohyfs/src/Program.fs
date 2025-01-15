module UlohyFs.Program

open System
open System.Reflection
open UlohyFs.Attributes

[<EntryPoint>]
let main args =
    let ulohy =
        Assembly.GetExecutingAssembly().GetTypes()
        |> Array.map _.GetMethods()
        |> Array.collect id
        |> Array.filter (fun m -> m.GetCustomAttributes(typeof<UlohaAttribute>, false).Length > 0)
    printfn "Zadaj cislo ulohy:"
    let uloha = Console.ReadLine()
    let uloha = Convert.ToInt32(uloha)
    let ulohameta =
        ulohy
        |> Array.map (fun m -> (
            let ua =
                m.GetCustomAttributes(typeof<UlohaAttribute>, false)
                |> Array.map (fun a -> a :?> UlohaAttribute)
            (ua[0], m)
        ))
        |> Array.find (fun (a, _) -> a.Id = uloha)

    let _, m = ulohameta
    m.Invoke(null, null) |> ignore

    0