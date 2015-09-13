using UnityEngine;
using System.Collections;

public class MatchmakerScript : MonoBehaviour {

    public GameObject templateFriend;
    public GameObject templateBubble;
    public GameObject dimmer;
    public GameObject backbutton;

    public GameObject PersonA;
    // Person A Pos at Scale 1.1441: (scale x negative)
    // -6.2f -0.69f 0.00f
    public GameObject BubbleA;
    // Bubble A pos -2.63, 4.08
    // Scale 1.15

    public GameObject PersonB;
    public GameObject BubbleB;

    public float CurrentMatchPercent;

    public bool CurrentlyMatchmaking = false;

    public int MatchesLeft = 4;

    // Use this for initialization
    void Start ()
    {
        // Assign self to global script
        Global.theMatchmaker = this;

        // Create person A!
        PersonA = (GameObject)Instantiate(templateFriend, new Vector3(-6.2f, -0.69f, 0.00f), Quaternion.identity);
        PersonA.GetComponent<Personality>().AddDesirable();
        PersonA.transform.localScale = new Vector3(-1.1441f, 1.1441f, 1.1441f);
        // Create bubble A!
        BubbleA = (GameObject)Instantiate(templateBubble, new Vector3(-2.63f, 4.08f, 0.0f), Quaternion.identity);
        BubbleA.transform.localScale = new Vector3(1.15f, 1.15f, 1.15f);


        PersonB = null;
        

	}

    public void BeginMatchmaking()
    {
        CurrentlyMatchmaking = true;

        // Create person B, slide them up into the screen.
        PersonB = (GameObject)Instantiate(templateFriend, new Vector3(5.23f, -8.5f, 0.00f), Quaternion.identity);
        PersonB.transform.localScale = new Vector3(1.1441f, 1.1441f, 1.1441f);
        PersonB.GetComponent<Personality>().AddDesirable();


        // Create hud stuff.


        // DEBUG: show suitability
        CurrentMatchPercent = DetermineSuitablityPercentage();
        print(CurrentMatchPercent);
    }

    public void StopMatchmaking()
    {
        CurrentlyMatchmaking = false;
        MatchesLeft--;
        if (MatchesLeft <= 0)
        {
            DoGameOver();
        }

    }

    public void DoGameOver()
    {
        // matched with nobody, display oh no!!
    }

    public void DoWin()
    {
        // got a match! test their quality, display epilogue.
    }

    public void VerifyMatchmaking()
    {
        // Brand approved or do failure

    }

