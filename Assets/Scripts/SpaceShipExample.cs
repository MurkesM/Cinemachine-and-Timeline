using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpaceShipExample : MonoBehaviour
{
    public void UnlockShip1() 
    {
        Debug.Log("You unlocked spaceship 1!");
    }

    public void UnlockShip2()
    {
        Debug.Log("You unlocked spaceship 2!");
    }

    public void LoadTestScene()
    {
        SceneManager.LoadScene(1);
    }
}