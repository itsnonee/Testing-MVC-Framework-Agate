using System.Collections;
using Agate.MVC.Base;
using Agate.MVC.Core;
using ExampleGame.Boot;

namespace ExampleGame.Home
{
    public class HomeLauncher : SceneLauncher<HomeLauncher, HomeView>
    {
        protected override IConnector[] GetSceneConnectors()
        {
            return null;
        }

        protected override IController[] GetSceneDependencies()
        {
            return null;
        }

        protected override IEnumerator InitSceneObject()
        {
            yield return null;
            _view.SetCallbacks(OnClickGamePlayButton, OnClickGameSystemButton);
        }

        protected override IEnumerator LaunchScene()
        {
            yield return null;
        }

        // Use the same name with the scene that we add in build setting
        public override string SceneName => "Home";

        public static IMain Instance { get; internal set; }

        private void OnClickGamePlayButton()
        {
            SceneLoader.Instance.LoadScene("Gameplay");
        }

        private void OnClickGameSystemButton()
        {
            SceneLoader.Instance.LoadScene("GameSystem");
        }
    }
}