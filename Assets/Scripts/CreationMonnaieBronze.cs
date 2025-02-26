using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreationMonnaieBronze : MonoBehaviour
{
    
    [SerializeField] GameObject _prefab;
    
    void Start()
    {   
        Instantiate(_prefab, transform.position, transform.rotation);
    }

    

}
