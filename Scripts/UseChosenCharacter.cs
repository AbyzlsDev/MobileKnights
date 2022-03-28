using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

public class UseChosenCharacter : MonoBehaviour
{
   
    void Start()
    {

        Addressables.LoadAssetAsync<GameObject>(PlayerChoose.path).Completed += (asyncHandle) =>
        {

            if (asyncHandle.Status == AsyncOperationStatus.Succeeded)
            {

                Addressables.InstantiateAsync(PlayerChoose.path);

            }

        };



    }

   
}
