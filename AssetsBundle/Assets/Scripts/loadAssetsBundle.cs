using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loadAssetsBundle : MonoBehaviour
{

    AssetBundle ab;
    public string path;
    public string ObjName;

    void Start()
    {
        LoadAssetsBundle(path);
        InstantiateAssets(ObjName);
    }

    //load assets bundles

    void LoadAssetsBundle(string urlAssets) {

        ab = AssetBundle.LoadFromFile(urlAssets);
    }


    //display objects in assets bunldes

    void InstantiateAssets(string assetsObj)
    {
        var prefab = ab.LoadAsset(assetsObj);
        Instantiate(prefab);
    }
 
}
