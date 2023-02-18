using UnityEngine.SceneManagement;

namespace Utilities.Scenes
{
	public enum Scene
	{
		MainMenu = 0,
		CharacterCreator = 1,
		Home = 2
	}

	public static class SceneExtensions
	{
		public static void Load(this Scene scene)
		{
			SceneManager.LoadScene((int) scene);
		}
	}
}