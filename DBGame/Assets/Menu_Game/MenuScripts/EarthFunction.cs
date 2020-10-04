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

    public void Mission3()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    }
    public void BackToMenu(){
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -1);
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
