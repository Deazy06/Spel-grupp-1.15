using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoogieBox : MonoBehaviour
{
    SpriteRenderer sprite;
    List<Color> colorchoose;
    int activeColor = 0;
    float timer;
    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        colorchoose = new List<Color>();
        colorchoose.Add(Color.green);
        colorchoose.Add(Color.red);
        colorchoose.Add(Color.blue);
        colorchoose.Add(Color.white);
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 0.5f && activeColor < 3)
        {
            timer = 0;
            activeColor += 1;
            sprite.color = colorchoose[activeColor];
        }
        else if (timer >= 3 && activeColor == 3)
        {
            timer = 0;
            activeColor = 0;
            sprite.color = colorchoose[activeColor];
        }
    }
}
