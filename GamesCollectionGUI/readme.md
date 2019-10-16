### Task
Create a Windows Form Application which allows the user to keep track of a computer games collections.

#### GUI Layout/Requirements:
  The GUI must contain the following (additional buttons and features can be added to enhance the user experience).
  1. A Lable named "Name:" and a TextBox which the user can enter the game name.
  2. A Lable named "Platform:" and a TextBox which the user can enter the game platform.
  3. A Lable named "Genre:" and a TextBox which the user can enter the game genre.
  4. A ListBox which displays all games in the games collection.
  5. A Add button which allows the user to add a game in the collection.
  6. A Delete button which allows the user to delete a game in the collection.
  7. A Update button which allows the user to update a game in the collection.
  8. A Clear button which clears the text from the Name, Platform and Genre TextBoxes.
  9. A Reset button which empties the game collection and reset it to 0.
  10. A Search button which when the user clicks it it searches for the game name into the Name TextBox.
  11. A Save button which saves the game collection to a mygames.dat file.
  12. A Open button which reads a game collection from the mygames.dat file.
  13. A ReadOnly TextBox which displays the number of games in the collection.
  
#### Logic Requirements:
  * Three global arrays will be needed to store the "string data", Name, Platform and Genre.
  * All three TextBoxes will need to contain text before a game can be added (a message box should be used to display warnings/errors).
  * Update Button, When a computer game is selected in the ListBox the Name, Platform and Genre TextBoxes should be populated with the appropriate text, once the Update button is selected the TextBoxes should then be cleared.
  * All games in the ListBox should be displayed in alphabetically order (using the Name field, ascending). The sort method MUST use Bubble Sorth algorithm and you may NOT use any built in methods.
  * Search Button, Should search for the name entered in the Name TextBox, if a game is found all TextBoxes should be populated with the appropriate text, if a game is not found a message should be displayed and the TextBoxes cleared.
  * Each of the TextBox controls should have a ToolTip text.
  * When the program is closed the game collection should automatically saved to the "mygames.dat" file.
  * When the program is opened the game collection should automatically open from the "mygames.dat" file and be displayed in the ListBox.
