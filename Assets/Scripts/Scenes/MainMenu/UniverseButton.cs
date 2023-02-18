using UnityEngine;
using Utilities.Scenes;

namespace Scenes.MainMenu
{
	public class UniverseButton : MonoBehaviour
	{
		public void NewUniverse()
		{
			Scene.CharacterCreator.Load();
		}
	}
}