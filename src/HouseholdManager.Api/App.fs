open Suave
open Suave.Successful
open System.Net
open System

[<EntryPoint>]
let main [| port |] = 

    let config =
        { defaultConfig with
            bindings = [ HttpBinding.create HTTP IPAddress.Loopback (uint16 port) ]
            listenTimeout = TimeSpan.FromMilliseconds 3000. }
    startWebServer config (OK "Household Manager Api")
    0