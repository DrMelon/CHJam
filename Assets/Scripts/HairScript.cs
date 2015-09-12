using UnityEngine;
using System.Collections.Generic;

public class HairScript : MonoBehaviour {

    // List of possible hairs
    public List<Sprite> hairList;

    // Use this for initialization
    void Start()
    {
        // Pick a face.
        SpriteRenderer sprrend = this.GetComponent<SpriteRenderer>();
        sprrend.sprite = hairList[Random.Range(0, hairList.Count)];



        // Depending on chosen face, try to shuffle stuff around to fit.
        if (sprrend.sprite.name == "hair2")
        {
            this.transform.localPosition = new Vector3(-0.25f, 2.15f, -0.5f);
        }
        if (sprrend.sprite.name == "hair1")
        {
            this.transform.localPosition = new Vector3(-0.46f, 2.15f, -0.5f);
        }
        if (sprrend.sprite.name == "hair5")
        {
            this.transform.localPosition = new Vector3(-0.2f, 1.82f, -0.5f);
        }
        if (sprrend.sprite.name == "hair3")
        {
            this.transform.localPosition = new Vector3(-0.03f, 2.21f, -0.5f);
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
