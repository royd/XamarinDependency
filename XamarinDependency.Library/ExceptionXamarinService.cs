using System;
using Android.Runtime;
using Com.Roydammarell.Xamarininterface;

namespace XamarinDependency.Library
{
    [Register("com/roydammarell/xamarindependency/ExceptionXamarinService")]
    public class ExceptionXamarinService : Java.Lang.Object, IExceptionService
    {
        public void ThrowNullReferenceException()
        {
            throw new NullReferenceException("Testing C# NullReferenceException");
        }
    }
}
