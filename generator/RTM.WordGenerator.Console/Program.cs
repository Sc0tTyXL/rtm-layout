// See https://aka.ms/new-console-template for more information

using RTM.WordGenerator.Console;


var content = new List<string>( )
{
    $"Dutch wordlist randomized Sc0tTy with minimal weight: ",
    "Wordlist sources: https://opentaal.org v2.20.19, https://github.com/hermitdave/FrequencyWords (50k NL Weighted)",
    "", ""
};

Console.WriteLine( "Reading OpenTaal" );
var lines = new List<string>();
lines.AddRange( File.ReadAllLines( @"C:\OneDrive\Settings\Keyboard\opentaal-wordlist-2.20.19\elements\basiswoorden-gekeurd.txt" ) );



Console.WriteLine( "Reading NL 50K" );
foreach ( var line in File.ReadAllLines( @"C:\OneDrive\Settings\Keyboard\Layouts\nl_50k.txt" ) )
{
    var str = line.Split( ' ' );
    var word = str[0];
    if ( word.Length == 1 && word != "o" && word != "u" ) continue;

    var weight = int.Parse( str[1] );
    
    if ( weight < 1000 ) continue;
    var times = weight / 500;
    Console.WriteLine( $"{word} {times}" );
    for ( int i = 0; i < times; i++ )
    {
        lines.Add( word );
    }
}
// Console.WriteLine( "Reading EN 50K" );
// foreach ( var line in File.ReadAllLines( @"C:\OneDrive\Settings\Keyboard\Layouts\en_50k.txt" ) )
// {
//     var str = line.Split( ' ' );
//     var word = str[0];
//     if ( word.Length == 1 && word != "o" && word != "u" ) continue;
//
//     var weight = int.Parse( str[1] );
//     
//     if ( weight < 10000 ) continue;
//     var times = weight / 1000;
//     Console.WriteLine( $"{word} {times}" );
//     for ( int i = 0; i < times; i++ )
//     {
//         lines.Add( word );
//     }
// }

var shuffled = lines.Shuffle( ).ToList(  );

var x = new[]
{
    '.', '.', '.', '.', ',', ',', '?', '!'
};

var z = 0;
var done = false;
var count = 10;
while ( done == false )
{
    for ( int i = 0; i < x.Length; i++ )
    {
        var value = string.Join( " ", shuffled.Skip( z ).Take( count ) );
        if ( value.Length != 0 )
        {
            content.Add( value + x[i] );
        }
        else
        {
            done = true;
            break;
        }

        z += count;
    }
}

File.WriteAllLines( $@"C:\Dev\RTM\opentaal_2.20.19_randomized.txt", content );

Console.WriteLine( "Done!" );