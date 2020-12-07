# Queen Attack

#### In-class Practice Assignment during Epicodus Coding School, Practice with Classes, Methods, & Objects, & Other Foundational C# Concepts, 12.07.2020

#### By Danielle Thompson & Ben McFarland

## Description

In chess, a queen can move horizontally, vertically, and diagonally, making it the most powerful piece on the board. If another piece is within its line of sight along these three lines, the queen may attack it.

This console application allows the user to enter X and Y coordinates for both a queen and another chess piece. The program will return whether the queen is capable of 'attacking' the other chess piece.

## Technologies used

- C# v 7.3
- .NET Core v 2.2
- dotnet script, REPL

## Installation Requirements

#### Installing Git
###### For Mac Users

- Access Terminal in your Finder, and open a new window. Install the package manager, (Homebrew) [https://brew.sh/], on your device by entering this line of code in Terminal: `$ /usr/bin/ruby -e "$(curl -fsSL https://raw.githubusercontent.com/Homebrew/install/master/install)"`.
- Ensure Homebrew packages are run with this line of code: `echo 'export PATH=/usr/local/bin:$PATH' >> ~/.bash_profile`.
- Once homebrew is installed, install Git, a version control system for code writers, with this line of code `brew install git`.

###### For Windows Users

- Open a new Command Prompt window by typing "Cmd" in your computer's search bar.
- Determine whether you have 32-bit or 64-bit Windows by following these (instructions)[https://support.microsoft.com/en-us/help/13443/windows-which-version-am-i-running].
- Go to (Git Bash)[https://gitforwindows.org/], click on the "Download" button, and download the corresponding exe file from the Git for Windows site._
- Follow the instructions in the set up menu.

#### For Both Mac & Windows systems

- Once you have Git installed on your computer, go to this (GitHub repository)[https://github.com/harzulu/queen-attack], click the "Fork" button in the upper right hand corner of the page, and clone this application with the following command:`git clone https://github.com/harzulu/queen-attack.git`.


#### Installing C#, .NET, dotnet script, & MySQL

* Install C# and .Net according to your operating system below. 

###### For Mac
 * Download this .NET Core SDK (Software Development Kit)[https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.106-macos-x64-installer]. Clicking this link will prompt a .pkg file download from Microsoft.
* Open the .pkg file. This will launch an installer which will walk you through installation steps. Use the default settings the installer suggests.
* Confirm the installation is successful by opening your terminal and running the command $ dotnet --version, which should return something like: `2.2.105`. 

###### For Windows (10+)
* Download either the the 64-bit .NET Core SDK (Software Development Kit)[https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.203-windows-x64-installer]. Clicking these links will prompt a .exe file download from Microsoft.
* Open the file and follow the steps provided by the installer for your OS.
* Confirm the installation is successful by opening a new Windows PowerShell window and running the command dotnet --version. You should see something a response like this: `2.2.105`.

#### For Mac & Windows Operating Systems
* Install dotnet script with the following terminal command `dotnet tool install -g dotnet-script`.

#### Opening the Project on your Local System
Once the project has been cloned to your computer and you have all the necessary items on your local computer, open the project in the application of your choice ((Visual Code Studio)[https://code.visualstudio.com/] was used and is recommended by the application builder), and run the following...

* Navigate to the project folder on your Terminal or CMD.
* `dotnet build` will get bin/ and obj/ folders downloaded.
* `dotnet run` will run the application. 


### Specs

| Spec                                            | Input                        | Output                        |
| :---------------------------------------------- | :--------------------------- | :---------------------------- |
| ****    | User enters:  |  |
| **** | User enters:  |  |
| ****  | User enters:  |  |
| **** | User enters:  |  |

### Tests

Describe: queenAttack(x, y)
Test: queenAttack(userInputForQueen).toEqual(x1, y1)
Test: queenAttack(userInputForOtherPiece).toEqual(x2, y2)
Expect: queenAttack(x, y).toEqual(attack or naw)

Describe: MoveDiagonally()
((x + 1) && (y + 1)) || ((x - 1) && (y - 1)) || ((x + 1) && (y - 1)) || ((x - 1) && (y + 1))
if (x +- num) && (y +- num) == 2nd piece coordinates 


Describe: MoveHorizontally()
if y remains same && x +-

Describe: MoveVertically()
if x remains same && y +-

---------
(Maybe this is too specific, but at least for reference ...)
Describe: pieceMoves(x, y)

Can move in ...
- Knight: "L' shape (2, 1) || (1, 2)
- King: +-1 Up, down, L, R
- Rook: Horizontally, or vertically * any number to limit
- Bishop: Diagonally (x+-1, y+-1)
- Pawn: +-1 Up


Hints:
- When the user submits coordinates, the program should create an instance of a Queen class, with properties for its X and Y coordinates.
?? Find out how many squares are on a chess board - pre determine range for x & y coordinates. 8 x 8 (64 total squares). 
Graph: 16 squares (4x4) per quadrant. 
-x | x+
___|____
-y | y+
   |

- The Queen class should have a method that takes X and a Y coordinate as arguments, and returns true if the queen can attack the given space, and false if it cannot.
string queenCoord = Console.ReadLine(x, y)
string pieceCoord = Console.ReadLine(x2, y2)
QueenAttack(Console.WriteLine(T/F))

- A message should be displayed to inform the user of the results.
Console.WriteLine(results)

## Known bugs

No known bugs as of now. 

### Legal, or License

_MIT_ Copyright (c) 2020 **_Danielle Thompson, Ben McFarland_**