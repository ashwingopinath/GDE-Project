using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGameLose : MonoBehaviour
{
    
    public void OnTriggerEnter(Collider coll)
    {   
        UnityEngine.SceneManagement.SceneManager.LoadScene("GameOver");
    }
}
