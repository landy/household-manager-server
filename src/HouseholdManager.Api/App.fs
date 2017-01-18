open Suave
open Suave.Successful

[<EntryPoint>]
let main argv = 

    startWebServer defaultConfig (OK "Household Manager Api")
    0