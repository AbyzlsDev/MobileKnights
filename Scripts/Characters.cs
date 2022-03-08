
using UnityEngine;

[CreateAssetMenu(fileName ="Characters", menuName ="Characters")]
public class Characters : ScriptableObject
{
    
    public float speed;
    public float jumpHeight;
    public int damage;
    public float CPS;
    public float AttackRange;
    public string description;
    public string Name;
    public float UltNumber;
    public float maxHP;
    public float pointsAfterKill;
    public RuntimeAnimatorController animationController;
    public float fireModeID; // 1 - melee; 2 - ranged
    public string lastScene;
    public string prefabPath;
    public float instanceTypeId;



}
