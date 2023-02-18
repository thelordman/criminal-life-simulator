using UnityEngine;

namespace Scenes.CharacterCreator
{
	public class BackButton : MonoBehaviour
	{
		[SerializeField]
		private GameObject confirmationBackground;

		public void Back()
		{
			if (confirmationBackground.activeSelf)
			{
				confirmationBackground.SetActive(false);
			}
		}
	}
}