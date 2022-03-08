using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

public class LoadEnemyAddressables : MonoBehaviour
{
    public Characters[] enemyScriptableObject;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
        foreach (Characters character in enemyScriptableObject)
        {
            
            Addressables.LoadAssetAsync<GameObject>(character.prefabPath).Completed += (asyncHandle) =>
            {
                if (asyncHandle.Status == AsyncOperationStatus.Succeeded)
                { 
                    Addressables.InstantiateAsync(character.prefabPath);

                    Debug.Log("Loaded" + character.prefabPath);
                }

            };
            
        }

       
        



    }

   
}
