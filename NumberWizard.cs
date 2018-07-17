using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour {
	
	// Use this for initialization
	int max;
	int min;
	int guess;
	void Start () 
	{
		 StartGame();
	}
	
	void StartGame()
	{
		max=1000;
		min=1;
		guess=500;
		
		print("+++++++++++++++++++++++++++++++++++++++++++");
		print("welcome to Number Wizard");
		print("Pick a number and dont tell me");
		
		
		print (" The highest number you can pick is "    +max);
		max = max+1;
		print (" The lowest number you can pick is "   +min);
		
		print (" Is the number higher or lower than " +guess);
		
		/*print (" If the number is higher than 500 press up arrow");
		print (" If the number is lower than 500 press down arrow");
		print (" If the number is equal to 500 press Enter");
		*/
		print (" up = higher, down = lower, Return = Equal");
	}
	
// Update is called once per frame
	void Update () {
		
		if (Input.GetKeyUp(KeyCode.UpArrow)){
			// print("Up arrow pressed");
			min = guess;
			NextGuess ();
			
			}
		else if (Input.GetKeyUp(KeyCode.DownArrow)){
			
			//print("Down arrow pressed");
			max= guess;
			NextGuess ();
			
			}
		else if (Input.GetKeyUp(KeyCode.Return)){
			print("Won, Well Played");
			StartGame();
			}
		
		
	}
	void NextGuess()
	{
		guess = (min + max)/ 2;
		print ("Higher or lower than"  +guess);
		print (" up = higher, down = lower, Return = Equal");
	}
}
