// Learn more about F# at http://fsharp.org

open System
open FSharp

[<EntryPoint>]
let main argv =
    let account = { Id = "1"; CreationTime = DateTime.Now}
    printfn "Account id: %A %A" account.Id account.CreationTime
    0 // return an integer exit code