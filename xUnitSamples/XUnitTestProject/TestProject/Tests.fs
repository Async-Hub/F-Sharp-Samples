module Tests

open System
open Xunit
open System.Threading.Tasks

// Async unit test
[<Theory>]
[<InlineData("a", "b")>]
let ``Async unit test`` (a: string) (b: string) =
    async {
        let ab = a + b

        Assert.True(ab.Equals "ab")
    }

// Async unit test with exception
[<Theory>]
[<InlineData("a", "b")>]
let ``Async unit test with exception`` (a: string) (b: string) =
    async {
        let action =
            async {
                a+ b |> ignore
                let! result = Task.FromException(Exception()) |> Async.AwaitTask
                return result } |> Async.StartAsTask :> Task

        Assert.ThrowsAsync<Exception>(fun () -> action) |> ignore
    }
