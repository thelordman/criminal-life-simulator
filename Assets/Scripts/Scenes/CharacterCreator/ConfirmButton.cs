using UnityEngine;
using Utilities.Scenes;

namespace Scenes.CharacterCreator
{
	public class ConfirmButton : MonoBehaviour
	{
		public void Confirm()
		{
			Scene.Home.Load();
		}
	}
}