#r "System.Net.Http.dll"
open System.Threading.Tasks

// Consuming a .NET API that returns a Task<TResult>
let asyncAwaitTask =
    async {
        let httpClient = new System.Net.Http.HttpClient()
        let! response = httpClient.GetAsync "https://asynchub.org" |> Async.AwaitTask

        return response
    }

// Runs an asynchronous computation synchronously
let  asyncRunSynchronously =
        asyncAwaitTask |> Async.RunSynchronously

// Convert: Task<TResult> -> Task
let simpleTask = asyncAwaitTask |> Async.StartAsTask :> Task
simpleTask.Status
    
