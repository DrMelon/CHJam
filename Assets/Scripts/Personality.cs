using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Personality : MonoBehaviour {

    // Personality Sliders, Range from -1.0 to 1.0
    public float Slider_NiceMean = 0.0f;
    public float Slider_OutgoingShy = 0.0f;
    public float Slider_ActiveLazy = 0.0f;

    // Visual Aspects
    public int ChosenHead; //head includes ears and neck
    public int ChosenEyes;
    public int ChosenNose;
    public int ChosenMouth;
    public int ChosenHairFront;
    public int ChosenHairBack;
    public int ChosenHeadGrowths; //horns, animal ears
     // todo- split clothing into greater categories
    public int ChosenClothing;
    public int ChosenJewellery;
    // possible multiples? 
    public int ChosenTailsWingsCapes;

    // List of paperdollable parts - picked from a global list somewhere
    public List<BodyPart> ChosenParts;

    


	// Use this for initialization
	void Start ()
    {
	
	}

    // Randomize the personality sliders
    void RandomizePersonality()
    {
        
    }

    // Pick the appropriately tagged body pieces by probability markers based on personality
    void SortAndPickPieces()
    {

    }

    // Once pieces are picked, paperdoll them together to make a person
    void PaperDolling()
    {

    }


	
	// Update is called once per frame
	void Update ()
    {
	
	}
}
