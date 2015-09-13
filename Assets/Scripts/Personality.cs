using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Personality : MonoBehaviour {

    // Personality Sliders, Range from -1.0 to 1.0
    public float Nice_To_Mean;
    public float Anxious_To_Outgoing;
    public float Laziness_Quotient;

    // The kind of person they're lookin for!
    public Personality DesiredPersonality;
 

	// Use this for initialization
	void Start ()
    {
        RandomizePersonality();
	}

    public void AddDesirable()
    {
        DesiredPersonality = gameObject.AddComponent<Personality>();
        DesiredPersonality.RandomizePersonality();
    }

    // Randomize the personality sliders
    void RandomizePersonality()
    {
        Nice_To_Mean = Random.Range(-1.0f, 1.0f);
        Anxious_To_Outgoing = Random.Range(-1.0f, 1.0f);
        Laziness_Quotient = Random.Range(-1.0f, 1.0f);
    }
	
	// Update is called once per frame
	void Update ()
    {
	
	}
}
