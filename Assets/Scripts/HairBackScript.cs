using UnityEngine;
using System.Collections.Generic;

public class HairBackScript : MonoBehaviour {

    // List of possible hairs
    public SpriteRenderer parentHair;
    public List<Sprite> hairList;

    // Use this for initialization
    void Start()
    {
        // Make hair alpha depending on parent hair type
        if (parentHair.sprite.name == "hair1" || parentHair.sprite.name == "hair5")
        {
            this.GetComponent<SpriteRenderer>().color = Color.white;
            Sprite outsprite;
            if (parentHair.sprite.name == "hair1")
            {
                outsprite = hairList[0];
                this.GetComponent<SpriteRenderer>().sprite = outsprite;
                this.transform.localPosition = new Vector3(-1.1f, 1.39f, 0.28f);
            }
            if (parentHair.sprite.name == "hair5")
            {
                outsprite = hairList[1];
                this.GetComponent<SpriteRenderer>().sprite = outsprite;
                this.transform.localPosition = new Vector3(-0.17f, 0.8f, 0.28f);
            }



        }
        else
        {
            this.GetComponent<SpriteRenderer>().color = Color.clear;
        }

        
    }

    // Update is called once per frame
    void Update()
    {

    }
}
