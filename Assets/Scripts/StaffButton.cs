using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StaffButton : MonoBehaviour
{
    public void MouseClick ()
    {
        SceneManager.LoadScene(3);
    }
}
