using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerChoose : MonoBehaviour
{
    public Characters characters;
    public Characters Viking;
    public Characters Wizard;
    public Characters Rouge;

    public void PlayerCharacter1() {


        characters.speed = Viking.speed;
        characters.jumpHeight = Viking.jumpHeight;
        characters.sprite = Viking.sprite;
        characters.damage = Viking.damage;
        characters.CPS = Viking.CPS;
        characters.AttackRange = Viking.AttackRange;
        characters.UltNumber = Viking.UltNumber;
        characters.HP = Viking.HP;
        characters.maxHP = Viking.maxHP;
        characters.animationController = Viking.animationController;
        characters.fireModeID = Viking.fireModeID;



        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);


    }

    public void PlayerCharacter2() {

        characters.speed = Wizard.speed;
        characters.jumpHeight = Wizard.jumpHeight;
        characters.sprite = Wizard.sprite;
        characters.damage = Wizard.damage;
        characters.CPS = Wizard.CPS;
        characters.AttackRange = Wizard.AttackRange; 
        characters.UltNumber = Wizard.UltNumber;
        characters.HP = Wizard.HP;
        characters.maxHP = Wizard.maxHP;
        characters.animationController = Wizard.animationController;
        characters.fireModeID = Wizard.fireModeID;

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }

    public void PlayerCharacter3()
    {
        characters.speed = Rouge.speed;
        characters.jumpHeight = Rouge.jumpHeight;
        characters.sprite = Rouge.sprite;
        characters.damage = Rouge.damage;
        characters.CPS = Rouge.CPS;
        characters.AttackRange = Rouge.AttackRange;
        characters.UltNumber = Rouge.UltNumber;
        characters.HP = Rouge.HP;
        characters.maxHP = Rouge.maxHP;
        characters.animationController = Rouge.animationController;
        characters.fireModeID = Rouge.fireModeID;

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
}
