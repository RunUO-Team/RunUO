using System;
using System.IO;
using Server;

namespace Server.Misc
{
	public class DataPath
	{
		/* If you have not installed Ultima Online,
		 * or wish the server to use a separate set of datafiles,
		 * change the 'CustomPath' value.
		 * Example:
		 *  private static string CustomPath = @"C:\Program Files\Ultima Online";
		 */
		private static string CustomPath = null;

		/* Common default paths for cross-platform compatibility.
		 * Add your UO data directory paths here.
		 */
		private static readonly string[] DefaultPaths = {
			@"C:\Program Files\Ultima Online",
			@"C:\Program Files (x86)\Ultima Online",
			@"C:\UO",
			@"/usr/local/share/uo",
			@"/opt/uo",
			@"./Data",
			@"./UOData",
			@"../UOData"
		};

		/* The following is a list of files which a required for proper execution:
		 *
		 * Multi.idx
		 * Multi.mul
		 * VerData.mul
		 * TileData.mul
		 * Map*.mul or Map*LegacyMUL.uop
		 * StaIdx*.mul
		 * Statics*.mul
		 * MapDif*.mul
		 * MapDifL*.mul
		 * StaDif*.mul
		 * StaDifL*.mul
		 * StaDifI*.mul
		 */

		public static void Configure()
		{
			if ( CustomPath != null )
				Core.DataDirectories.Add( CustomPath );

			// Try default paths for cross-platform compatibility
			foreach ( string path in DefaultPaths )
			{
				if ( Directory.Exists( path ) )
				{
					Core.DataDirectories.Add( path );
				}
			}

			if ( Core.DataDirectories.Count == 0 && !Core.Service )
			{
				Console.WriteLine( "Enter the Ultima Online directory:" );
				Console.Write( "> " );

				string? input = Console.ReadLine();
				if ( !string.IsNullOrEmpty( input ) )
				{
					Core.DataDirectories.Add( input );
				}
			}
		}
	}
}