    public float DetermineSuitablityPercentage()
    {
        Personality PersonAPersonality = PersonA.GetComponent<Personality>();
        Personality PersonBPersonality = PersonB.GetComponent<Personality>();

        float SuitabilityAPercentage = 0.0f;
        float SuitabilityBPercentage = 0.0f;
        float MeanSuitability = 0.0f;

        float SimilarityIndex = 0.4f; // game "difficulty" i guess haha

        // Suitability is calculated for A and B's view of eachother.
        // Best is 100% for each.
        // Suitability is added from wanted traits, matching traits, and clothing.
        // Wanted Traits: Add 10% (for Max of 30%)
        // Matching Traits: Add 15% (for Max of 45%)
        // Clothing: Add 5% per item ( 5 items, max of 25%)

        // Matching traits are discovered by checking to see if they are within 0.20 of eachother.

        // 'Wanted' personality traits boost suitablity a little.
        if(Mathf.Abs(PersonBPersonality.Nice_To_Mean - PersonAPersonality.DesiredPersonality.Nice_To_Mean) <= SimilarityIndex)
        {
            SuitabilityAPercentage += 10.0f;
        }
        if (Mathf.Abs(PersonBPersonality.Laziness_Quotient - PersonAPersonality.DesiredPersonality.Laziness_Quotient) <= SimilarityIndex)
        {
            SuitabilityAPercentage += 10.0f;
        }
        if (Mathf.Abs(PersonBPersonality.Anxious_To_Outgoing - PersonAPersonality.DesiredPersonality.Anxious_To_Outgoing) <= SimilarityIndex)
        {
            SuitabilityAPercentage += 10.0f;
        }
        if (Mathf.Abs(PersonAPersonality.Nice_To_Mean - PersonBPersonality.DesiredPersonality.Nice_To_Mean) <= SimilarityIndex)
        {
            SuitabilityBPercentage += 10.0f;
        }
        if (Mathf.Abs(PersonAPersonality.Laziness_Quotient - PersonBPersonality.DesiredPersonality.Laziness_Quotient) <= SimilarityIndex)
        {
            SuitabilityBPercentage += 10.0f;
        }
        if (Mathf.Abs(PersonAPersonality.Anxious_To_Outgoing - PersonBPersonality.DesiredPersonality.Anxious_To_Outgoing) <= SimilarityIndex)
        {
            SuitabilityBPercentage += 10.0f;
        }

        // Matching personality traits boost suitability a little more.
        if (Mathf.Abs(PersonBPersonality.Nice_To_Mean - PersonAPersonality.Nice_To_Mean) <= SimilarityIndex)
        {
            SuitabilityAPercentage += 15.0f;
        }
        if (Mathf.Abs(PersonBPersonality.Laziness_Quotient - PersonAPersonality.Laziness_Quotient) <= SimilarityIndex)
        {
            SuitabilityAPercentage += 15.0f;
        }
        if (Mathf.Abs(PersonBPersonality.Anxious_To_Outgoing - PersonAPersonality.Anxious_To_Outgoing) <= SimilarityIndex)
        {
            SuitabilityAPercentage += 15.0f;
        }
        if (Mathf.Abs(PersonAPersonality.Nice_To_Mean - PersonBPersonality.Nice_To_Mean) <= SimilarityIndex)
        {
            SuitabilityBPercentage += 15.0f;
        }
        if (Mathf.Abs(PersonAPersonality.Laziness_Quotient - PersonBPersonality.Laziness_Quotient) <= SimilarityIndex)
        {
            SuitabilityBPercentage += 15.0f;
        }
        if (Mathf.Abs(PersonAPersonality.Anxious_To_Outgoing - PersonBPersonality.Anxious_To_Outgoing) <= SimilarityIndex)
        {
            SuitabilityBPercentage += 15.0f;
        }

        // Matching cosmetic items boost suitability a little less.
        if(PersonA.GetComponentInChildren<HairScript>().gameObject.GetComponent<SpriteRenderer>().sprite.name == PersonB.GetComponentInChildren<HairScript>().gameObject.GetComponent<SpriteRenderer>().sprite.name)
        {
            SuitabilityAPercentage += 5.0f;
            SuitabilityBPercentage += 5.0f;
            print("HAIR MATCH");
        }

        // Find average suitability
        MeanSuitability = (SuitabilityAPercentage + SuitabilityBPercentage) / 2.0f;

        return MeanSuitability;
    }

	
	// Update is called once per frame
	void Update ()
    {
        if (CurrentlyMatchmaking)
        {
            if (PersonB && PersonB.transform.position.y < -0.65f)
            {
                PersonB.transform.position = PersonB.transform.position + new Vector3(0.0f, 0.1f, 0.0f);
            }
            if (dimmer)
            {
                if (dimmer.GetComponent<Renderer>().material.color.a < (200.0f / 256.0f))
                {
                    dimmer.GetComponent<Renderer>().material.color = dimmer.GetComponent<Renderer>().material.color + new Color(0, 0, 0, 0.02f);
                }

            }
            if(backbutton)
            {
                backbutton.GetComponent<Renderer>().material.color = Color.white;
            }

        }
        else
        {
            if (PersonB && PersonB.transform.position.y > -9.5f)
            {
                PersonB.transform.position = PersonB.transform.position - new Vector3(0.0f, 0.1f, 0.0f);
            }
            if (dimmer)
            {
                if (dimmer.GetComponent<Renderer>().material.color.a > (0.0f))
                {
                    dimmer.GetComponent<Renderer>().material.color = dimmer.GetComponent<Renderer>().material.color - new Color(0, 0, 0, 0.02f);
                }

            }
            if (backbutton)
            {
                backbutton.GetComponent<Renderer>().material.color = Color.clear;
            }
        }

	}
}
