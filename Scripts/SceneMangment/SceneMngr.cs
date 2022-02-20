using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceProviders;
using UnityEngine.SceneManagement;
public class SceneMngr : MonoBehaviour
{
    public AssetReference scene;

    //Level loading
    private bool clearPreviousScene = false;
    private SceneInstance previousLoadedScene;

    public void LoadAddressableLevel(string addressableKey) {

       if (clearPreviousScene) {

            Addressables.UnloadSceneAsync(previousLoadedScene).Completed += (asyncHandle) => {

                clearPreviousScene = false;
                previousLoadedScene = new SceneInstance();

                Debug.Log("Level unloaded" + addressableKey);
            
            };
        
        }
        Addressables.LoadSceneAsync(addressableKey, LoadSceneMode.Single).Completed += (asyncHandle) => {

            clearPreviousScene = true;
            previousLoadedScene = asyncHandle.Result;

            Debug.Log("Level loaded" + addressableKey);
        };
    }
    public void loadLevel() {

        scene.LoadSceneAsync().Completed += SceneLoadComplete;

    }

    void Start()
    {
        loadLevel();
          
    }
    private void SceneLoadComplete(AsyncOperationHandle<SceneInstance> obj)
    {
        if (obj.Status == AsyncOperationStatus.Succeeded)
        {

            scene.InstantiateAsync();

        }
    }
    
   
   
}
