using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ContactButton : MonoBehaviour
{
    public void MouseClick ()
    {
        SceneManager.LoadScene(2);
    }
}
