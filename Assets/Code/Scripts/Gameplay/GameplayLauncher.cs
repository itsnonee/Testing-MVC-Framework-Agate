using Agate.MVC.Base;
using Agate.MVC.Core;
using ExampleGame.Boot;
using ExampleGame.Module.ClickGame;
using ExampleGame.Module.Soundfx;
using System.Collections;

namespace ExampleGame.Gameplay
{
    public class GameplayLauncher : SceneLauncher<GameplayLauncher, GameplayView>
    {
        private ClickGameController _clickGame;
        protected override IConnector[] GetSceneConnectors()
        {
            return new IConnector[]
            {
                new GameplayConnector()
            };
        }

        protected override IController[] GetSceneDependencies()
        {
            return new IController[]
            {
                new ClickGameController(),
                new SoundfxController()
            };
        }
        protected override IEnumerator InitSceneObject()
        {
            yield return null;
            _clickGame.SetView(_view.ClickGameView);
        }

        protected override IEnumerator LaunchScene()
        {
            yield return null;
        }

        // Use the same name with the scene that we add in build setting
        public override string SceneName => "Gameplay";
    }
}