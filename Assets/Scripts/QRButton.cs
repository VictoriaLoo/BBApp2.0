using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QRButton : MonoBehaviour
{
    public void MouseClick ()
    {
        SceneManager.LoadScene(6);
    }
}
