using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SelectCharacter : MonoBehaviour
{
    private SceneMngr _sceneMngr;
    public Image image;
    public string path;
    private void Start()
    {
        _sceneMngr = FindObjectOfType<SceneMngr>();

    }


    public void CharacterSelect() {

       _sceneMngr.LoadAddressableLevel(path);
      

    }
}