namespace MyClassLibrary
{
    public class Foo
    {
        public static string Info { get; } = "Conditionals"
#if net461
            + " net461"
#endif
#if NET461
            + " NET461"
#endif
#if NETCORE
            + " NETCORE"
#endif
#if NETSTANDARD
            + " NETSTANDARD"
#endif
#if NETSTANDARD2_0
            + " NETSTANDARD2_0"
#endif
            + "";
    }
}