using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonMision : MonoBehaviour
{
    public void cambiarEscena(string nombreEscena){
        SceneManager.LoadScene(3);
    }
}
