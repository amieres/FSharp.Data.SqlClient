open FSharp.Data

[<Literal>]
let connectionString = "Data Source=mhknbn2kdz.database.windows.net;Initial Catalog=AdventureWorks2012;Integrated Security=False;User ID=sqlfamily;Password=sqlf@m1ly"

[<EntryPoint>]
let main _ =
    let get42 = new SqlCommandProvider<"SELECT 42", connectionString>(connectionString)
    get42.Execute() |> Seq.toArray |> printfn "%A"
    0
