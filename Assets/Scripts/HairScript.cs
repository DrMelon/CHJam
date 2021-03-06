﻿using UnityEngine;
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
        if (sprrend.sprite.name.Contains("hair2"))
        {
            this.transform.localPosition = new Vector3(-0.25f, 2.15f, -0.5f);
        }
        if (sprrend.sprite.name.Contains("hair1"))
        {
            this.transform.localPosition = new Vector3(-0.46f, 2.15f, -0.5f);
        }
        if (sprrend.sprite.name.Contains("hair5"))
        {
            this.transform.localPosition = new Vector3(-0.2f, 1.82f, -0.5f);
        }
        if (sprrend.sprite.name.Contains("hair3"))
        {
            this.transform.localPosition = new Vector3(-0.23f, 0.71f, -0.5f);
        }
        if (sprrend.sprite.name.Contains("hair4"))
        {
            this.transform.localPosition = new Vector3(-0.03f, 2.21f, -0.5f);
        }
        if (sprrend.sprite.name.Contains("hair6"))
        {
            this.transform.localPosition = new Vector3(-0.05f, 2.24f, -0.5f);
        }
        if (sprrend.sprite.name.Contains("hair7"))
        {
            this.transform.localPosition = new Vector3(-0.01f, 1.894f, -0.5f);
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
