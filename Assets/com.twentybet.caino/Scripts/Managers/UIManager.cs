using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] GameObject menu;
    [SerializeField] GameObject game;

    [Space(10)]
    [SerializeField] GameObject backBtnGo;

    public void OpenGame()
    {
        menu.SetActive(false);
        game.SetActive(true);

        backBtnGo.SetActive(true);
    }

    public void Back()
    {
        game.SetActive(false);
        menu.SetActive(true);
        backBtnGo.SetActive(false);
        UnityEngine.SceneManagement.SceneManager.LoadScene("game");
    }

    public void BackStatus(bool enable)
    {
        backBtnGo.GetComponent<Button>().interactable = enable;
    }
}