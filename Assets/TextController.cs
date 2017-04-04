using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {

	public Text text;
	
	// Use this for initialization
	void Start () {
		text.text = ("Press Space to begin!");
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space)){
			text.text = ("It was all a horrible mistake. ") +
						("The evidence was circumstancial at best, but still you ") +
						("wound up trapped in this prison. Now, it is time to leave.\n\n") +
						("The cell is damp and empty, save for a bed, it's filthy covers, ") +
						("and an old mirror on the wall. The door locks from the outside ofcourse, ") +
						("but there must be some way out of here... \n\n") +
						("Press S to view the Sheets, M to view the Mirror ") + 
						("or L to view the Lock.");
		}
	}
}
