using UnityEngine;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour
{
    public GameObject[] panels; // menu, settings, info
    public AudioSource audio;

    

     void Start() {
         for (int i = 0; i < panels.Length; i++)
         {
             panels[i].SetActive(false);
         }
         panels[0].SetActive(true);
    }

    

    public void Active(int _index)
    {
        audio.Play();
         for (int i = 0; i < panels.Length; i++)
         {
             panels[i].SetActive(false);
         }
         panels[_index].SetActive(true);
         
    }

    public void playGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }


    
}
