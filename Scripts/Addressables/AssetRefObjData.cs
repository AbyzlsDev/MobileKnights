using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;

public class AssetRefObjData : MonoBehaviour
{
   // [SerializeField] private AssetReference _playerRef;
    [SerializeField] private List<AssetReference> _refs = new List<AssetReference>();

    [SerializeField] private List<GameObject> _completedObj = new List<GameObject>();

    private void Start()
    {
       // _refs.Add(_playerRef);

        StartCoroutine(LoadAndWaitUntilComplete());
    }

    private IEnumerator LoadAndWaitUntilComplete() {

        yield return AssetRef.CreateAssetsAddToList(_refs, _completedObj);
    
    }

    
}
