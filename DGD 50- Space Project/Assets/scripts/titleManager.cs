using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class titleManager : MonoBehaviour
{
   
   public void StartGame()
   {

       SceneManager.LoadScene("testScene");
   }

   public void QuitGame()
   {
       Application.Quit();
   }



}
