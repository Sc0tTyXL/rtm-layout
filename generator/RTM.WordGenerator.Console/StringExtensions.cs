using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTM.WordGenerator.Console
{
    internal static class StringExtensions
    {
        private static readonly Random rng = new( );

        public static IOrderedEnumerable<T> Shuffle<T>( this IList<T> list )
        {
            return list.OrderBy( item => rng.Next( ) );
        }
    }
}
