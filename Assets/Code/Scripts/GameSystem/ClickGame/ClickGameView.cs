using UnityEngine;
using Agate.MVC.Base;
using UnityEngine.UI;
using UnityEngine.Events;

namespace ExampleGame.GameSystem.Module.ClickGame
{
    public class ClickGameView : ObjectView<IClickGameModel>
    {
        [SerializeField] private Text _foodText;
        [SerializeField] private Text _drinkText;
        [SerializeField] private Button _spendFoodButton;
        [SerializeField] private Button _spendDrinkButton;
        [SerializeField] private Button _backButton;

        public void SetCallbacks(UnityAction onClickSpendFood, UnityAction onClickSpendDrink, UnityAction onClickBack)
        {
            _spendDrinkButton.onClick.RemoveAllListeners();
            _spendDrinkButton.onClick.RemoveAllListeners();
            _backButton.onClick.RemoveAllListeners();
            _spendFoodButton.onClick.AddListener(onClickSpendFood);
            _spendDrinkButton.onClick.AddListener(onClickSpendDrink);
            _backButton.onClick.AddListener(onClickBack);
        }
        protected override void InitRenderModel(IClickGameModel model)
        {
            _foodText.text = $"Food: {model.Food.ToString()}";
            _drinkText.text = $"Food: {model.Drink.ToString()}";
        }

        protected override void UpdateRenderModel(IClickGameModel model)
        {
            _foodText.text = $"Food: {model.Food.ToString()}";
            _drinkText.text = $"Food: {model.Drink.ToString()}";
        }
    }

}