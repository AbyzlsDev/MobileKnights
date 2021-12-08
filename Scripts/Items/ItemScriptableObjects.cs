using UnityEngine;
[CreateAssetMenu(menuName = "ItemScriptableObject", fileName = "ItemScriptableObject")]
public class ItemScriptableObjects : ScriptableObject
{
    public float ID;
    public GameObject gameObject;
    public float[] position = new float[2];
}
