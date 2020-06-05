// ✊🏿✊🏿✊🏿 This code was written as a protest for the police brutality and racism
// that is currently taking place against black people in the United States

open System

let choke (time: int) = System.Threading.Thread.Sleep time

let watch time color =
    let mins = time / 1000
    let secs = time % 1000 / 10

    let tempColor = Console.ForegroundColor
    Console.ForegroundColor <- color

    match mins, secs with
    | minutes, 0 -> printfn "%d minutes" minutes
    | 0, seconds -> printfn "%d seconds" seconds
    | minutes, seconds -> printfn "%d minutes %d seconds" minutes seconds

    Console.ForegroundColor <- tempColor

let rec kneel(time) =
    choke 1000
    match time with
    | t when t < 4000 ->
        watch time ConsoleColor.Blue
        let newTime = time + 1000;
        kneel(newTime);
    | t when t < 8000 ->
        watch time ConsoleColor.White
        let newTime = time + 1000;
        kneel(newTime);
    | t when t <= 8460 ->
        watch time ConsoleColor.Red
        let newTime = time + 100;
        kneel(newTime);
    | t ->
        watch 8460 ConsoleColor.Red
        printfn "."

[<EntryPoint>]
let main argv =
    kneel(1000)
    0 // return an integer exit code
