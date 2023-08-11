using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    private Movement playerInput;
    public GameObject bulletPrefab;

    private void Awake()
    {
        playerInput = new Movement();
    }

    private void OnEnable()
    {
        playerInput.Enable();
    }

    private void OnDisable()
    {
        playerInput.Disable();
    }



   

    
    void Update()
    {
        if (playerInput.Player.Fire.triggered)
        {
            
       // Instantiate(Ball);
          Instantiate(bulletPrefab,transform.position,bulletPrefab.transform.rotation);
       }

       //  if(Input.GetKeyDown(KeyCode.Space)) 
       //  {
       //    //  Instantiate(bulletPrefab);
       //      Instantiate(bulletPrefab, transform.position, bulletPrefab.transform.rotation);
       //  }
    }
}
