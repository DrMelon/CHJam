using UnityEngine;
using System.Collections;


public class SmallFriendScript : MonoBehaviour {


    // Useful magic numberss
    // Z can be 4 or 1 (behind or in front of coffee table)
    // scale from 0.33 to... 0.45? ish

    // Sprite refs
    public Sprite friendSprite1;
    public Sprite friendSprite2;
    public Sprite friendSprite3;
    public Sprite friendSprite4;

    // Movement stuff
    float timeLeftMoving;
    float timeWaiting;
    bool isWaiting = true;
    Vector3 nextPos;
    

    // Use this for initialization
    void Start () {
        // Pick small friend sprite, 1-4
        SpriteRenderer thisFriend = this.GetComponent<SpriteRenderer>();
        int spritenum = Random.Range(1, 5);
        if (spritenum == 1)
        {
            thisFriend.sprite = friendSprite1;
        }
        if (spritenum == 2)
        {
            thisFriend.sprite = friendSprite2;
        }
        if (spritenum == 3)
        {
            thisFriend.sprite = friendSprite3;
        }
        if (spritenum == 4)
        {
            thisFriend.sprite = friendSprite4;
        }

        // Pick scale
        //this.transform.localScale.Set(0.33f, 0.33f, 0.33f);

        // Set hue shift
        // Get all pixels, set all pixels (sounds terrible, but is only done once)
        Texture2D copyTex = new Texture2D(thisFriend.sprite.texture.width, thisFriend.sprite.texture.height, thisFriend.sprite.texture.format, false);
        Color[] thePixels = thisFriend.sprite.texture.GetPixels(0, 0, copyTex.width, copyTex.height);
        float shift = Random.Range(0.0f, 1.0f);
        for (int i = 0; i < thePixels.Length; i++)
        {

            HSBColor hsb = HSBColor.FromColor(thePixels[i]);
            hsb.h = shift;
            thePixels[i] = hsb.ToColor();
            
        }
        copyTex.alphaIsTransparency = thisFriend.sprite.texture.alphaIsTransparency;
        
        copyTex.SetPixels(0, 0, copyTex.width, copyTex.height, thePixels);
        copyTex.Apply();

        thisFriend.sprite = Sprite.Create(copyTex, new Rect(0, 0, thisFriend.sprite.texture.width, thisFriend.sprite.texture.height), new Vector2(0.5f, 0.5f));

        

    }

    void PickNewDir()
    {
        // pick new position
        nextPos = this.transform.position;
        nextPos.x += Random.Range(-3.0f, 3.0f);
        nextPos.y += Random.Range(-1.0f, 1.0f);
        if (nextPos.x < -1.0f)
        {
            nextPos.x = -1.0f;
        }
        if (nextPos.x > 8.5f)
        {
            nextPos.x = 8.5f;
        }
        if (nextPos.y < -1.69f)
        {
            nextPos.z = 1;
        }
        else
        {
            nextPos.z = 4;
        }
        if (nextPos.y < -3.0f)
        {
            nextPos.y = 3.0f;
        }
        if (nextPos.y > 2.95f)
        {
            nextPos.y = 2.95f;
        }

        if(nextPos.x > 3 && nextPos.x < 8)
        {
            if(nextPos.y > -1.35f && nextPos.y < -0.5f)
            {
                PickNewDir();
            }
        }

        
    }

	
	// Update is called once per frame
	void Update ()
    {
        if (isWaiting && timeWaiting <= 0)
        {
            timeLeftMoving = Random.Range(1.0f, 3.5f);


            PickNewDir();





            isWaiting = false;
        }
        if (timeLeftMoving <= 0 && isWaiting == false)
        {
            timeWaiting = Random.Range(1.0f, 3.5f);
            isWaiting = true;
        }

        timeWaiting -= 1.0f / 60.0f;
        timeLeftMoving -= 1.0f / 60.0f;

        if (isWaiting == false)
        {
            Vector3 directionVec = nextPos - this.transform.position;
            if (directionVec.magnitude > 0.05f)
            {
                if (directionVec.x < 0)
                {
                    this.transform.localScale = new Vector3(-1.0f, 1.0f, 1.0f);
                }
                else
                {
                    this.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
                }

                directionVec.Normalize();
                // move in direction
                this.transform.position = this.transform.position + (directionVec * (0.03f * timeLeftMoving));
            }
        }


    }
}
