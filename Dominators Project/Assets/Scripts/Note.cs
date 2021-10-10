using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Note : MonoBehaviour
{
    public void Accept()
    {
        SceneManager.LoadScene(1);
    }
}
