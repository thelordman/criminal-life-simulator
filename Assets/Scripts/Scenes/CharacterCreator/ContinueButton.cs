using UnityEngine;

namespace Scenes.CharacterCreator
{
    public class ContinueButton : MonoBehaviour
    {
        [SerializeField] private GameObject confirmationBackground;

        public void Continue()
        {
            confirmationBackground.SetActive(!confirmationBackground.activeSelf);
        }
    }
}