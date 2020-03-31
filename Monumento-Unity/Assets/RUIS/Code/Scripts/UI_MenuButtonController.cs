using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace RUIS.UI
{
    public class UI_MenuButtonController : MonoBehaviour
    {
        public void LoadScene0()
        {
            SceneManager.LoadScene("UI_MENU");
        }
        public void LoadScene1()
        {
            SceneManager.LoadScene("tracking");
        }

        public void LoadScene2()
        {
            SceneManager.LoadScene("more");
        }
        //public void LoadScene3()
        //{
        //    SceneManager.LoadScene("")
        //}

        public void GoToMenu()
        {
            SceneManager.LoadScene("UI_MENU");
            
        }
    }
}