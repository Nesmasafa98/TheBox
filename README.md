# Connect 4
## Description
Connect 4 game provides a great experience for players where each 2 players can enter a room and start their own challenge.
Not only that, but players can enter the room as spectators and watch the ongoing game.
Players are allowed to create their own rooms, accept or reject a player upon joining the room, choose their own board size for a leveled up challenge
and pick a color for their coin to start playing.
## Scenario
1. Player logs into the game, after entering a unique username.
2. Player navigates through a menu, where he can enter play mode.
3. Play mode allows player to view all online players, available free rooms and full rooms.
4. Player can create a room then a dialog box appears requesting him to enter a unique room name, choose a suitable board size, choose his favourite color.
5. After creating the room, player enters the room and waits for other player to join.
6. If another player joined the room, the room owner then starts the game by pressing the play buttton.
7. The winner gets a message to congratulate him, while the loser receives a message saying that he has lost.
8. If a player wants to watch the game, he can select a room from the list of full rooms then press watch button.
9. If player is done, he signs out from the game.
## Design Patterns
- Memento
- Singleton
## Features
### Client
- Request user creation.
- View online players.
- View full rooms.
- View free rooms.
- Request room creation.
- Specify board size.
- Specify coin color.
- Join room as player.
- Join room as watcher.
### Server
- Create user.
- Create room.
- Instantiate game.
- Handle player's turn.
- Check player state.
## How to Use
- Run the server.
- Run the client.
- Enter username.
- Press Play.
- Press Create Room.
- Enter required data.
- Run another client.
- Navigate to Play.
- Double click on the shown room.
- The first client press play button.
