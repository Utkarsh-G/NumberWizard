using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour {

	int highNumber;
	int lowNumber;
	int guess;
    int maxGuessesAllowed = 10;
    public Text numberDisplay;
    public LevelManager myManager;
    public ImageRadomizer imgRandomizer;
	// Use this for initialization
	void Start () {
		
		StartGame();
	}
	
	void StartGame()
	{
        /*
		//highNumber = highNumber + 1;
		print ("=======================");
		print ("Welcome to Number Wizard");
		print ("Pick a number in your head.");
		*/
		highNumber = 1001;
		lowNumber = 1; 
        guess = Random.Range(1, 1001);
        numberDisplay.text = "I guess you are thinking... " + guess.ToString();
        /*
		print("The highest number is " + highNumber);
		print("The lowest number is " + lowNumber);
		
		print ("Is the number higher or lower than " + guess);
        */      
	}
	
	void NextGuess()
	{

        imgRandomizer.SetThinkingImage();

        maxGuessesAllowed--;
        if (maxGuessesAllowed <= 0)
        {
            myManager.LoadLevel(2);
        }
        
        guess = Random.Range(lowNumber, highNumber + 1);//(highNumber + lowNumber)/ 2;
        if (maxGuessesAllowed != 1)
        {
            numberDisplay.text = "Gimme " + maxGuessesAllowed.ToString() +
                " more tries. \nI guess you are thinking... " + guess.ToString();
        }

        if (maxGuessesAllowed == 1)
        {
            numberDisplay.text = "Gimme 1 more try. \nI guess you are thinking... " + guess.ToString();
        }

        /*
		print ("Is the number higher or lower than " + guess);
		print ("Up = higher, down = lower, return = equal");
        */      
				
	}
	// Update is called once per frame
	void Update () {
	
        /*
		if(Input.GetKeyDown(KeyCode.UpArrow)){
			//print ("Up arrow pressed");
			lowNumber = guess;
			NextGuess();
						
		} else if(Input.GetKeyDown(KeyCode.DownArrow)){
			//print ("Down arrow pressed");
			highNumber = guess;
			NextGuess();
						
		} else if(Input.GetKeyDown(KeyCode.Return)){
			print ("I won");
			StartGame();
		}
        */      
	}

    public void GuessHigher()
    {
        lowNumber = guess;
        NextGuess();
    }

    public void GuessLower()
    {
        highNumber = guess;
        NextGuess();
    }

    //public void 
}
