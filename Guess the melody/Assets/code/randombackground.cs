using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class randombackground : MonoBehaviour
{
    public Image background;
    public Sprite[] sprites;
    public int x;
    void Start()
    {
        x = Random.Range(0, 9);
        background.sprite = sprites[x];
    }

}
