using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;

namespace SpeedTutorMainMenuSystem
{
public class EarthFunction : MonoBehaviour
{
    // Start is called before the first frame update
    string scena1;
    string scena2;

    void Start()
    {
        
    }

    // Update is called once per frame
    public void ResetButton(string ButtonType)
            {
            if (ButtonType == "Mission3")
            {
                SceneManager.LoadScene(scena1);

            }

            if (ButtonType == "Back")
            {
                SceneManager.LoadScene(scena2);

            }           
            }

}
}
