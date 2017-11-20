using System;
using Android.Runtime;
using Com.Roydammarell.Xamarininterface;

namespace XamarinDependency.Library
{
    [Register("com/roydammarell/xamarindependency/HelloXamarinService")]
    public class HelloXamarinService : Java.Lang.Object, IHelloService
    {
        public string CreateHello()
        {
            return "Hello Xamarin!";
        }
    }
}
