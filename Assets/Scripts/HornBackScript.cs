using UnityEngine;
using System.Collections.Generic;

public class HornBackScript : MonoBehaviour {

    public HornScript parentHorn;
    public SpriteRenderer parentHornSprite;
    public List<Sprite> hornList;

    // Use this for initialization
    void Start ()
    {
	    if(parentHorn.HasHorns && parentHornSprite.sprite.name != "horn4front")
        {
            this.GetComponent<SpriteRenderer>().color = Color.white;
        }
        else
        {
            this.GetComponent<SpriteRenderer>().color = Color.clear;
        }
        SpriteRenderer sprrend = this.GetComponent<SpriteRenderer>();
        if (parentHornSprite.sprite.name == "horn1front")
        {
            sprrend.sprite = hornList[0];
            // pos
            this.transform.localPosition = new Vector3(-1.05f, 2.85f, 0.29f);
        }
        if (parentHornSprite.sprite.name == "horn2front")
        {
            sprrend.sprite = hornList[1];
            // pos
            this.transform.localPosition = new Vector3(-1.05f, 2.85f, 0.29f);
        }
        if (parentHornSprite.sprite.name == "horn3front")
        {
            sprrend.sprite = hornList[2];
            // pos
            this.transform.localPosition = new Vector3(-1.05f, 2.85f, 0.29f);
        }

    }

    // Update is called once per frame
    void Update () {
	
	}
}
