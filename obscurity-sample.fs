let explode (s: string) = s |> Seq.toArray
let implode (cs: char[]) = new string(cs)

let shiftChar c = (char)((int)c + 1)
let scramble = explode >> Array.rev >> Array.map shiftChar >> implode
