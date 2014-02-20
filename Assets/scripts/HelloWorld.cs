using UnityEngine;
using System.Collections;

public class HelloWorld : MonoBehaviour {

	// this is a VARIABLE, a piece of data that remembers our "current room" / position in world
	string currentRoom = "Some Place";

	// Use this for initialization
	void Start () {
		// if you see "//" that's a comment, NOT code that is run
		// all instructions have to go inside functions
		Debug.Log ( "Hello World" );

	}
	
	// Update is called once per frame
	void Update () {

				GetComponent<TextMesh> ().text = "Some Place";

				// when you use an "if/else" structure, only ONE of those
				// blocks will ever run, it is an either/or scenario!
				if (currentRoom == "Some Place") {
						GetComponent<TextMesh> ().text += "\nYou are in Some Place.";
						GetComponent<TextMesh> ().text += "\nFind the food.";
						GetComponent<TextMesh> ().text += "\nPress [T] to look in a tree.";


						if (Input.GetKeyDown (KeyCode.T)) {
								currentRoom = "tree";
						}

				} else if (currentRoom == "tree") {
						GetComponent<TextMesh> ().text += "\nYou climb in the tree, fall, and break your arm.";
						GetComponent<TextMesh> ().text += "\nTry the lake. Press [L]";

				}



				if (Input.GetKeyDown (KeyCode.L)) {
						currentRoom = "lake";
				} else if (currentRoom == "lake") {
						GetComponent<TextMesh> ().text += "\nA fish aquirts water in your eye.";
						GetComponent<TextMesh> ().text += "\nTry looking in a rabbit hole. Press [H]";
		
				}



				if (Input.GetKeyDown (KeyCode.H)) {
						currentRoom = "hole";
				} else if (currentRoom == "hole") {
						GetComponent<TextMesh> ().text += "\nA rabbit jumps out and bites you. Stupid rabbit.";
						GetComponent<TextMesh> ().text += "\nYou could give up and starve. Press [S]";

				}



						if (Input.GetKeyDown (KeyCode.S)) {
								currentRoom = "starve";
						} else if (currentRoom == "starve") {
								GetComponent<TextMesh> ().text += "\nIf you starve, you'll die.";
								GetComponent<TextMesh> ().text += "\nTry eating dirt. Press [D]";
			
						}




						if (Input.GetKeyDown (KeyCode.D)) {
								currentRoom = "dirt";
						} else if (currentRoom == "dirt") {
								GetComponent<TextMesh> ().text += "\nIt's not that tasty.";
								GetComponent<TextMesh> ().text += "\nTry looking in a wolf cave. Press [C]";
				
						}


						if (Input.GetKeyDown (KeyCode.C)) {
								currentRoom = "cave";
						} else if (currentRoom == "cave") {
								GetComponent<TextMesh> ().text += "\nYou find berries, meat, and other types of food.";
								GetComponent<TextMesh> ().text += "\nJACKPOT!!!!";
								GetComponent<TextMesh> ().text += "\nTake the food. Press [F]";
				
						}


						if (Input.GetKeyDown (KeyCode.F)) {
								currentRoom = "food";
						} else if (currentRoom == "food") {
								GetComponent<TextMesh> ().text += "\nYou try and carry the food out of the cave.";
								GetComponent<TextMesh> ().text += "\nYou're then approached by a bunch of wolves.";
								GetComponent<TextMesh> ().text += "\nThe wolves jump towards you and eat you.";
								GetComponent<TextMesh> ().text += "\nAtleast someone got to eat.";
								GetComponent<TextMesh> ().text += "\nTHE END?";
				
						}
						{

								{
								}
						
						

				} // closes out Update (), from line 18
		}
}