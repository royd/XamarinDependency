using System;
using Android.Runtime;
using Java.Interop;

namespace XamarinDependency.Library
{
    [Register("com/roydammarell/xamarindependency/ExceptionXamarinService")]
    public class ExceptionXamarinService : Java.Lang.Object
    {
        [Export("throwNullReferenceException")]
        public void ThrowNullReferenceException()
        {
            throw new NullReferenceException("Testing C# NullReferenceException");
        }
    }
}
