using UnityEngine;
using System.Collections;

public class MatchmakerScript : MonoBehaviour {

    public GameObject templateFriend;
    public GameObject templateBubble;

    public GameObject PersonA;
    // Person A Pos at Scale 1.1441: (scale x negative)
    // -6.2f -0.69f 0.00f
    public GameObject BubbleA;

    public GameObject PersonB;
    public GameObject BubbleB;

    // Use this for initialization
    void Start ()
    {
        // Create person A!
        PersonA = (GameObject)Instantiate(templateFriend, new Vector3(-6.2f, -0.69f, 0.00f), Quaternion.identity);
        PersonA.transform.localScale = new Vector3(-1.1441f, 1.1441f, 1.1441f);
        // Create bubble A!


	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
