using Agate.MVC.Base;

namespace ExampleGame.GameSystem.Module.ClickGame
{
    public interface IClickGameModel : IBaseModel
    {
        public int Food { get; }
        public int Drink { get; }
    }
}