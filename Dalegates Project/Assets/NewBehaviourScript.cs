using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
   
    private void OnEnable()
    {
        delegates.abc += akrimaMota;
        delegates.delegates2 += akrimachota;
        delegates.delegates3 += akrimakhota;
    }

    private void OnDisable()
    {
        delegates.abc -= akrimaMota;
        delegates.delegates2 -= akrimachota;
        delegates.delegates3 -= akrimakhota;
    }
    void akrimachota(string a, int b)
    {
        Debug.Log("Akrima Huzaifa clicked" + "" + a +  b);
    }
    public void akrimaMota(int a)
    {
        Debug.Log("Akrima Huzaifa clicked"+""+a);
    }
    public void Check(int a)
    {
        Debug.Log(a);
      
    }
    string akrimakhota()
    {
        Debug.Log("zeee");
        return "huzaifa";
    }
    // Update is called once per frame
    void Update()
    {
     
    }
}
