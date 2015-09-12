using UnityEngine;
using System.Collections.Generic;

public class TopScript : MonoBehaviour {

    // List of possible tops
    public List<Sprite> topList;

    // Use this for initialization
    void Start()
    {
        // Pick a face.
        SpriteRenderer sprrend = this.GetComponent<SpriteRenderer>();
        sprrend.sprite = topList[Random.Range(0, topList.Count)];



        // Depending on chosen face, try to shuffle stuff around to fit.
        if (sprrend.sprite.name == "top2")
        {
            this.transform.localPosition = new Vector3(-0.05f, -1.3f, -0.4f);
        }
        if (sprrend.sprite.name == "top4")
        {
            this.transform.localPosition = new Vector3(-0.05f, -1.0f, -0.4f);
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
