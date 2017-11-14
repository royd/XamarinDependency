using System;
using Android.Runtime;

namespace XamarinDependency.Library
{
    [Register("xamarindependency/library/HelloXamarinService")]
    public class HelloXamarinService : Java.Lang.Object
    {
        public HelloXamarinService()
        {
        }

        public string CreateHelloXamarin()
        {
            return "Hello Xamarin!";
        }
    }
}
