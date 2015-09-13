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
    public AudioClip bipsound;
    AudioSource myAudio;
    public bool pitchshifter;
    float voicePitch;

    string[] openingLines = { "I'm looking for someone who likes long walks by the sea of magma.",
                              "I want to spend the rest of eternity with someone really cool! But not in the temperature way.",
                              "I'd like to meet someone who has a burning passion for burning other things!" };

    // Use this for initialization
    void Start ()
    {
        myAudio = gameObject.AddComponent<AudioSource>();
        Reset(openingLines[Random.Range(0, 3)]);
        
	}

    void Reset(string newtext)
    {
        targetGui.text = "";
        TargetText = newtext;
        currentLetter = 0;
        timer = 0;
        // new voice
        voicePitch = Random.Range(0.8f, 1.2f);
    }

	
	// Update is called once per frame
	void Update ()
    {
        if (timer == 0 && currentLetter < TargetText.Length)
        {
            targetGui.text = targetGui.text + TargetText.ToCharArray().GetValue(currentLetter);
            currentLetter += 1;
            timer = framesBetweenLetters;

            if (myAudio != null)
            {
                if (pitchshifter)
                {
                    myAudio.pitch = Random.Range(0.9f, 1.1f);
                }
                else
                {
                    myAudio.pitch = voicePitch;
                }

                myAudio.PlayOneShot(bipsound);
            }
        }
        timer--;
        

	}
}
