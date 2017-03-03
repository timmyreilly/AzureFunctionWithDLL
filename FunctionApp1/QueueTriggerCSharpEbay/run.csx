#r "..\bin\ClassLibrary1.dll"

using System;
using System.Net.Http;
using System.Net.Http.Headers; 
using System.Threading.Tasks; 

public static void Run(string myQueueItem, TraceWriter log)
{
    ClassLibrary1.Class1.CallEbay(); 

    log.Info($"C# Queue trigger function processed: {myQueueItem}");
}

