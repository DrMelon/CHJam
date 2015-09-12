using UnityEngine;
using System.Collections;

public class SkinColor : MonoBehaviour {

	// Use this for initialization
	void Start () {

        SpriteRenderer thisFriend = this.GetComponent<SpriteRenderer>();
        int chooseColour = Random.Range(0, 6);
        switch (chooseColour)
        {
            case 0:
                thisFriend.color = Color.cyan;
                break;
            case 1:
                thisFriend.color = Color.yellow;
                break;
            case 2:
                thisFriend.color = Color.red;
                break;
            case 3:
                thisFriend.color = Color.magenta;
                break;
            case 4:
                thisFriend.color = Color.green;
                break;
            case 5:
                thisFriend.color = Color.white;
                break;
        }

        


    }

    // Update is called once per frame
    void Update () {
	
	}
}
