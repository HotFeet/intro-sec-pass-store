open System

let reverse = Array.rev
let map = Array.map

let explode (s: string) = s |> Seq.toArray
let implode (cs: char[]) = new string(cs)

let switchCase c = 
	match c with
	| _ when Char.IsUpper c -> Char.ToLower c
	| _ when Char.IsLower c -> Char.ToUpper c
	| _ -> c

let shiftLetter distance (c: char) = (char)((int)c + distance)
let scramble = explode >> reverse >> map (switchCase >> shiftLetter 1) >> implode
