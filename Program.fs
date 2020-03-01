// Learn more about F# at http://fsharp.org

open System

let rec contains S =
  match S with 
  |[]-> true
  | hd::tl -> if(hd = false) then false else contains tl

let rec superset S L = 
  match S with
  | []-> true
  | hd::tl -> if ((contains ( (L |> List.map (fun x -> x <>hd))) = false )) then false else superset tl L

[<EntryPoint>]

    printfn("%A") (superset [3; 1; 2] [1; 4; 2; 0; 3])
    0 // return an integer exit code
