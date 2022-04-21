using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class AssetsBundleBroser : MonoBehaviour
{
    IEnumerator Start()
    {
        string url = "E:\\assetsBundle\\enemy";
        // WWW webReq = new WWW("file:///" + url);
        //WWW replace with web request..
        UnityWebRequest webReq = UnityWebRequestAssetBundle.GetAssetBundle(url);

        while (!webReq.isDone) {
            yield return webReq.SendWebRequest();

            AssetBundle assObj = DownloadHandlerAssetBundle.GetContent(webReq);

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
