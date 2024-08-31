using System.Threading.Tasks;


 public class EnemyActionsService
{
    private readonly GameAnimationService _animationService;
    private readonly Func<string, Task> _displayActionMessage;

    public EnemyActionsService(GameAnimationService animationService, Func<string, Task> displayActionMessage)
    {
        _animationService = animationService;
        _displayActionMessage = displayActionMessage;
    }

    public async Task UpgradeArmor(int enemyArmor)
    {
        enemyArmor += 10;
        _animationService.SetUpgradeArmor(false, true, 10);
        await _displayActionMessage("Enemy defends!");
        _animationService.SetTurn(true);
        await _animationService.ResetStatus();
    }

    public async Task Heal(int enemyHp, int enemyStartingHp)
    {
        enemyHp = Math.Min(enemyHp + 50, enemyStartingHp);
        _animationService.SetHealing(false, true, 50);
        await _displayActionMessage("Enemy heals!");
        _animationService.SetTurn(true);
        await _animationService.ResetStatus();
    }

    public async Task Boost(int enemyArmor, int enemyDmg)
    {
        enemyArmor += 5;
        enemyDmg += 10;
        _animationService.SetHeroBoosting(false, true, 5, 10);
        await _displayActionMessage("Enemy is Raging!");
        enemyDmg += 5;
        _animationService.SetTurn(true);
        await _animationService.ResetStatus();
    }
    public interface IDisplayService
{
    Task DisplayActionMessage(string message, int delay = 2000);
}
public interface IStateService
{
    void NotifyStateChanged();
}
public class StateService : IStateService
{
    public void NotifyStateChanged()
    {
        // Implement your state change notification logic
    }
}

}