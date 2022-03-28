using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class FindCharacterSprite : MonoBehaviour
{
    private Sprite currentPlayerSprite;
    void FixedUpdate()
    {
        currentPlayerSprite = GameObject.FindWithTag("Player").GetComponent<SpriteRenderer>().sprite;
        
        GetComponent<Image>().sprite = currentPlayerSprite;

    }

}
