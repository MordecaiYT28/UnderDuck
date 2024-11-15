using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class skip : MonoBehaviour
{
    public void Skip()
    {
        if (Input.GetKeyUp(KeyCode.Z))
        {
            SceneManager.LoadScene("inicio");
        }
    }
}
