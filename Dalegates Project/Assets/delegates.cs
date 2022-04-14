using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class delegates : MonoBehaviour
{   //dalegates
    public delegate void MyNewDelegate(int a);
    public static event MyNewDelegate abc;
    
    //event action
    public static event Action<string, int> delegates2;
    public static event Func<string> delegates3;
    public UnityEvent Jump;
    //[Serializable]
    /*public class Move : UnityEvent <int> {}
    Move m;*/
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //m.Invoke(3);
            Jump.Invoke();
            delegates2?.Invoke("Abc", 2);
            abc?.Invoke(2);
            delegates3?.Invoke();
        }
    }
}
