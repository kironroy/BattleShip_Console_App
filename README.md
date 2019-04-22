# BattleShip_Console_App
_Battleship Console application written in C# with Visual Studio 2019_

#### Basic Requirements

*   Is the same console, or two different consoles working together? Same console
*   Does the other player get one last chance after being sunk? No
*   Do we want to capture/display stats such as hit/miss ratio etc.? Just how many shots it took to win
*   Only one ship per spot.
*   Do we allow a player to shoot the same spot twice? No
*   Do we show a visual of the grid? Yes
*   Do we store game data? No
*   Are we ever going to change number of players Maybe
*   Will we add a computer player? Maybe

#### Requirements &#8594; Answered

*   Is the same console, or two different consoles working together?
    
    Same console
    
*   Does the other player get one last chance after being sunk?
    
    No
    
*   Do we want to capture/display stats such as hit/miss ratio etc.?
    
    Just how many shots it took to win
    
*   Only one ship per spot.
*   Do we allow a player to shoot the same spot twice?
    
    No
    
*   Do we show a visual of the grid?
    
    Yes
    
*   Do we store game data?
    
    No
    
*   Are we ever going to change number of players
    
    Maybe
    
*   Will we add a computer player?
    
    Maybe
    

#### General Flow

1.    Two users open up the console
2.    Ask user 1 where to place their ships
3.    Ask user 1 where to place their ships
4.    Ask user 1 for a shot
5.         Determine hit or miss
6.         Determine if the game is over
7.    Ask user 2 for a shot
8.         Determine hit or miss
9.         Determine if game is over
10.    Repeat until someone wins
11.    Identify who the winner is
12.    Exit the application

#### UI Design

1.    Welcome message
2.    Add user 1 for their name
3.    Add user 1 for their 5 ship placements
4.         Ask for placement
5.         Determine if is valid spot
6.         Store
7.         Clear
8.    Ask user 2 for their name
9.    Ask user 2 for their 5 ship placements
10.         Ask for placement
11.         Determine if is a valid spot
12.         Store
13.         Clear
14.    Display grid of where user 1 is fired
15.    Ask user 1: where would you like to fire on
16.         Verify a valid spot
17.         Check results
18.         Store shot
19.         Clear
20.    Display the score (user 1: 2 ships left, user 2: 4 ships left)
21.    Repeat with user 2
22.    Loop until someone wins
23.    Print out Winner's name and number of shots taken
24.    Wait for the user to say they are done
25.    Exit

Grid Design:

       A1 A2 A3 O A5  
       B1 B2 B3 O B5  
       C1 C2 C3 X C5  
       D1 D2 D3 O D5  
       E1 E2 E3 O E5

#### Logic Design

*   Clear display
*   Method: Asking for name
*   Method: Get ship placement
*   Method: Determine if valid spot for ship
*   Storing ship information List per user?
*   Storing shot information List per user?
*   Method: create the grid for each user
*   Method: print out grid
*   Method: fire on opponent
*   Method: determine if a shot can be taken & outcome
*   Method: display score
*   Method: print winner and shots taken

#### Data Design

*   PlayerInfo
*   User's Name
*   Users 5 ship locations: List
*   User's shot/grid: List
*   GridSpot
*   SpotLetter: string
*   SpotNumber: int
*   Status string (possible enum)

#### Debugging

*   After the the grid displays, we need two empty lines.
*   Who is shooting?
*   Tell us the result of the shot and put one empty line in afterwards.
*   Put a space after the hit/miss to keep spacing accurate.
*   Winner not declared after all ships sunk.




