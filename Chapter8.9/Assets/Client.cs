using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

public class Client : MonoBehaviour
{
    private DroneObjectPool _pool;
    // Start is called before the first frame update
    void Start()
    {
        _pool = gameObject.AddComponent<DroneObjectPool>();
    }

    private void OnGUI()
    {
        if(GUI.Button(new Rect(100,100,100,100),"Spawn Drones"))
        {
            _pool.Spawn();
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
