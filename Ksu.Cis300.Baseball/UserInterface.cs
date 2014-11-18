/* UserInterface.cs
 * Author: Kevin Harrison Manase
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ksu.Cis300.Baseball
{
    public partial class UserInterface : Form
    {
        public UserInterface()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Store data taken from the CSV file
        /// </summary>
        private void TeamData()
        {
            /*
             * Each instance of this class will be used to store data taken from a single line of the "TEAMABR.csv" file. Because instances of this class will need to be sorted, it needs to implement the IComparable<TeamData> interface.
It will need public properties for getting the following values:
The team's abbreviation.
The city or other location in which the team played.
The team's nickname.
The first year in which the team played in this location.
The last year in which the team played in this location.
It will also need a public constructor that takes a string[ ] containing the contents of the five fields from a line in "TEAMABR.csv".
Because instances of this class will need to be added to the ComboBox in the main GUI, you will need to override the ToString method so that it returns the string that should be displayed in the ComboBox (see under "The 'Add Data File' Button" above).
Finally, in order to implement the IComparable<TeamData> interface, it will need to define a public CompareTo method. This method should take as its parameter a TeamData and return an int that indicates how the 2 objects compare:
a negative value indicates that this is less than the parameter;
0 indicates that the objects are equal; and
a positive value indicates that this is greater than the parameter.
In order that the items in the ComboBox appear in alphabetic order, the comparison needs to be done by comparing the values returned by the objects' ToString methods. Because a string's CompareTo method returns values consistent with the IComparable.CompareTo method, you can simply return the result of calling this method.
             */
        }

        /// <summary>
        /// Data for a single game
        /// </summary>
        private void GameData()
        {
            /*
             * The GameData Class

Each instance of this class will store information to be displayed for a single game. It will need public properties for getting the following values:
The date of the game. This needs to be of type DateTime.
A string containing the home team's location and nickname, separated by a space.
The home team's abbreviation.
The home team's score.
A string containing the visiting team's location and nickname, separated by a space.
The visiting team's abbreviation.
The visiting team's score.
The winning pitcher.
The losing pitcher.
The pitcher credited with a save.
The batter who drove in the game-winning run.
In order to initialize this information, you will need a public constructor that takes as parameters a string[ ] containing the first 101 fields from a line of a game log and a Dictionary<string, TeamData> containing the data for all of the teams, keyed by their abbreviations. You can use the Dictionary to obtain the team's location and nickname. All of the other information should be present in the string[ ]. To construct a DateTime, you will first need to obtain the year, month, and day by taking appropriate substrings (see the string's Substring(int, int) method) of the date field and converting them to int. You can then pass these values to the DateTime constructor.
             */
        }

        /// <summary>
        /// Team data on a certain date
        /// </summary>
        private void TeamAndDate()
        {
            /*
             * The TeamAndDate Structure

Instances of this class will contain a team abbreviation and a date (stored as a DateTime). These instances will be used as keys in a dictionary. Because this will be the only use of these instances, it will not be necessary to provide public properties to access either the team abbreviation or the date. You will, however, need to provide a public constructor to initialize these values.
You can create a structure file in Visual Studio by first creating a class file, then changing the keyword class to struct. A structure is preferable to a class for this type because it contains a relatively small amount of data. For more information on structures, see "Structures".
In order to use instances of this class as keys, you will need to override the GetHashCode method. Because the primary use of this structure is for keys in a dictionary, compute the hash code within the constructor. As a result, the hash code will always have been computed, and the GetHashCode method can simply return it. You should implement polynomial hashing, as described in the slides for Lab Assignment 29 and in "Hash Functions". The components of the key should be each character in the abbreviation and the year, month, and day from the date (you can access the last 3 values from the date's Year, Month, and Day properties). Use 39 as your multiplier.
You will also need to implement the methods to test for equality (see Lab Assignment 28 and "Equality in C#"). Because this type is a value type, you do not need to check for null values in the == operator. Consider two TeamAndDates to be equal if their respective abbreviations, years, months, and days are equal. (Don't just compare the DateTimes, as they will both store times in addition to dates, and the times might be different.)
             */
        }
    }
}
