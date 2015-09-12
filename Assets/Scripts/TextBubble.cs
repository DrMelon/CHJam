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

	// Use this for initialization
	void Start ()
    {
        targetGui.text = "";
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
