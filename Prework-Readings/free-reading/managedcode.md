# What is "managed code"?

- CLR: Common language runtime is charge of taking the managed code, compiling it into machine code and then executing it. 
- Also manage memory and security boundaries.
- In unmanaged code, programmer is in charge of everything including memory and starts

## Intermediate Language & execution
- compilation of code written in high-level .NET language
- IL is independent from any other language that runs on top of the runtimes. 
- IL is also known as CIL or Microsoft intermediate language
- CLR allows passing the boundaries between managed and unmanaged world 
- C# is one language that allows you to use unmanaged constructs such as pointers directly in code by utilizing what is known as unsafe context which designates a piece of code for which execution is not managed by the CLR.
