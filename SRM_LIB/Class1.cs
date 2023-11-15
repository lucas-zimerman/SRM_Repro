using System;
using Sentry;

namespace SRM_LIB
{
    public static class SentryLib
    {

        public static void Init()
        {
            SentrySdk.Init(o =>
            {
                o.Dsn = "https://eb18e953812b41c3aeb042e666fd3b5c@o447951.ingest.sentry.io/5428537";
                o.Debug = true;
            });
        }

        public static void HelloWorld()
        {
            SentrySdk.CaptureMessage("hello World");
        }


    }
}
