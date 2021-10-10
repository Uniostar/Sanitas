using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Home : MonoBehaviour
{
    public InputField usernameInput;
    public Button Submit;

    public void TestHealth()
    {
        SceneManager.LoadScene(2);
    }
    public void TestIllness()
    {
        SceneManager.LoadScene(3);
    }
}
