using System;
using Agate.MVC.Base;
using ExampleGame.Boot;
using ExampleGame.GameSystem.Module.SaveData;

namespace ExampleGame.GameSystem.Module.ClickGame
{
    public class ClickGameController : ObjectController<ClickGameController, ClickGameModel, IClickGameModel, ClickGameView>
    {
        private SaveDataController _saveData;

        private void OnClickSpendFood()
        {
            _model.SubstractFood();
        }

        private void OnClickSpendDrink()
        {
            _model.SubstractDrink();
        }

        private void OnClickBack()
        {
            SceneLoader.Instance.LoadScene("Home");
        }

        public override void SetView(ClickGameView view)
        {
            base.SetView(view);
            view.SetCallbacks(OnClickSpendFood, OnClickSpendDrink, OnClickBack);
        }

        internal void SetView(ExampleGame.Module.ClickGame.ClickGameView clickGameView)
        {
            throw new NotImplementedException();
        }
    }

}