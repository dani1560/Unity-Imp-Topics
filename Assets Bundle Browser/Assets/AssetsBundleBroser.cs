using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssetsBundleBroser : MonoBehaviour
{
    IEnumerator Start()
    {
        string url = "E:\\assetsBundle\\enemy";
        WWW webReq = new WWW("file:///" + url);

        while (!webReq.isDone) {
            yield return null;

            AssetBundle assObj = webReq.assetBundle;

            if(assObj != null)
            {
                GameObject obj1 = assObj.LoadAsset("Cube (1)") as GameObject;
                Instantiate(obj1);

            }
            else
            {
                Debug.Log("Object not found");

            }
        }
    }

}
