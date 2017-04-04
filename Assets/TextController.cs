using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {

	public Text text;
	private enum States {cell, mirror, sheets_0, sheets_1, lock_0, lock_1, cell_mirror, freedom};
	private States myState;
	
	// Use this for initialization
	void Start () {
		myState = States.cell;
	}
	
	// Update is called once per frame
	void Update () {
		print (myState);
		if (myState == States.cell) {
			state_cell();
		} else if (myState == States.sheets_0) {
			state_sheets_0();
		}
	}
	
	void state_cell () {
			text.text = ("It was all a horrible mistake. ") +
						("The evidence was circumstancial at best, but you still ") +
						("wound up trapped in this prison. Now, it is time to leave.\n\n") +
						("The cell is damp and empty, save for a bed, it's filthy covers, ") +
						("and an old mirror on the wall. The door locks from the outside ofcourse, ") +
						("but there must be some way out of here... \n\n") +
						("Press S to view the Sheets, M to view the Mirror ") + 
						("or L to view the Lock.");
			
			if (Input.GetKeyDown(KeyCode.S)){
				myState = States.sheets_0;
			}
	}
	
	void state_sheets_0 () {
		text.text = ("The dirty sheets are the closest thing to comfort you've ") +
					("known since arriving here. Sadly there isn't a convenient ") +
					("window to shimmy down from, and you doubt a single ") +
					("bedsheet would do the trick regardless.\n\n") +
					("Press R to return.");
				
		
		if (Input.GetKeyDown(KeyCode.R)){
			myState = States.cell;
		}
	}
}