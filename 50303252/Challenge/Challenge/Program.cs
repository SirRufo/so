using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Challenge
{
    class Program
    {
        static void Main( string[] args )
        {
            var prefix = "Foo";
            var input = new object[]
            {
                "a string",
                new[]
                {
                    "a",
                    "b",
                    "c"
                },
                "spam",
                new[]
                {
                    "eggs"
                },
                new[]
                {
                    new[]
                    {
                        "one",
                        "two"
                    },
                    new[]
                    {
                        "three",
                        "four"
                    }
                }
            };

            var output = DumpList( prefix, input );
            Console.WriteLine( output );
        }

        static string DumpList( string prefix, object list )
        {
            IEnumerable<string> collection = !( list is string )
                ? ( list as IEnumerable )?
                    .Cast<object>()
                    .Select(
                        ( o, i ) => DumpList(
                            prefix: string.Format( "{0}.{1}", prefix, i ),
                            list: o ) )
                : null;

            return collection != null
                ? string.Join(
                    separator: Environment.NewLine,
                    values: collection )
                : string.Format( "{0}: {1}", prefix, list );
        }
    }
}
