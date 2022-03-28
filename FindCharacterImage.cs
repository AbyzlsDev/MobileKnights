using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FindCharacterImage : MonoBehaviour
{
    public Characters character;
    
    void Start()
    {
        GetComponent<Image>().sprite = character.characterImage;
    }

   
}
