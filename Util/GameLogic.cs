
namespace BlazorDex.Util
{
    public class GameLogic
    {
        private readonly GameAnimationService _animationService;

        public GameLogic(GameAnimationService animationService)
        {
            _animationService = animationService;
        }

        public async Task<int> HeroAttack(int heroDmg, int enemyArmor, int enemyHp, List<string> actionMessages)
        {
            /// Attack Logic
            int damageDealt = Math.Max(heroDmg - enemyArmor, 0);
    
            enemyHp -= damageDealt;

            /// Animation
            _animationService.SetGettingDamage(false, true, damageDealt);
            _animationService.SetIsAtt(true, true);
            await DisplayActionMessage("Hero attacks!", actionMessages);
            _animationService.SetTurn(false);
            await _animationService.ResetStatus();

            return enemyHp;
        }

        private async Task DisplayActionMessage(string message, List<string> actionMessages, int delay = 2000)
        {
            actionMessages.Add(message);
            await Task.Delay(delay);
            actionMessages.Remove(message);
        }
    }
}
