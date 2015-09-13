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
        if (sprrend.sprite.name.Contains("top1"))
        {
            this.transform.localPosition = new Vector3(-0.05f, -1.48f, -0.4f);
        }
        if (sprrend.sprite.name.Contains("top2"))
        {
            this.transform.localPosition = new Vector3(-0.05f, -1.3f, -0.4f);
        }
        if (sprrend.sprite.name.Contains("top3"))
        {
            this.transform.localPosition = new Vector3(-0.24f, -1.44f, -0.4f);
        }
        if (sprrend.sprite.name.Contains("top4"))
        {
            this.transform.localPosition = new Vector3(-0.05f, -1.18f, -0.4f);
        }
        if (sprrend.sprite.name.Contains("top5"))
        {
            this.transform.localPosition = new Vector3(-0.02f, -1.55f, -0.4f);
        }
        if (sprrend.sprite.name.Contains("top6"))
        {
            this.transform.localPosition = new Vector3(-0.17f, -1.38f, -0.4f);
        }
        if (sprrend.sprite.name.Contains("top7"))
        {
            this.transform.localPosition = new Vector3(0.02f, -1.29f, -0.4f);
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
