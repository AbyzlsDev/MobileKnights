using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="Characters", menuName ="Characters")]
public class Characters : ScriptableObject
{
    
    public float speed;
    public float jumpHeight;
    public Sprite sprite;
    public int damage;
    public float CPS;
    public float AttackRange;
    public string description;
    public string Name;
    public float UltNumber;
    public float HP;
    public float maxHP;
    public float positionX;
    public float positionY;
    public float positionZ;
    public float pointsAfterKill;
    public float score;
    public RuntimeAnimatorController animationController;



}
