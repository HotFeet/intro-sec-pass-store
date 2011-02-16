open System

let explode (s: string) = s |> Seq.toArray
let implode (cs: char[]) = new string(cs)

let switchCase c = 
	match c with
	| _ when Char.IsUpper c -> Char.ToLower c
	| _ when Char.IsLower c -> Char.ToUpper c
	| _ -> c

let shiftChar dist (c: char) = (char)((int)c + dist)
let scramble = explode >> Array.rev >> Array.map switchCase >> Array.map (shiftChar 1) >> implode
