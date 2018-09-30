// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.
(**
# Functions as Interfaces
## Introduction
- Pure Functions is the way to go for Functional Programming. 
- But the real world is ugly. 
- Systems live for a long time and we are bad at predicting the future. 
- Operational Work eg. Telemetry is orthogonal to business logic.
- Want to make Operational Work as orthogonal as possible.

## Functions
- Functions are essentially single method interfaces.
- Ceremony is required in a lot of cases. F# Functions don't. 
- Auto-generalization is done by the compiler that discerns the lowest common denominator for each type.
- As long as the new function has the same inputs and outputs as the original pfunction can be sub'd anywhere
    -- Liskov Substitution Principle
    -- These techniques can be used anywhere to not disturb core business logic. 

## Examples
- Dark Reads: Duplicate every call to your canonical function, to a new function.
    - Useful for load testing.
    - Only use this for idemptotent operations.

- Comparing
    - Testing new implementation of a function against production data and volumes.
    - Comparing the results of the two functions. Run different side effects.
    - Telemetry counters.

- Feature Flags
   - Selectively enabling / disabling conditions
   - eg. Switching repositories based on an update.

 - Switch / Jump Table
   - Many selections like Feature Flag.
   - Function mapping.
   - Switching between different implementations of a function.
   - A/B Experimentation

- Caching
    - Given a func, and key, check the data store for the existence and retrival possibility of the corresponding value. 

- Circuit Breakers 
    - Useful degradation and avoid slamming a service that is already unresponsibe.
    - Use alternate implementation once condition is met.

- Retries
    - Retriable exception. 
    - Given a particular class of exceptions, re-try upto a certain limit.

- Failure Injection
    - Given a desired percentage of failures, randomly throws exceptions when the function is called.
    - Useful for testing how the SLAs of your service's dependencies affecct your success rate.
**)

[<EntryPoint>]
let main argv = 
    printfn "%A" argv
    0 // return an integer exit code
