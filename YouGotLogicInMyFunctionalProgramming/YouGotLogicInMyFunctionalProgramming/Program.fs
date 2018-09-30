// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.

(* 
# You got Logic in my Functional Programming 

## What is Logic Programming

1. Logic programming is code written of rules and facts in logical form. 
- Define things that are true.
- Define rules for relationships between true clauses.

2. Prolog is a dynamically typed - logic programming language.

3. The Components of Prolog
    - Operators: 
        Mathematical components
    - Terms: any type. 
    - Atoms: Fundamental components
    - Numbers: Both integer and floating point.
    - Variables: Binds to values in a solution that satisfies a rule.
    - List: Combination of Atoms  
        - Empty list
    - Compound Term: A functor and arguments
    - Fact: Compound Term ending with . eg. Powered On / Os Is Running / Application is Running

4. 
*)


[<EntryPoint>]
let main argv = 
    printfn "%A" argv
    0 // return an integer exit code
