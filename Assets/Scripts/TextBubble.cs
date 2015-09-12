using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextBubble : MonoBehaviour {

    // Appearing text!
    public string TargetText;
    public int framesBetweenLetters;
    public Text targetGui;
    public int currentLetter;
    public int timer;


    string[] openingLines = { "I'm looking for someone who likes long walks by the sea of magma.",
                              "I want to spend the rest of eternity with someone really cool! But not in the temperature way.",
                              "I'd like to meet someone who has a burning passion for burning other things!" };

    // Use this for initialization
    void Start ()
    {
        targetGui.text = "";
        TargetText = openingLines[Random.Range(0, 3)];
        currentLetter = 0;
        timer = 0;
	}


	
	// Update is called once per frame
	void Update ()
    {
        if (timer == 0 && currentLetter < TargetText.Length)
        {
            targetGui.text = targetGui.text + TargetText.ToCharArray().GetValue(currentLetter);
            currentLetter += 1;
            timer = framesBetweenLetters;
        }
        timer--;
        

	}
}
