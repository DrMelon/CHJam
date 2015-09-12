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
        if (parentHair.sprite.name.Contains("hair1") || parentHair.sprite.name.Contains("hair3") || parentHair.sprite.name.Contains("hair5") || parentHair.sprite.name.Contains("hair6") )
        {
            this.GetComponent<SpriteRenderer>().color = Color.white;
            Sprite outsprite;
            if (parentHair.sprite.name == "hair1-1")
            {
                outsprite = hairList[0];
                this.GetComponent<SpriteRenderer>().sprite = outsprite;
                this.transform.localPosition = new Vector3(-1.1f, 1.39f, 0.28f);
            }
            if (parentHair.sprite.name == "hair1-2")
            {
                outsprite = hairList[1];
                this.GetComponent<SpriteRenderer>().sprite = outsprite;
                this.transform.localPosition = new Vector3(-1.1f, 1.39f, 0.28f);
            }
            if (parentHair.sprite.name == "hair1-3")
            {
                outsprite = hairList[2];
                this.GetComponent<SpriteRenderer>().sprite = outsprite;
                this.transform.localPosition = new Vector3(-1.1f, 1.39f, 0.28f);
            }

            if (parentHair.sprite.name == "hair3-1")
            {
                outsprite = hairList[3];
                this.GetComponent<SpriteRenderer>().sprite = outsprite;
                this.transform.localPosition = new Vector3(-0.28f, 0.91f, 0.28f);
            }
            if (parentHair.sprite.name == "hair3-2")
            {
                outsprite = hairList[4];
                this.GetComponent<SpriteRenderer>().sprite = outsprite;
                this.transform.localPosition = new Vector3(-0.28f, 0.91f, 0.28f);
            }
            if (parentHair.sprite.name == "hair3-3")
            {
                outsprite = hairList[5];
                this.GetComponent<SpriteRenderer>().sprite = outsprite;
                this.transform.localPosition = new Vector3(-0.28f, 0.91f, 0.28f);
            }

            if (parentHair.sprite.name == "hair5-1")
            {
                outsprite = hairList[6];
                this.GetComponent<SpriteRenderer>().sprite = outsprite;
                this.transform.localPosition = new Vector3(-0.17f, 0.8f, 0.28f);
            }
            if (parentHair.sprite.name == "hair5-2")
            {
                outsprite = hairList[7];
                this.GetComponent<SpriteRenderer>().sprite = outsprite;
                this.transform.localPosition = new Vector3(-0.17f, 0.8f, 0.28f);
            }
            if (parentHair.sprite.name == "hair5-3")
            {
                outsprite = hairList[8];
                this.GetComponent<SpriteRenderer>().sprite = outsprite;
                this.transform.localPosition = new Vector3(-0.17f, 0.8f, 0.28f);
            }

            if (parentHair.sprite.name == "hair6-1")
            {
                outsprite = hairList[9];
                this.GetComponent<SpriteRenderer>().sprite = outsprite;
                this.transform.localPosition = new Vector3(0.74f, 1.9f, 0.28f);
            }
            if (parentHair.sprite.name == "hair6-2")
            {
                outsprite = hairList[10];
                this.GetComponent<SpriteRenderer>().sprite = outsprite;
                this.transform.localPosition = new Vector3(0.74f, 1.9f, 0.28f);
            }
            if (parentHair.sprite.name == "hair6-3")
            {
                outsprite = hairList[11];
                this.GetComponent<SpriteRenderer>().sprite = outsprite;
                this.transform.localPosition = new Vector3(0.74f, 1.9f, 0.28f);
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
