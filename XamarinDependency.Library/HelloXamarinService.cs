using System;
using Android.Runtime;
using Java.Interop;

namespace XamarinDependency.Library
{
    [Register("com/roydammarell/xamarindependency/HelloXamarinService")]
    public class HelloXamarinService : Java.Lang.Object
    {
        public HelloXamarinService()
        {
        }

        [Export]
        public string CreateHelloXamarin()
        {
            return "Hello Xamarin!";
        }
    }
}
