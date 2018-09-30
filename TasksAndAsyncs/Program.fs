// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.
(** 
# The Curious Case of Async. vs. Task

## Introduction
    - Async Workflow not hot unlike Tasks in F#
        -- You need to explictly start the async task. 
    - Look at the F# Component Design Guide
    - Make use of Object Programming
    - Vegeta, Netling for Load Testing.
    - Testing Findings must be reproducable.
    - Kestral in general is super performant.
    - There is a cost from Async to Task.
    - Pre-optimizations are not efficient.

    - Async to Task is usually fine.
    - If you are working with alot of Task based APIs, consider Task all the way
    - If you are exposing an API for C#, consider going Task all the way
    - Be mindful of your test tools
**)

[<EntryPoint>]
let main argv = 
    printfn "%A" argv
    0 // return an integer exit code
