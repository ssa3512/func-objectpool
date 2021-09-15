using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.ObjectPool;
using System;

namespace Test
{
    public class Function
    {
        [FunctionName("Run")]
        public void Timer([TimerTrigger("*/5 * * * * *")] TimerInfo timerInfo)
        {
            var policy = new DefaultPooledObjectPolicy<MyClass>();
            var pool = new DefaultObjectPool<MyClass>(policy);
            var myItem = pool.Get();
            Console.WriteLine(myItem);
        }
        
    }

    public class MyClass
    {
        
    }
}