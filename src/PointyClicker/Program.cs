
// Check the command line args for a --debug flag
using PointyClicker;
using System.Linq;

bool debug = args.Any(x => x == "--debug");

using var game = new PointyClickerGame(debug);
game.Run();
