using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {

	public Text text;
	private enum States {cell, mirror, sheets_0, sheets_1, lock_0, lock_1, cell_mirror, corridor_0, stairs_0};
	private States myState;
	
	// Use this for initialization
	void Start () {
		myState = States.cell;
	}
	
	// Update is called once per frame
	void Update () {
		print (myState);
		//Section 1 States
		if 		(myState == States.cell) 		{cell();} 
		else if (myState == States.sheets_0) 	{sheets_0();}
		else if (myState == States.lock_0) 		{lock_0();}
		else if (myState == States.mirror) 		{mirror ();} 
		else if (myState == States.cell_mirror) {cell_mirror ();} 
		else if (myState == States.sheets_1) 	{sheets_1 ();} 
		else if (myState == States.lock_1) 		{lock_1 ();}
		else if (myState == States.corridor_0) 	{corridor_0 ();}
		else if (myState == States.stairs_0)	{stairs_0 ();}
	}
	//Section 1 - Cell to Corridor
	void cell () {
			text.text = ("It was all a horrible mistake. ") +
						("The evidence was circumstancial at best, but you still ") +
						("wound up trapped in this prison. Now, it is time to leave.\n\n") +
						("The cell is damp and empty, save for a bed, it's filthy covers, ") +
						("and an old mirror on the wall. The door locks from the outside ofcourse, ") +
						("but there must be some way out of here... \n\n") +
						("Press S to view the Sheets, M to view the Mirror ") + 
						("or L to view the Lock.");
			
			if (Input.GetKeyDown(KeyCode.S))	{myState = States.sheets_0;}
			if (Input.GetKeyDown(KeyCode.L))	{myState = States.lock_0;}
			if (Input.GetKeyDown(KeyCode.M))	{myState = States.mirror;}
	}
	
	void sheets_0 () {
		text.text = ("The dirty sheets are the closest thing to comfort you've ") +
					("known since arriving here.\n\nSadly there isn't a convenient ") +
					("window to shimmy down from, and you doubt a single ") +
					("bedsheet would do the trick regardless.\n\n") +
					("Press R to return.");
				
		
		if (Input.GetKeyDown(KeyCode.R))	{myState = States.cell;}
	}
	
	void lock_0 () {
		text.text = ("Through the cell bars you can just about make out the edge of ") +
					("the keypad lock.\n\nKnowing how disgusting the guards are here, ") +
					("you wouldn't be surprised if they left grubby fingerprints all ") +
					("over the buttons.\n\n") +
					("Press R to return.");
		
		
		if (Input.GetKeyDown(KeyCode.R))	{myState = States.cell;}
	}
	
	void mirror () {
		text.text = ("This grubby old mirror is hanging down at a terrible angle. ") +
					("It looks as though one of the screws holding it up is long gone. ") +
					("\n\nYou could probably rip it off the wall easily enough.\n\n") +
					("Press T to take the mirror, or R to return");
							
		
		if (Input.GetKeyDown(KeyCode.R))	{myState = States.cell;}
		if (Input.GetKeyDown(KeyCode.T))	{myState = States.cell_mirror;}
	}
	
	void cell_mirror () {
		text.text = ("The mirror comes off the wall easily, along with copious amounts ") +
					("of dust. Judging by the wall behind it, this cell was actually ") +
					("painted at some point.\n\nNot so much now.\n\n") +
					("Press S to view the Sheets, or L to view the Lock.");
		
		
		if (Input.GetKeyDown(KeyCode.S)) {myState = States.sheets_1;}
		if (Input.GetKeyDown(KeyCode.L)) {myState = States.lock_1;}
	}
	
	void sheets_1 () {
		text.text = ("You try to wipe the dust away from the mirror with ") +
					("limited success. But hey, those sheets are dirtier now.\n\n") +
					("Press R to return.");
		
		
		if (Input.GetKeyDown(KeyCode.R)) {myState = States.cell_mirror;}
	}
	
	void lock_1 () {
		text.text = ("It's not terribly comfortable, but you can just stretch enough ") +
					("to see the reflection of the worn keypad. Three numbers stand out ") +
					("as particularly well used.\n\n") +
					("Press O to try to open the cell or press R to return.");
		
		
		if (Input.GetKeyDown(KeyCode.R)) {myState = States.cell_mirror;}
		if (Input.GetKeyDown(KeyCode.O)) {myState = States.corridor_0;}
	}
		
	//Section 2 - Corridor to Courtyard
	void corridor_0 () {
		text.text = ("After a few failed attempts a loud buzz permeates the cell. ") +
					("The door swings open under your weight as you stumble into the ") +
					("corridor.\n\nTo your left is door with the word 'Janitor' on ") +
					("a faded sign. The corridor ends in staircase leading up.\n\n") +
					("Press S to look up the Stairs, C to try the closet door or F to ") +
					("look around on the corridor.");
					
		if (Input.GetKeyDown(KeyCode.S)){myState = States.stairs_0;}
	}
	void stairs_0 () {
		text.text = ("A steep narrow staircase leads up to a heavy steel door. ") +
					("Through the small window, you can see the blurred shadows ") +
					("of staff walking by.\n\nPress R to return.");
					
		
		if (Input.GetKeyDown(KeyCode.R)){myState = States.corridor_0;}
	}				
}