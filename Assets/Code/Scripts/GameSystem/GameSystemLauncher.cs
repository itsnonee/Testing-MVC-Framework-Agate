using System.Collections;
using Agate.MVC.Base;
using Agate.MVC.Core;
using ExampleGame.Boot;
using ExampleGame.GameSystem.Module.ClickGame;

namespace ExampleGame.GameSystem
{


    public class GameSystemLauncher : SceneLauncher<GameSystemLauncher, GameSystemView>
    {
        private ClickGameController _clickGame;

        protected override IConnector[] GetSceneConnectors()
        {
            return new IConnector[]
            {
                
            };
        }

        protected override IController[] GetSceneDependencies()
        {
            return new IController[]
            {
                new ClickGameController()
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

        public override string SceneName => "GameSystem";

    }

}