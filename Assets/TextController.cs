using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {

	public Text text;
	private enum States {cell, mirror, sheets_0, sheets_1, lock_0, lock_1, cell_mirror, corridor_0, stairs_0, closet_door, floor, corridor_1, stairs_1, in_closet, corridor_2, stairs_2, corridor_3, courtyard, freedom};
	private States myState;
	
	// Use this for initialization
	void Start () {
		myState = States.cell;
	}
	
	// Update is called once per frame
	void Update () {
		print (myState);
		//Section 1 States
		if 		(myState == States.cell) 			{cell();} 
		else if (myState == States.sheets_0) 		{sheets_0();}
		else if (myState == States.lock_0) 			{lock_0();}
		else if (myState == States.mirror) 			{mirror ();} 
		else if (myState == States.cell_mirror) 	{cell_mirror ();} 
		else if (myState == States.sheets_1) 		{sheets_1 ();} 
		else if (myState == States.lock_1) 			{lock_1 ();}
		else if (myState == States.corridor_0) 		{corridor_0 ();}
		else if (myState == States.stairs_0)		{stairs_0 ();}
		else if (myState == States.closet_door)		{closet_door ();}
		else if (myState == States.floor)			{floor ();} 
		else if (myState == States.corridor_1)		{corridor_1 ();}
		else if (myState == States.stairs_1)		{stairs_1 ();}
		else if (myState == States.in_closet)		{in_closet ();}
		else if (myState == States.corridor_2)		{corridor_2 ();}
		else if (myState == States.stairs_2)		{stairs_2 ();}
		else if (myState == States.corridor_3)		{corridor_3 ();}
		else if (myState == States.courtyard)		{courtyard ();}
		else if (myState == States.freedom)			{freedom ();}
	}
	//Section 1 - Cell to Corridor
	void cell () {
			text.text = ("It was all a horrible mistake. ") +
						("The evidence was circumstancial at best, but you still ") +
						("wound up trapped in this prison. Now, it is time to leave.\n\n") +
						("The cell is damp and empty, save for a bed, its filthy covers ") +
						("and an old mirror on the wall. The door locks from the outside of course, ") +
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
		text.text = ("This old mirror is hanging down at a terrible angle. ") +
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
					("corridor.\n\nTo your left is a door bearing the word 'Janitor' on ") +
					("a faded sign. The corridor ends in staircase leading up.\n\n") +
					("Press S to look up the Stairs, C to try the closet door or F to ") +
					("look around on the floor.");
					
		if (Input.GetKeyDown(KeyCode.S)) {myState = States.stairs_0;}
		if (Input.GetKeyDown(KeyCode.C)) {myState = States.closet_door;}
		if (Input.GetKeyDown(KeyCode.F)) {myState = States.floor;}
	}
	void stairs_0 () {
		text.text = ("A steep narrow staircase leads up to a heavy steel door. ") +
					("Through the small window, you can see the blurred shadows ") +
					("of staff walking by.\n\nPress R to return.");
					
		
		if (Input.GetKeyDown(KeyCode.R)) {myState = States.corridor_0;}
	}
	
	void closet_door () {
		text.text = ("The paint is peeling from this old wooden door.\n\nA quick ") +
					("try of the handle reveals that the door is well and truly ") +
					("locked.\n\nPress R to return.");
		
		
		if (Input.GetKeyDown(KeyCode.R)) {myState = States.corridor_0;}
	}
	
	void floor () {
		text.text = ("Despite the sign on the closet, you're pretty sure this ") +
					("floor has never been cleaned.\n\nLooking through some old mothballs ") +
					("and rat droppings you find an old hairpin caked in the dirt.") +
					("\n\nPress H to take the Hairclip or press R to return.");
		
		
		if (Input.GetKeyDown(KeyCode.R)) {myState = States.corridor_0;}
		if (Input.GetKeyDown(KeyCode.H)) {myState = States.corridor_1;} 
	}
	
	void corridor_1 () {
		text.text = ("You take a few moments to try to wipe your hand down on your overalls. ") +
					("The hairpin is old and plain, but might still be strong enough ") +
					("to prove useful. Good job you watched all those spy movies as a ") +
					("kid.\n\nPress S to check the Stairs or press P to pick the closet's lock.");
		
		
		if (Input.GetKeyDown(KeyCode.S)) {myState = States.stairs_1;}
		if (Input.GetKeyDown(KeyCode.P)) {myState = States.in_closet;} 
	}	
	
	void stairs_1 () {
		text.text = ("Noone seems interested in coming down here at the moment, but there's ") +
					("no telling when that could change. The door itself doesn't seem to be ") +
					("locked though.\n\nProbably still not best to just walk out.") +
					("\n\nPress R to return.");
		
		
		if (Input.GetKeyDown(KeyCode.R)) {myState = States.corridor_1;}
	}
	
	void in_closet () {
		text.text = ("The door swings open with little effort. ") +
					("No expense spared for security down here eh?\n\nThe closet itself is ") +
					("fairly sparse, but a set of cleaner's overalls hang limply from an open ") +
					("locker. \n\nPress D to Dress as a cleaner, or press R to return.");
		
		
		if (Input.GetKeyDown(KeyCode.R)) {myState = States.corridor_2;}	 
		if (Input.GetKeyDown(KeyCode.D)) {myState = States.corridor_3;}	
	}	
	
	void corridor_2 () {
		text.text = ("The corridor remains eerily quiet, save for the occasional distant bark ") +
					("of the prison's Security Dogs.\n\nThat thought kills a little for your ") +
					("optimism.\n\n Press S to check the Stairs, or press C to return to the closet.");				
		
		
		if (Input.GetKeyDown(KeyCode.S)) {myState = States.stairs_2;}
		if (Input.GetKeyDown(KeyCode.C)) {myState = States.in_closet;}	
	}
	
	void stairs_2 () {
		text.text = ("The door remains shut, but with every passing second your nerves build. ") +
					("You can't afford to waste this chance. Perhaps it's time for a disguise...") +
					("\n\nPress R to return.");
		
		
		if (Input.GetKeyDown(KeyCode.R)) {myState = States.corridor_2;}	
	}
	
	void corridor_3 () {
		text.text = ("It's a loose fit, but you manage to slip into the Janitor's clothes. ") +
					("With this you think you should look the part to slip out of here at last.\n\n") +
					("Hopefully you won't bump into anyone that knows better.") +
					("\n\nPress S to climb the Stairs, or U to Undress and return to the closet.");
		
		
		if (Input.GetKeyDown(KeyCode.S)) {myState = States.courtyard;}
		if (Input.GetKeyDown(KeyCode.U)) {myState = States.in_closet;}
	}		  	
	
	void courtyard () {
		text.text = ("Luckily noone seems to take notice of you as you emerge from the staircase ") +
					("and cross the hall to an emergency exit.\n\n") +
					("The door exits onto an open courtyard, bustling with staff and cars. The ") +
					("gates at the far end are wide open. This is it. Freedom.") +
					("\n\nPress R to run.");
		
		
		if (Input.GetKeyDown(KeyCode.R)) {myState = States.freedom;}		
	}
	
	void freedom () {
		text.text = ("You walk briskly across the courtyard, desperately trying not to look ") +
					("out of place. Soon you pass the gate and reach the street beyond.\n\n") +
					("You pick a direction and keep walking, rounding a corner just as sirens ") +
					("blare from the prison behind you. But this time you won't be going back.\n\n") +
					("You are free.\n\nPress P to play again.");
		
		
		if (Input.GetKeyDown(KeyCode.P)) {myState = States.cell;}
	}
}
