using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public Rigidbody player;

    void Update()
    {
        if(player.position.y < -4.6)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }    
    }
}
